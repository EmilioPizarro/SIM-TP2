using MathNet.Numerics.Statistics;
using Microsoft.Office.Interop.Excel;
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
using System.Windows.Forms.DataVisualization.Charting;
using TP_2.Entidades;
using ChartArea = System.Windows.Forms.DataVisualization.Charting.ChartArea;
using DataTable = System.Data.DataTable;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;

namespace TP_2
{
    public partial class DistroUniforme : Form
    {
        private Funciones funciones = new Funciones();
        public DistroUniforme()
        {
            InitializeComponent();
        }

        private void valorMuestra_KeyPress(object sender, KeyPressEventArgs e)
        {
            funciones.ProcesarTeclaPresionada(sender, e);
        }

        private void limInferior_KeyPress(object sender, KeyPressEventArgs e)
        {
            funciones.ProcesarTeclaPresionada(sender, e);
        }

        private void limSuperior_KeyPress(object sender, KeyPressEventArgs e)
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


        private void btnGenerarAB_Click(object sender, EventArgs e)
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
                if (string.IsNullOrWhiteSpace(limInferior.Text) && string.IsNullOrWhiteSpace(limSuperior.Text))
                {
                    MessageBox.Show("¡Ambos limites deben llevar valores!");
                    return;
                }
                else
                {
                    double inferior = double.Parse(limInferior.Text);
                    double superior = double.Parse(limSuperior.Text);
                    //Validacion obvia de los limites
                    if (inferior > superior)
                    {

                        MessageBox.Show("¡El limite Inferior no puede ser mayor que el limite Superior!");
                        //Si no son validos dejar el campo en blanco
                        limInferior.Text = " ";
                        limSuperior.Text = " ";
                        return;
                    }
                    else
                    {
                        for (int i = 0; i < dtgSerie.RowCount; i++)
                        {

                            double valorOriginal;
                            //Tratar de obtener y convertir a double el valor de la primer celda de los pseudos, y devolcerlo para manipularlo segun
                            //la distribucion.
                            if (dtgSerie.Rows[i].Cells[1].Value != null &&
                                double.TryParse(dtgSerie.Rows[i].Cells[1].Value.ToString(), out valorOriginal))
                            {
                                // Calcular el nuevo valor según la fórmula uniforme ab
                                double pseudo_ab = valorOriginal * (superior - inferior) + inferior;
                                pseudo_ab = Math.Round(pseudo_ab, 4);

                                // Asignar el nuevo valor a la serie ab
                                dtgSerie.Rows[i].Cells[2].Value = pseudo_ab;
                            }
                        }




                    }
                }



            }
        }

        //No funciona pero no lo borro porque sirve para comparar 


        private void btnHistograma_Click(object sender, EventArgs e)

        {
            //Genero un arreglo con los valores de la columna que me interesa del datagrid, en este caso la funcion se puede usar para todas las series
            List<double> serie = funciones.ObtenerSerie("Serie_ab", dtgSerie);

            //Validar que no este vacio el arreglo
            if (serie.Count == 0)
            {
                MessageBox.Show("No hay datos generados!");
                return;
            }
            else
            {
                //Validamos que se haya seleccionado almenos una opcion de intervalo del combobox
                if (cmbIntervalos.SelectedItem != null)

                {
                    string seleccion = cmbIntervalos.SelectedItem.ToString();
                    funciones.GenerarHistograma(seleccion, serie, histogramaAB, pnlHistograma,dtgFrecuencias);

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
