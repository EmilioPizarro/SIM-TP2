using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_2.Entidades
{
    public class Funciones
    {

        //Esta funcion basicamente se fija que 
        public void ProcesarTeclaPresionada(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un dígito o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora la tecla presionada si no es un dígito ni la tecla de retroceso
                return;
            }

            // Obtiene el texto actual del MaskedTextBox
            MaskedTextBox textBox = (MaskedTextBox)sender;
            string currentText = textBox.Text;

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



        }

        // Función para verificar si el texto contiene solo caracteres de formato de máscara
        public bool EsMascaraVacia(MaskedTextBox textBox)
        {
            // Obtener el valor sin los caracteres de formato de máscara
            string valorFormateado = textBox.Text.Replace(textBox.Culture.NumberFormat.NumberGroupSeparator, "")
                                                   .Replace(textBox.Culture.NumberFormat.NumberDecimalSeparator, "");

            // Verificar si el valor formateado es nulo o vacío después de eliminar los caracteres de formato de máscara
            return string.IsNullOrWhiteSpace(valorFormateado);
        }

        //Validar el tamaño de una muestra
        public bool tamañoMuestra(int valor)
        {
              
            if (valor <= 1000000)
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }
    }
}
