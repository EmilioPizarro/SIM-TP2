namespace TP_2
{
    partial class DistroUniforme
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.valorMuestra = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.limInferior = new System.Windows.Forms.MaskedTextBox();
            this.limSuperior = new System.Windows.Forms.MaskedTextBox();
            this.dtgSerie = new System.Windows.Forms.DataGridView();
            this.Muestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie_Pseudos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie_ab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerarSerie = new System.Windows.Forms.Button();
            this.btnHistograma = new System.Windows.Forms.Button();
            this.btnGenerarAB = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.cmbIntervalos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlHistograma = new System.Windows.Forms.Panel();
            this.histogramaAB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSerie)).BeginInit();
            this.pnlHistograma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaAB)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(362, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Distribucion Uniforme [a,b]";
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(1330, 12);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(141, 36);
            this.btnInicio.TabIndex = 6;
            this.btnInicio.Text = "Volver al Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor a - Limite Inferior:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor b - Limite Superior:";
            // 
            // limInferior
            // 
            this.limInferior.Location = new System.Drawing.Point(198, 105);
            this.limInferior.Mask = "0000000";
            this.limInferior.Name = "limInferior";
            this.limInferior.Size = new System.Drawing.Size(100, 20);
            this.limInferior.TabIndex = 9;
            this.limInferior.ValidatingType = typeof(int);
            this.limInferior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.limInferior_KeyPress);
            // 
            // limSuperior
            // 
            this.limSuperior.Location = new System.Drawing.Point(497, 105);
            this.limSuperior.Mask = "0000000";
            this.limSuperior.Name = "limSuperior";
            this.limSuperior.Size = new System.Drawing.Size(100, 20);
            this.limSuperior.TabIndex = 10;
            this.limSuperior.ValidatingType = typeof(int);
            this.limSuperior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.limSuperior_KeyPress);
            // 
            // dtgSerie
            // 
            this.dtgSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSerie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Muestra,
            this.Serie_Pseudos,
            this.Serie_ab});
            this.dtgSerie.Location = new System.Drawing.Point(18, 140);
            this.dtgSerie.Name = "dtgSerie";
            this.dtgSerie.RowHeadersWidth = 51;
            this.dtgSerie.Size = new System.Drawing.Size(373, 749);
            this.dtgSerie.TabIndex = 13;
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
            // Serie_ab
            // 
            this.Serie_ab.HeaderText = "Serie_ab";
            this.Serie_ab.MinimumWidth = 6;
            this.Serie_ab.Name = "Serie_ab";
            this.Serie_ab.Width = 125;
            // 
            // btnGenerarSerie
            // 
            this.btnGenerarSerie.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGenerarSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarSerie.Location = new System.Drawing.Point(397, 140);
            this.btnGenerarSerie.Name = "btnGenerarSerie";
            this.btnGenerarSerie.Size = new System.Drawing.Size(141, 64);
            this.btnGenerarSerie.TabIndex = 14;
            this.btnGenerarSerie.Text = "Generar Serie Uniforme (0,1]";
            this.btnGenerarSerie.UseVisualStyleBackColor = false;
            this.btnGenerarSerie.Click += new System.EventHandler(this.btnGenerarSerie_Click);
            // 
            // btnHistograma
            // 
            this.btnHistograma.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHistograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistograma.Location = new System.Drawing.Point(397, 280);
            this.btnHistograma.Name = "btnHistograma";
            this.btnHistograma.Size = new System.Drawing.Size(141, 63);
            this.btnHistograma.TabIndex = 16;
            this.btnHistograma.Text = "Generar Histograma";
            this.btnHistograma.UseVisualStyleBackColor = false;
            this.btnHistograma.Click += new System.EventHandler(this.btnHistograma_Click);
            // 
            // btnGenerarAB
            // 
            this.btnGenerarAB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGenerarAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarAB.Location = new System.Drawing.Point(397, 210);
            this.btnGenerarAB.Name = "btnGenerarAB";
            this.btnGenerarAB.Size = new System.Drawing.Size(141, 64);
            this.btnGenerarAB.TabIndex = 18;
            this.btnGenerarAB.Text = "Generar Serie Uniforme a,b";
            this.btnGenerarAB.UseVisualStyleBackColor = false;
            this.btnGenerarAB.Click += new System.EventHandler(this.btnGenerarAB_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(397, 349);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(141, 63);
            this.btnExcel.TabIndex = 19;
            this.btnExcel.Text = "Generar Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // cmbIntervalos
            // 
            this.cmbIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntervalos.FormattingEnabled = true;
            this.cmbIntervalos.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.cmbIntervalos.Location = new System.Drawing.Point(720, 103);
            this.cmbIntervalos.Name = "cmbIntervalos";
            this.cmbIntervalos.Size = new System.Drawing.Size(50, 21);
            this.cmbIntervalos.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(603, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cant. Intervalos";
            // 
            // pnlHistograma
            // 
            this.pnlHistograma.Controls.Add(this.histogramaAB);
            this.pnlHistograma.Location = new System.Drawing.Point(543, 140);
            this.pnlHistograma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHistograma.Name = "pnlHistograma";
            this.pnlHistograma.Size = new System.Drawing.Size(928, 749);
            this.pnlHistograma.TabIndex = 22;
            // 
            // histogramaAB
            // 
            chartArea2.Name = "ChartArea1";
            this.histogramaAB.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.histogramaAB.Legends.Add(legend2);
            this.histogramaAB.Location = new System.Drawing.Point(0, 2);
            this.histogramaAB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.histogramaAB.Name = "histogramaAB";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.histogramaAB.Series.Add(series2);
            this.histogramaAB.Size = new System.Drawing.Size(924, 745);
            this.histogramaAB.TabIndex = 0;
            this.histogramaAB.Text = "chart1";
            // 
            // DistroUniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1482, 900);
            this.Controls.Add(this.pnlHistograma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbIntervalos);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnGenerarAB);
            this.Controls.Add(this.btnHistograma);
            this.Controls.Add(this.btnGenerarSerie);
            this.Controls.Add(this.dtgSerie);
            this.Controls.Add(this.limSuperior);
            this.Controls.Add(this.limInferior);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.valorMuestra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DistroUniforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DistroUniforme";
            ((System.ComponentModel.ISupportInitialize)(this.dtgSerie)).EndInit();
            this.pnlHistograma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histogramaAB)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox limInferior;
        private System.Windows.Forms.MaskedTextBox limSuperior;
        private System.Windows.Forms.DataGridView dtgSerie;
        private System.Windows.Forms.Button btnGenerarSerie;
        private System.Windows.Forms.Button btnHistograma;
        private System.Windows.Forms.Button btnGenerarAB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Muestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie_Pseudos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie_ab;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ComboBox cmbIntervalos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlHistograma;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramaAB;
    }
}