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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valorMuestra = new System.Windows.Forms.MaskedTextBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.valorLambda = new System.Windows.Forms.MaskedTextBox();
            this.btnGenerarSerie = new System.Windows.Forms.Button();
            this.dtgSerie = new System.Windows.Forms.DataGridView();
            this.Muestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSerie)).BeginInit();
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
            this.label3.Location = new System.Drawing.Point(22, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor Lambda:";
            // 
            // valorLambda
            // 
            this.valorLambda.Location = new System.Drawing.Point(141, 104);
            this.valorLambda.Mask = "999999";
            this.valorLambda.Name = "valorLambda";
            this.valorLambda.Size = new System.Drawing.Size(100, 20);
            this.valorLambda.TabIndex = 9;
            this.valorLambda.ValidatingType = typeof(int);
            // 
            // btnGenerarSerie
            // 
            this.btnGenerarSerie.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGenerarSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarSerie.Location = new System.Drawing.Point(282, 140);
            this.btnGenerarSerie.Name = "btnGenerarSerie";
            this.btnGenerarSerie.Size = new System.Drawing.Size(141, 36);
            this.btnGenerarSerie.TabIndex = 14;
            this.btnGenerarSerie.Text = "Generar Serie";
            this.btnGenerarSerie.UseVisualStyleBackColor = false;
            this.btnGenerarSerie.Click += new System.EventHandler(this.btnGenerarSerie_Click);
            // 
            // dtgSerie
            // 
            this.dtgSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSerie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Muestra,
            this.Valor});
            this.dtgSerie.Location = new System.Drawing.Point(22, 140);
            this.dtgSerie.Name = "dtgSerie";
            this.dtgSerie.Size = new System.Drawing.Size(240, 298);
            this.dtgSerie.TabIndex = 15;
            // 
            // Muestra
            // 
            this.Muestra.HeaderText = "Muestra";
            this.Muestra.Name = "Muestra";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // DistroExponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Muestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}