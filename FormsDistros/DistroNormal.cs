using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_2.Entidades;

namespace TP_2
{
    public partial class DistroNormal : Form
    {
        private Funciones funciones = new Funciones();
        public DistroNormal()
        {
            InitializeComponent();
        }

        private void valorMuestra_KeyPress(object sender, KeyPressEventArgs e)
        {
            funciones.ProcesarTeclaPresionada(sender, e);
        }

        private void valorMedia_KeyPress(object sender, KeyPressEventArgs e)
        {
            funciones.ProcesarTeclaPresionada(sender, e);
        }

        private void valorDesviacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            funciones.ProcesarTeclaPresionada(sender, e);
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
            Principal formPrincipal = new Principal();
            formPrincipal.Show();
            this.Close();
        }

       
        private void btnGenerarSerie_Click_1(object sender, EventArgs e)
        {
            //limpio el datagrid cada vez que genero una serie
            dtgSerie.Rows.Clear();

            //Genero la serie de 0,1
            funciones.GenerarSerie(dtgSerie, valorMuestra.Text);

        }

        private void btnGenerarNormal_Click(object sender, EventArgs e)
        {
            DataGridViewCell primerCelda = dtgSerie.Rows[0].Cells[1];
            if (primerCelda.Value == null || primerCelda.Value.ToString() == "")
            {
                // La primera celda de la columna está vacía
                MessageBox.Show("Es Necesario Generar la serie de Pseudoaleatorios Primero!.");
                return;
            }
            else
            {
                string mediaSinComa = valorMedia.Text.Replace(",", "");
                string desviacionSinComa = valorDesviacion.Text.Replace(",", "");
                if (string.IsNullOrWhiteSpace(mediaSinComa) || string.IsNullOrWhiteSpace(desviacionSinComa))
                {
                    MessageBox.Show("!La media y la Desviacion no pueden quedar vacios¡");
                    return;
                }
                else
                {
                    double media = Convert.ToDouble(valorMedia.Text);
                    double desviacion = Convert.ToDouble(valorDesviacion.Text);

                    
                     for (int i = 0; i < dtgSerie.RowCount; i+=2)
                    {
                        //Obtengo los randoms de las filas, de a pares, es decir de a 2
                        double rnd1;
                        double rnd2;
                        
                        //Por las dudas valido que no haya contenido vacio, los convierto a double y los devuelvo
                        if (dtgSerie.Rows[i].Cells[1].Value != null &&
                           double.TryParse(dtgSerie.Rows[i].Cells[1].Value.ToString(), out rnd1))
                        {
                            if(dtgSerie.Rows[i+1].Cells[1].Value != null &&
                           double.TryParse(dtgSerie.Rows[i+1].Cells[1].Value.ToString(), out rnd2))
                           {

                                //Ya con los dos randoms puedo aplicar boxmuller de a pares
                                double n_1 = (Math.Sqrt(-2 * Math.Log(rnd1)) * Math.Cos(2 * Math.PI * rnd2));
                                n_1 = (n_1 * desviacion) + media;


                                double n_2 = (Math.Sqrt(-2 * Math.Log(rnd1)) * Math.Sin(2 * Math.PI * rnd2));
                                n_2 = (n_2 * desviacion) + media;

                                //truncar a 4
                                n_1 = Math.Round(n_1, 4);
                                n_2 = Math.Round(n_2, 4);


                                //asignar valores a la serie
                                dtgSerie.Rows[i].Cells[2].Value = n_1;
                                dtgSerie.Rows[i+1].Cells[2].Value = n_2;

                            }

                        }
                    
                    }

                }


            }


        }

        private void btnHistograma_Click(object sender, EventArgs e)
        {
            List<double> serieNormal = funciones.ObtenerSerie("Serie_Normal",dtgSerie);
            if (serieNormal.Count == 0)
            {
                MessageBox.Show("No hay datos generados!");
                return;
            }
            else
            {
                if (cmbIntervalos.SelectedItem != null)
                {
                    string seleccion = cmbIntervalos.SelectedItem.ToString();
                    funciones.GenerarHistograma(seleccion, serieNormal, histogramaNormal, pnlHistograma,dtgFrecuencias);
            }
                else
                {
                    MessageBox.Show("Debe seleccionar la cantidad de Intervalos a utilizar!");
                    return;
                }
            }
            
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //generar un excel 
            funciones.ExportarDataGridViewExcel(dtgSerie);
        }
    }
}
