using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Office.Interop.Excel;
using Chart = System.Windows.Forms.DataVisualization.Charting.Chart;
using ChartArea = System.Windows.Forms.DataVisualization.Charting.ChartArea;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;

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
                Workbook libros_trabajo;
                Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Worksheet)libros_trabajo.Worksheets.get_Item(1);
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
                    XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
                
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



        public void GenerarHistograma(string seleccion,List<double> serie , Chart histograma,Panel pnlHistograma)
        {
            int valorIntervalo = Convert.ToInt32(seleccion);


            double minimo = serie.Min();
            double maximo = serie.Max();
            double anchoDeSerie = (maximo - minimo) / valorIntervalo;


            // Calcular Frecuencia de aparicion 
            //lo hago con un contador, la frecuencia
            // que tiene una longitud del tamaño de los intervalos , y en cada 
            // posicion aumenta en 1 cuando se da la aparicion de algun valor en el intervalo
            int[] frecuencias = new int[valorIntervalo];
            foreach (double pseudoab in serie)
            {

                //calculo el indice del intervalo
                int indice = (int)Math.Floor((pseudoab - minimo) / anchoDeSerie);
                //Compruebo que el indice este entre 0 y el valor maximo del intervalo para no irme 
                //fuera del intervalo
                if (indice >= 0 && indice < valorIntervalo)
                {
                    //en el arreglo de frecuencias, en la posicion del indice sumo 1
                    frecuencias[indice]++;
                }


            }




            //serie con los valores de marcas de clase y las frecuencias correspondientes
            Series serieValores = new Series();
            for (int i = 0; i < valorIntervalo; i++)
            {
                double limiteInferior = minimo + (i * anchoDeSerie);
                double limiteSuperior = minimo + ((i + 1) * anchoDeSerie);
                double marcaDeClase = (limiteInferior + limiteSuperior) / 2;

                serieValores.Points.AddXY(marcaDeClase, frecuencias[i]);

            }

            // Verificar si el Chart ya existe
            if (histograma == null)
            {

                histograma.Dock = DockStyle.Fill;

                // Configurar el área del gráfico
                ChartArea chartArea = new ChartArea();
                histograma.ChartAreas.Add(chartArea);

                // Agregar el control Chart al Panel
                pnlHistograma.Controls.Add(histograma);
            }


            
            serieValores.BorderWidth = 1;
            serieValores.BorderColor = Color.Black;


            // Mostrar el histograma Configurado 
            histograma.Series.Clear();
            histograma.Series.Add(serieValores);

            histograma.ChartAreas[0].AxisX.IsLabelAutoFit = false;

            histograma .ChartAreas[0].AxisX.Title = "Valor";
            histograma.ChartAreas[0].AxisY.Title = "Frecuencia";

            histograma.ChartAreas[0].AxisY.Minimum = 0;
            histograma.ChartAreas[0].AxisX.Minimum = minimo;
            histograma.ChartAreas[0].AxisX.Maximum = maximo;

            histograma.ChartAreas[0].AxisY.Interval = 1;

            histograma.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            histograma.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            histograma.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            histograma.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            histograma.Series["Series1"]["PointWidth"] = "1";
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


        //Obtener la serie cargada en el datagridview
        public List<double> ObtenerSerie(string columnName,DataGridView dtgseries)
        {
            List<double> serie = new List<double>();

            // Verificar si la columna existe
            if (!dtgseries.Columns.Contains(columnName))
            {
                MessageBox.Show($"La columna '{columnName}' no existe en el DataGridView.");
                return serie;
            }

            // Obtener el índice de la columna seleccionada
            int columnIndex = dtgseries.Columns[columnName].Index;

            // Recorrer las filas para obtener los datos de la columna seleccionada
            foreach (DataGridViewRow row in dtgseries.Rows)
            {
                if (row.Cells[columnIndex].Value != null)
                {
                    double value;
                    if (double.TryParse(row.Cells[columnIndex].Value.ToString(), out value))
                    {
                        serie.Add(value);
                    }
                }
            }

            return serie;
        }


    }
}
