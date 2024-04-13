using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace TP_2.Entidades
{
    public class Funciones
    {
        

        //Metodo de excel - Robadisimo de StackOverflow
        public void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        if (grd.Rows[i].Cells[j].Value != DBNull.Value)
                        {
                            hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value?.ToString();
                        }
                        else
                        {
                            hoja_trabajo.Cells[i + 1, j + 1] = null;
                        }
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                //Cursor.Current = Cursors.WaitCursor;//cambia el tipo de cursor al tipo wait
                aplicacion.Quit();
                // Cursor.Current = Cursors.Default;//restaura el tipo de cursor de defecto
            }
        }

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

        public void GenerarSerie(DataGridView dtgSerie, string valorMuestra)
        {
            //limpio el datagrid cada vez que genero una serie
            dtgSerie.Rows.Clear();

            //Valido espacios vacios o en blanco en la muestra 
            if (string.IsNullOrWhiteSpace(valorMuestra))
            {
                MessageBox.Show(" ¡El valor de la muestra no puede quedar Vacio!");
                return;
            }

            else
            {
                //Validar que la muestra acepte valores hasta 1000000
                Funciones validarMuestra = new Funciones();
                if (validarMuestra.tamañoMuestra(int.Parse(valorMuestra)))
                {
                    //Generacion de la serie de Pseudos Uniforme (0,1] 
                    Random rnd = new Random();

                    for (int i = 0; i < int.Parse(valorMuestra); i++)
                    {
                        double pseudo = rnd.NextDouble();
                        pseudo = Math.Round(pseudo, 4);


                        //Agregar el valor al datagrid
                        dtgSerie.Rows.Add((i + 1), pseudo);

                    }


                }
                else
                {
                    MessageBox.Show("!La muestra no puede ser mayor a 1.000.000!");
                    valorMuestra = " ";
                    return;
                }

            }
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
