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
    public partial class DistroUniforme : Form
    {
        private Funciones funciones = new Funciones();
        public DistroUniforme()
        {
            InitializeComponent();
        }

        private void valorMuestra_KeyPress(object sender, KeyPressEventArgs e)
        {
            funciones.ProcesarTeclaPresionada(sender,e);
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

            //Valido espacios vacios o en blanco en la muestra 
            if (string.IsNullOrWhiteSpace(valorMuestra.Text))
            {
                MessageBox.Show(" ¡El valor de la muestra no puede quedar Vacio!");
                return;
            }

            else
            {
                //Validar que la muestra acepte valores hasta 1000000
                Funciones validarMuestra = new Funciones();
                if (validarMuestra.tamañoMuestra(int.Parse(valorMuestra.Text))) 
                {
                    if (string.IsNullOrWhiteSpace(limInferior.Text) && string.IsNullOrWhiteSpace(limSuperior.Text))
                    {
                        MessageBox.Show("¡Ambos limites deben llevar valores!");
                        return;
                    }
                    else
                    {
                        double inferior = int.Parse(limInferior.Text);
                        double superior = int.Parse(limSuperior.Text);
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
                            //Generacion del pseudo 
                            Random rnd = new Random();

                            for (int i = 0; i < int.Parse(valorMuestra.Text); i++)
                            {
                                double pseudo = rnd.NextDouble();
                                pseudo = Math.Round(pseudo, 4);

                                //Obedeciendo la formula del teorico
                                double x = pseudo * (superior - inferior) + inferior;
                                x = Math.Round(x, 4);
                                //Agregar el valor al datagrid
                                dtgSerie.Rows.Add((i + 1), x);
                            }

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
