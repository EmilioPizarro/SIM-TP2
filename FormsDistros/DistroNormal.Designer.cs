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
            ((System.ComponentModel.ISupportInitialize)(this.dtgSerie)).BeginInit();
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
            this.btnInicio.Location = new System.Drawing.Point(647, 12);
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
            this.valorMedia.Mask = "0.00";
            this.valorMedia.Name = "valorMedia";
            this.valorMedia.Size = new System.Drawing.Size(70, 20);
            this.valorMedia.TabIndex = 10;
            this.valorMedia.ValidatingType = typeof(int);
            this.valorMedia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorMedia_KeyPress);
            // 
            // valorDesviacion
            // 
            this.valorDesviacion.Location = new System.Drawing.Point(323, 104);
            this.valorDesviacion.Mask = "0.00";
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
            this.btnGenerarSerie.Location = new System.Drawing.Point(365, 140);
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
            this.btnGenerarNormal.Location = new System.Drawing.Point(365, 246);
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
            this.btnHistograma.Location = new System.Drawing.Point(365, 375);
            this.btnHistograma.Name = "btnHistograma";
            this.btnHistograma.Size = new System.Drawing.Size(141, 63);
            this.btnHistograma.TabIndex = 20;
            this.btnHistograma.Text = "Generar Histograma";
            this.btnHistograma.UseVisualStyleBackColor = false;
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
            this.dtgSerie.Size = new System.Drawing.Size(327, 298);
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
            // DistroNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}