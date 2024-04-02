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
    public partial class DistroNormal : Form
    {
        public DistroNormal()
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
        }
    }
}
