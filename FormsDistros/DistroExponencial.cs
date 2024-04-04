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
                    if (funciones.EsMascaraVacia(valorLambda))
                    {
                        MessageBox.Show(" ¡El valor de lambda no puede quedar Vacio!");
                        return;
                    }
                    else
                    {
                        //Genero los pseudoaleatorio
                        Random rnd = new Random();
                        for (int i = 0; i < int.Parse(valorMuestra.Text); i++)
                        {
                            //Pseudo
                            double pseudo = rnd.NextDouble();
                            pseudo = Math.Round(pseudo, 4);

                            //Parametro lambda
                            double lambda = double.Parse(valorLambda.Text);
                            //Calculo el valor 
                            double x = -1 / lambda * Math.Log(1 - pseudo);

                            //Trunco a 4 decimales
                            x = Math.Round(x, 4);

                            //Agrego al datagrid
                            dtgSerie.Rows.Add((i + 1), x);
                        }
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

       
    }
}
