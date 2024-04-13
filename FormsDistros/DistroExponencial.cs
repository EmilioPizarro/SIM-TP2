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

            //Valido espacios vacios o en blanco en la muestra y lambda
            if (string.IsNullOrWhiteSpace(valorMuestra.Text))
            {
                MessageBox.Show(" ¡El valor de la muestra no puede quedar Vacio!");
                return;
            }

            else
            {
                Funciones funciones = new Funciones();
                if (funciones.tamañoMuestra(int.Parse(valorMuestra.Text)))
                {
                    Random rnd = new Random();
                    for (int i = 0; i < int.Parse(valorMuestra.Text); i++)
                    {
                        double pseudo = rnd.NextDouble();
                        pseudo = Math.Round(pseudo, 4);

                        //Agregar el valor a la columna de la serie de pseudos
                        dtgSerie.Rows.Add((i + 1), pseudo);

                    }

                }
                else
                {
                    MessageBox.Show("!La muestra no puede ser mayor a 1.000.000!");
                    valorMuestra.Text = " ";
                    return;
                }

                
            }

           
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
                string sinComaDecimal = valorLambda.Text.Replace(".", "");
                if (string.IsNullOrWhiteSpace(sinComaDecimal))
                {
                    MessageBox.Show("!El valor de Lambda no puede quedar vacio¡");
                    return;
                }
                else
                {
                    double lambda = double.Parse(valorLambda.Text);
                    for (int i = 0; i < dtgSerie.RowCount; i++)
                    {
                        double valorOriginal;
                        if (dtgSerie.Rows[i].Cells[1].Value != null &&
                            double.TryParse(dtgSerie.Rows[i].Cells[1].Value.ToString(), out valorOriginal))
                        {
                            //Calculo el valor segun la formula Exponencial
                            double pseudo_expo = (-1 / lambda) * Math.Log(1 - valorOriginal);
                            pseudo_expo = Math.Round(pseudo_expo, 4);

                            //Asignar el valor a la serie exponencial
                            dtgSerie.Rows[i].Cells[2].Value = pseudo_expo;
                        
                        }
                    }
                }
            }
        }
    }
}
