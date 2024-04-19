using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TP_2.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace TP_2
{
    public partial class DistroExponencial : Form
    {
        private Funciones funciones = new Funciones();
        public DistroExponencial()
        {
            InitializeComponent();
        
        }

        private void DistroExponencial_Load(object sender, EventArgs e)
        {

        }

       

        private void valorMuestra_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            funciones.ProcesarTeclaPresionada(sender, e);
        }

        private void valorLambda_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            funciones.ProcesarTeclaPresionada(sender, e);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Principal formPrincipal = new Principal();
            formPrincipal.Show();
            this.Close();
        }

        private void btnGenerarSerie_Click(object sender, EventArgs e)
        {
            //limpio el datagrid cada vez que genero una serie
            dtgSerie.Rows.Clear();
            

            //Genero la serie 0,1
            funciones.GenerarSerie(dtgSerie, valorMuestra.Text);
        }


        private void btnGenerarExponencial_Click(object sender, EventArgs e)
        {
            //Validar que no este vacio el contenido de la primer celda de la serie de pseudos,
            //si esta vacio es que no se genero la serie
            DataGridViewCell primerCelda = dtgSerie.Rows[0].Cells[1];
            if(primerCelda.Value == null || primerCelda.Value.ToString() == "")
            {
                MessageBox.Show("Es necesario Generar la serie de Pseudoaleatorios Primero!.");
                return;

            }
            else
            {
                //Tengo que limpiar la coma del campo de carga para que no la reconozca como caracter al momento
                //de validar si es entero o no 
               
                if (string.IsNullOrWhiteSpace(valorLambda.Text.Replace(","," ")))
                {
                    MessageBox.Show("!El valor de Lambda no puede quedar vacio¡");
                    return;
                }
                else
                {
                   
                    
                        for (int i = 0; i < dtgSerie.RowCount; i++)
                        {//Convierto a double lo cargado en la columna de ramdoms 
                            double valorOriginal;
                            if (dtgSerie.Rows[i].Cells[1].Value != null &&
                                double.TryParse(dtgSerie.Rows[i].Cells[1].Value.ToString(), out valorOriginal))
                            {
                                
                                
                                double lambda = double.Parse(valorLambda.Text.Trim());
                                double pseudo_expo = - (1 / lambda) * Math.Log(1 - valorOriginal);
                                pseudo_expo = Math.Round(pseudo_expo, 4);

                                //Asignar el valor a la serie exponencial
                                dtgSerie.Rows[i].Cells[2].Value = pseudo_expo;

                            }
                        }
                   
                        
                }
            }
        }

        private void btnGenerarHistograma_Click(object sender, EventArgs e)
        {
            List<double> serieExponencial = new List<double>();
            serieExponencial = funciones.ObtenerSerie("Serie_Exponencial", dtgSerie);

            if (serieExponencial.Count == 0)
            {
                MessageBox.Show("No hay datos generados!");
                return;
            }

            
            if(cmbIntervalos.SelectedItem != null)
            {
                string seleccion = cmbIntervalos.SelectedItem.ToString();

                funciones.GenerarHistograma(seleccion, serieExponencial, histogramaExponencial, pnlHistograma,dtgFrecuencias);


            }
            else
            {
                MessageBox.Show("Debe seleccionar la cantidad de Intervalos a Utilizar!");
                return;
            }

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //generar un excel 
            funciones.ExportarDataGridViewExcel(dtgSerie);
        }
    }
}
