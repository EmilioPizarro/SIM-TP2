namespace TP_2
{
    partial class DistroExponencial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valorMuestra = new System.Windows.Forms.MaskedTextBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.valorLambda = new System.Windows.Forms.MaskedTextBox();
            this.btnGenerarSerie = new System.Windows.Forms.Button();
            this.dtgSerie = new System.Windows.Forms.DataGridView();
            this.Muestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie_Pseudos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie_Exponencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerarExponencial = new System.Windows.Forms.Button();
            this.btnGenerarHistograma = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbIntervalos = new System.Windows.Forms.ComboBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.pnlHistograma = new System.Windows.Forms.Panel();
            this.histogramaExponencial = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtgFrecuencias = new System.Windows.Forms.DataGridView();
            this.Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia_Absoluta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia_Acumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSerie)).BeginInit();
            this.pnlHistograma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaExponencial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFrecuencias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distribucion Exponencial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el Tamaño de Muestra Deseado:";
            // 
            // valorMuestra
            // 
            this.valorMuestra.Location = new System.Drawing.Point(323, 68);
            this.valorMuestra.Mask = "0000000";
            this.valorMuestra.Name = "valorMuestra";
            this.valorMuestra.Size = new System.Drawing.Size(100, 20);
            this.valorMuestra.TabIndex = 2;
            this.valorMuestra.ValidatingType = typeof(int);
            this.valorMuestra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorMuestra_KeyPress);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(1329, 12);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(141, 36);
            this.btnInicio.TabIndex = 7;
            this.btnInicio.Text = "Volver al Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor Lambda:";
            // 
            // valorLambda
            // 
            this.valorLambda.Location = new System.Drawing.Point(133, 107);
            this.valorLambda.Mask = "999.9999";
            this.valorLambda.Name = "valorLambda";
            this.valorLambda.Size = new System.Drawing.Size(100, 20);
            this.valorLambda.TabIndex = 9;
            this.valorLambda.ValidatingType = typeof(int);
            this.valorLambda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorLambda_KeyPress);
            // 
            // btnGenerarSerie
            // 
            this.btnGenerarSerie.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGenerarSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarSerie.Location = new System.Drawing.Point(429, 140);
            this.btnGenerarSerie.Name = "btnGenerarSerie";
            this.btnGenerarSerie.Size = new System.Drawing.Size(141, 64);
            this.btnGenerarSerie.TabIndex = 14;
            this.btnGenerarSerie.Text = "Generar Serie Uniforme(0,1]";
            this.btnGenerarSerie.UseVisualStyleBackColor = false;
            this.btnGenerarSerie.Click += new System.EventHandler(this.btnGenerarSerie_Click);
            // 
            // dtgSerie
            // 
            this.dtgSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSerie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Muestra,
            this.Serie_Pseudos,
            this.Serie_Exponencial});
            this.dtgSerie.Location = new System.Drawing.Point(22, 140);
            this.dtgSerie.Name = "dtgSerie";
            this.dtgSerie.RowHeadersWidth = 51;
            this.dtgSerie.Size = new System.Drawing.Size(401, 330);
            this.dtgSerie.TabIndex = 15;
            // 
            // Muestra
            // 
            this.Muestra.HeaderText = "Muestra";
            this.Muestra.MinimumWidth = 6;
            this.Muestra.Name = "Muestra";
            this.Muestra.Width = 125;
            // 
            // Serie_Pseudos
            // 
            this.Serie_Pseudos.HeaderText = "Serie_Pseudos";
            this.Serie_Pseudos.MinimumWidth = 6;
            this.Serie_Pseudos.Name = "Serie_Pseudos";
            this.Serie_Pseudos.Width = 125;
            // 
            // Serie_Exponencial
            // 
            this.Serie_Exponencial.HeaderText = "Serie_Exponencial";
            this.Serie_Exponencial.MinimumWidth = 6;
            this.Serie_Exponencial.Name = "Serie_Exponencial";
            this.Serie_Exponencial.Width = 125;
            // 
            // btnGenerarExponencial
            // 
            this.btnGenerarExponencial.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGenerarExponencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarExponencial.Location = new System.Drawing.Point(429, 222);
            this.btnGenerarExponencial.Name = "btnGenerarExponencial";
            this.btnGenerarExponencial.Size = new System.Drawing.Size(141, 64);
            this.btnGenerarExponencial.TabIndex = 19;
            this.btnGenerarExponencial.Text = "Generar Serie Exponencial";
            this.btnGenerarExponencial.UseVisualStyleBackColor = false;
            this.btnGenerarExponencial.Click += new System.EventHandler(this.btnGenerarExponencial_Click);
            // 
            // btnGenerarHistograma
            // 
            this.btnGenerarHistograma.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGenerarHistograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarHistograma.Location = new System.Drawing.Point(429, 304);
            this.btnGenerarHistograma.Name = "btnGenerarHistograma";
            this.btnGenerarHistograma.Size = new System.Drawing.Size(141, 64);
            this.btnGenerarHistograma.TabIndex = 20;
            this.btnGenerarHistograma.Text = "Generar Histograma";
            this.btnGenerarHistograma.UseVisualStyleBackColor = false;
            this.btnGenerarHistograma.Click += new System.EventHandler(this.btnGenerarHistograma_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cant. Intervalos";
            // 
            // cmbIntervalos
            // 
            this.cmbIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntervalos.FormattingEnabled = true;
            this.cmbIntervalos.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.cmbIntervalos.Location = new System.Drawing.Point(356, 105);
            this.cmbIntervalos.Name = "cmbIntervalos";
            this.cmbIntervalos.Size = new System.Drawing.Size(50, 21);
            this.cmbIntervalos.TabIndex = 22;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(429, 407);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(141, 63);
            this.btnExcel.TabIndex = 24;
            this.btnExcel.Text = "Generar Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // pnlHistograma
            // 
            this.pnlHistograma.Controls.Add(this.histogramaExponencial);
            this.pnlHistograma.Location = new System.Drawing.Point(575, 140);
            this.pnlHistograma.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHistograma.Name = "pnlHistograma";
            this.pnlHistograma.Size = new System.Drawing.Size(895, 749);
            this.pnlHistograma.TabIndex = 25;
            // 
            // histogramaExponencial
            // 
            chartArea1.Name = "ChartArea1";
            this.histogramaExponencial.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.histogramaExponencial.Legends.Add(legend1);
            this.histogramaExponencial.Location = new System.Drawing.Point(0, 2);
            this.histogramaExponencial.Margin = new System.Windows.Forms.Padding(2);
            this.histogramaExponencial.Name = "histogramaExponencial";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.histogramaExponencial.Series.Add(series1);
            this.histogramaExponencial.Size = new System.Drawing.Size(893, 747);
            this.histogramaExponencial.TabIndex = 0;
            this.histogramaExponencial.Text = "chart1";
            // 
            // dtgFrecuencias
            // 
            this.dtgFrecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFrecuencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Desde,
            this.Hasta,
            this.Frecuencia_Absoluta,
            this.Frecuencia_Acumulada});
            this.dtgFrecuencias.Location = new System.Drawing.Point(26, 509);
            this.dtgFrecuencias.Name = "dtgFrecuencias";
            this.dtgFrecuencias.Size = new System.Drawing.Size(481, 379);
            this.dtgFrecuencias.TabIndex = 27;
            // 
            // Desde
            // 
            this.Desde.HeaderText = "Desde";
            this.Desde.Name = "Desde";
            // 
            // Hasta
            // 
            this.Hasta.HeaderText = "Hasta";
            this.Hasta.Name = "Hasta";
            // 
            // Frecuencia_Absoluta
            // 
            this.Frecuencia_Absoluta.HeaderText = "Frecuencia_Absoluta";
            this.Frecuencia_Absoluta.Name = "Frecuencia_Absoluta";
            this.Frecuencia_Absoluta.Width = 110;
            // 
            // Frecuencia_Acumulada
            // 
            this.Frecuencia_Acumulada.HeaderText = "Frecuencia_Acumulada";
            this.Frecuencia_Acumulada.Name = "Frecuencia_Acumulada";
            this.Frecuencia_Acumulada.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Distribucion de Frecuencias Por Intervalos:";
            // 
            // DistroExponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1482, 900);
            this.Controls.Add(this.dtgFrecuencias);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlHistograma);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbIntervalos);
            this.Controls.Add(this.btnGenerarHistograma);
            this.Controls.Add(this.btnGenerarExponencial);
            this.Controls.Add(this.dtgSerie);
            this.Controls.Add(this.btnGenerarSerie);
            this.Controls.Add(this.valorLambda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.valorMuestra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DistroExponencial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DistroExponencial";
            this.Load += new System.EventHandler(this.DistroExponencial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSerie)).EndInit();
            this.pnlHistograma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histogramaExponencial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFrecuencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox valorMuestra;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox valorLambda;
        private System.Windows.Forms.Button btnGenerarSerie;
        private System.Windows.Forms.DataGridView dtgSerie;
        private System.Windows.Forms.Button btnGenerarExponencial;
        private System.Windows.Forms.Button btnGenerarHistograma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Muestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie_Pseudos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie_Exponencial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbIntervalos;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Panel pnlHistograma;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramaExponencial;
        private System.Windows.Forms.DataGridView dtgFrecuencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia_Absoluta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia_Acumulada;
        private System.Windows.Forms.Label label6;
    }
}