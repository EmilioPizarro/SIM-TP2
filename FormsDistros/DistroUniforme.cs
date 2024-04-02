using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_2
{
    public partial class DistroUniforme : Form
    {
        public DistroUniforme()
        {
            InitializeComponent();
        }

        private void valorMuestra_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un dígito o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora la tecla presionada si no es un dígito ni la tecla de retroceso
                return;
            }

            // Obtiene el texto actual del MaskedTextBox
            string currentText = valorMuestra.Text;

            // Si se presionó la tecla de retroceso, se elimina el último carácter
            if (e.KeyChar == (char)Keys.Back)
            {
                // Si no hay nada que borrar, se sale del método
                if (string.IsNullOrEmpty(currentText))
                    return;

                currentText = currentText.Remove(currentText.Length - 1); // Elimina el último carácter
            }
            else
            {
                // Si no es una tecla de retroceso, se agrega el dígito presionado al texto actual
                currentText += e.KeyChar;
            }

            // Convierte el texto actual a un valor numérico
            int currentValue;
            if (!int.TryParse(currentText, out currentValue))
            {
                // Si el valor no se puede convertir a entero, se cancela la entrada
                e.Handled = true;
                return;
            }

            // Verifica si el valor excede el máximo permitido (1000000)
            if (currentValue > 1000000)
            {
                e.Handled = true; // Ignora la entrada si el valor excede el máximo
            }
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
                    if(inferior> superior)
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
            
            
        }
    }
}
