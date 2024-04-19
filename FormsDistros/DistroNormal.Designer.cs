namespace TP_2
{
    partial class DistroNormal
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
            this.valorMuestra = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.valorMedia = new System.Windows.Forms.MaskedTextBox();
            this.valorDesviacion = new System.Windows.Forms.MaskedTextBox();
            this.btnGenerarSerie = new System.Windows.Forms.Button();
            this.btnGenerarNormal = new System.Windows.Forms.Button();
            this.btnHistograma = new System.Windows.Forms.Button();
            this.dtgSerie = new System.Windows.Forms.DataGridView();
            this.Muestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie_Pseudos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie_Normal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcel = new System.Windows.Forms.Button();
            this.pnlHistograma = new System.Windows.Forms.Panel();
            this.histogramaNormal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbIntervalos = new System.Windows.Forms.ComboBox();
            this.dtgFrecuencias = new System.Windows.Forms.DataGridView();
            this.Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia_Absoluta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia_Acumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSerie)).BeginInit();
            this.pnlHistograma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFrecuencias)).BeginInit();
            this.SuspendLayout();
            // 
            // valorMuestra
            // 
            this.valorMuestra.Location = new System.Drawing.Point(323, 68);
            this.valorMuestra.Mask = "0000000";
            this.valorMuestra.Name = "valorMuestra";
            this.valorMuestra.Size = new System.Drawing.Size(100, 20);
            this.valorMuestra.TabIndex = 5;
            this.valorMuestra.ValidatingType = typeof(int);
            this.valorMuestra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorMuestra_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese el Tamaño de Muestra Deseado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Distribucion Normal";
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
            this.label3.Location = new System.Drawing.Point(18, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Media:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Desviacion Estandar:";
            // 
            // valorMedia
            // 
            this.valorMedia.Location = new System.Drawing.Point(81, 104);
            this.valorMedia.Mask = "999.9999";
            this.valorMedia.Name = "valorMedia";
            this.valorMedia.Size = new System.Drawing.Size(70, 20);
            this.valorMedia.TabIndex = 10;
            this.valorMedia.ValidatingType = typeof(int);
            this.valorMedia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorMedia_KeyPress);
            // 
            // valorDesviacion
            // 
            this.valorDesviacion.Location = new System.Drawing.Point(323, 104);
            this.valorDesviacion.Mask = "999.9999";
            this.valorDesviacion.Name = "valorDesviacion";
            this.valorDesviacion.Size = new System.Drawing.Size(70, 20);
            this.valorDesviacion.TabIndex = 11;
            this.valorDesviacion.ValidatingType = typeof(int);
            this.valorDesviacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorDesviacion_KeyPress);
            // 
            // btnGenerarSerie
            // 
            this.btnGenerarSerie.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGenerarSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarSerie.Location = new System.Drawing.Point(406, 140);
            this.btnGenerarSerie.Name = "btnGenerarSerie";
            this.btnGenerarSerie.Size = new System.Drawing.Size(141, 64);
            this.btnGenerarSerie.TabIndex = 15;
            this.btnGenerarSerie.Text = "Generar Serie Uniforme (0,1]";
            this.btnGenerarSerie.UseVisualStyleBackColor = false;
            this.btnGenerarSerie.Click += new System.EventHandler(this.btnGenerarSerie_Click_1);
            // 
            // btnGenerarNormal
            // 
            this.btnGenerarNormal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGenerarNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarNormal.Location = new System.Drawing.Point(406, 232);
            this.btnGenerarNormal.Name = "btnGenerarNormal";
            this.btnGenerarNormal.Size = new System.Drawing.Size(141, 64);
            this.btnGenerarNormal.TabIndex = 19;
            this.btnGenerarNormal.Text = "Generar Serie Normal";
            this.btnGenerarNormal.UseVisualStyleBackColor = false;
            this.btnGenerarNormal.Click += new System.EventHandler(this.btnGenerarNormal_Click);
            // 
            // btnHistograma
            // 
            this.btnHistograma.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHistograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistograma.Location = new System.Drawing.Point(406, 317);
            this.btnHistograma.Name = "btnHistograma";
            this.btnHistograma.Size = new System.Drawing.Size(141, 63);
            this.btnHistograma.TabIndex = 20;
            this.btnHistograma.Text = "Generar Histograma";
            this.btnHistograma.UseVisualStyleBackColor = false;
            this.btnHistograma.Click += new System.EventHandler(this.btnHistograma_Click);
            // 
            // dtgSerie
            // 
            this.dtgSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSerie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Muestra,
            this.Serie_Pseudos,
            this.Serie_Normal});
            this.dtgSerie.Location = new System.Drawing.Point(18, 140);
            this.dtgSerie.Name = "dtgSerie";
            this.dtgSerie.RowHeadersWidth = 51;
            this.dtgSerie.Size = new System.Drawing.Size(382, 331);
            this.dtgSerie.TabIndex = 21;
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
            // Serie_Normal
            // 
            this.Serie_Normal.HeaderText = "Serie_Normal";
            this.Serie_Normal.MinimumWidth = 6;
            this.Serie_Normal.Name = "Serie_Normal";
            this.Serie_Normal.Width = 125;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(406, 408);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(141, 63);
            this.btnExcel.TabIndex = 22;
            this.btnExcel.Text = "Generar Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // pnlHistograma
            // 
            this.pnlHistograma.Controls.Add(this.histogramaNormal);
            this.pnlHistograma.Location = new System.Drawing.Point(552, 140);
            this.pnlHistograma.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHistograma.Name = "pnlHistograma";
            this.pnlHistograma.Size = new System.Drawing.Size(928, 749);
            this.pnlHistograma.TabIndex = 23;
            // 
            // histogramaNormal
            // 
            chartArea1.Name = "ChartArea1";
            this.histogramaNormal.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.histogramaNormal.Legends.Add(legend1);
            this.histogramaNormal.Location = new System.Drawing.Point(2, 2);
            this.histogramaNormal.Margin = new System.Windows.Forms.Padding(2);
            this.histogramaNormal.Name = "histogramaNormal";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.histogramaNormal.Series.Add(series1);
            this.histogramaNormal.Size = new System.Drawing.Size(924, 745);
            this.histogramaNormal.TabIndex = 0;
            this.histogramaNormal.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 25;
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
            this.cmbIntervalos.Location = new System.Drawing.Point(519, 105);
            this.cmbIntervalos.Name = "cmbIntervalos";
            this.cmbIntervalos.Size = new System.Drawing.Size(50, 21);
            this.cmbIntervalos.TabIndex = 24;
            // 
            // dtgFrecuencias
            // 
            this.dtgFrecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFrecuencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Desde,
            this.Hasta,
            this.Frecuencia_Absoluta,
            this.Frecuencia_Acumulada});
            this.dtgFrecuencias.Location = new System.Drawing.Point(18, 509);
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
            this.label6.Location = new System.Drawing.Point(18, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Distribucion de Frecuencias Por Intervalos:";
            // 
            // DistroNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1482, 900);
            this.Controls.Add(this.dtgFrecuencias);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbIntervalos);
            this.Controls.Add(this.pnlHistograma);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dtgSerie);
            this.Controls.Add(this.btnHistograma);
            this.Controls.Add(this.btnGenerarNormal);
            this.Controls.Add(this.btnGenerarSerie);
            this.Controls.Add(this.valorDesviacion);
            this.Controls.Add(this.valorMedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.valorMuestra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DistroNormal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DistroNormal";
            ((System.ComponentModel.ISupportInitialize)(this.dtgSerie)).EndInit();
            this.pnlHistograma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histogramaNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFrecuencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox valorMuestra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox valorMedia;
        private System.Windows.Forms.MaskedTextBox valorDesviacion;
        private System.Windows.Forms.Button btnGenerarSerie;
        private System.Windows.Forms.Button btnGenerarNormal;
        private System.Windows.Forms.Button btnHistograma;
        private System.Windows.Forms.DataGridView dtgSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Muestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie_Pseudos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie_Normal;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Panel pnlHistograma;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramaNormal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbIntervalos;
        private System.Windows.Forms.DataGridView dtgFrecuencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia_Absoluta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia_Acumulada;
        private System.Windows.Forms.Label label6;
    }
}