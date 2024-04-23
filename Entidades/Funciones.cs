using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Chart = System.Windows.Forms.DataVisualization.Charting.Chart;
using ChartArea = System.Windows.Forms.DataVisualization.Charting.ChartArea;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;

namespace TP_2.Entidades
{
    public class Funciones
    {


        //Metodo de excel
        public void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            //le defino la extension que quiero que tenga, en este caso excel
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application excelApp;
                Workbook libro;
                Worksheet hoja;
                //Abrir Excel
                excelApp = new Microsoft.Office.Interop.Excel.Application();

                // Crear un nuevo libro de trabajo de Excel
                libro = excelApp.Workbooks.Add();
                hoja = (Worksheet)libro.Worksheets.get_Item(1);
                //Poner Columnas en excel
                for (int j = 0; j < grd.Columns.Count; j++)
                {
                    hoja.Cells[1, j+1] = grd.Columns[j].HeaderText;

                }
                // Copiar los datos desde el DataGridView a Excel
                for (int i = 0; i < grd.Rows.Count; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        if (grd.Rows[i].Cells[j].Value != DBNull.Value && grd.Rows[i].Cells[j].Value != null)
                        {

                            //Si va por el false es porque no se pudo pasar a int y resulto ser el valor de serie
                            double valor = Convert.ToDouble(grd.Rows[i].Cells[j].Value);
                            hoja.Cells[i + 2, j + 1].NumberFormat = "0,0000"; // formato en 4 decimales
                            hoja.Cells[i + 2, j + 1].Value = valor;

                        }
                        else
                        {
                            hoja.Cells[i + 2, j + 1] = "";
                        }

                    }
                }
                //Guardar el archivo y respetar el formato
                libro.SaveAs(fichero.FileName, XlFileFormat.xlWorkbookNormal);
                //Cerrar
                libro.Close(true);
                excelApp.Quit();
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


        //List<double> siempre refiere a la conversion en vector, de la columna del datagrid que me interesa utilizar , sea uniforme , exponencial o normal
        public void GenerarHistograma(string seleccion, List<double> serie, Chart histograma, Panel pnlHistograma, DataGridView dtgfrecuencias)
        {
            int valorIntervalo = Convert.ToInt32(seleccion);


            double minimo = serie.Min();
            double maximo = serie.Max();
            double rango = maximo - minimo;
            double anchoDeSerie = rango / valorIntervalo;


            // Calcular Frecuencia de aparicion 
            //lo hago con un contador, la frecuencia
            // que tiene una longitud del tamaño de los intervalos , y en cada 
            // posicion aumenta en 1 cuando se da la aparicion de algun valor en el intervalo
            int[] frecuencias = new int[valorIntervalo];
            foreach (double pseudo in serie)
            {

                //calculo el indice del intervalo
                int indice = (int)Math.Floor((pseudo - minimo) / anchoDeSerie);
                //Compruebo que el indice este entre 0 y el valor maximo del intervalo para no irme 
                //fuera del intervalo
                if (indice >= 0 && indice < valorIntervalo)
                {
                    //en el arreglo de frecuencias, en la posicion del indice sumo 1
                    frecuencias[indice]++;
                }
                if (indice == valorIntervalo)
                {
                    frecuencias[indice-1]++;
                }


            }




            //En esta lista cargo todas las lineas correspondientes a las frecuencias
            List<double[]> listaFrecuencias = new List<double[]>();
            int contadorFrecuencia = 0;

            //serie con los valores de marcas de clase y las frecuencias correspondientes
            Series serieValores = new Series();

            double limiteSuperior;
            for (int i = 0; i < valorIntervalo; i++)
            {
                //Valor minimo del intervalo

                //El calculo esta planteado ya que tiene que ser iterativo, entonces se trabaja sobre los minimos de los intervalos adyacentes
                double limiteInferior = minimo + (i * anchoDeSerie);
                limiteInferior = Math.Round(limiteInferior, 4);

                //Si el i = valorIntervalo es porque estoy en el intervalo final
                //por lo que el limitefinal es el maximo de la serie.
                if (i == valorIntervalo)
                {
                     limiteSuperior = maximo;
                }
                else
                {
                    //Valor Maximo del intervalo
                    limiteSuperior = minimo + ((i + 1) * anchoDeSerie);
                    limiteSuperior = Math.Round(limiteSuperior, 4);
                }
                
                



                double marcaDeClase = (limiteInferior + limiteSuperior) / 2;
                marcaDeClase = Math.Round(marcaDeClase, 4);

                contadorFrecuencia += frecuencias[i];

                serieValores.Points.AddXY(marcaDeClase, frecuencias[i]);



                //Creo una lista con los valores que debo agregar a la tabla de frecuencias, es decir, intervalos desde hasta, F absoluta y Facumulada
                double[] fila_frecuencia = { limiteInferior, limiteSuperior, frecuencias[i], contadorFrecuencia };
                listaFrecuencias.Add(fila_frecuencia);

            }


            //Cargar tabla de frecuencias - En este caso arme una Lista con lo que seria cada fila de la tabla, debo iterar esa lista y colocar cada elemento de forma individual
            //No puedo pasar la lista entera a la tabla porque son formatos distintos.
            dtgfrecuencias.Rows.Clear();
            foreach (var valores in listaFrecuencias)
            {
                DataGridViewRow filadtg = new DataGridViewRow();
                foreach (var valor in valores)
                {
                    filadtg.Cells.Add(new DataGridViewTextBoxCell { Value = valor });
                }
                dtgfrecuencias.Rows.Add(filadtg);
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

            histograma.ChartAreas[0].AxisX.Title = "Valor";
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
        public List<double> ObtenerSerie(string columnName, DataGridView dtgseries)
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
