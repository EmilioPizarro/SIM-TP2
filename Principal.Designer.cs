namespace TP_2
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUniforme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExponencial = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUniforme
            // 
            this.btnUniforme.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUniforme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUniforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUniforme.Location = new System.Drawing.Point(53, 164);
            this.btnUniforme.Name = "btnUniforme";
            this.btnUniforme.Size = new System.Drawing.Size(147, 54);
            this.btnUniforme.TabIndex = 0;
            this.btnUniforme.Text = "Uniforme[a,b]";
            this.btnUniforme.UseVisualStyleBackColor = false;
            this.btnUniforme.Click += new System.EventHandler(this.btnUniforme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(138, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione la Distribucion Deseada";
            // 
            // btnExponencial
            // 
            this.btnExponencial.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExponencial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExponencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExponencial.Location = new System.Drawing.Point(296, 164);
            this.btnExponencial.Name = "btnExponencial";
            this.btnExponencial.Size = new System.Drawing.Size(147, 54);
            this.btnExponencial.TabIndex = 2;
            this.btnExponencial.Text = "Exponencial";
            this.btnExponencial.UseVisualStyleBackColor = false;
            this.btnExponencial.Click += new System.EventHandler(this.btnExponencial_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.Location = new System.Drawing.Point(539, 164);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(147, 54);
            this.btnNormal.TabIndex = 3;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(738, 319);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnExponencial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUniforme);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUniforme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExponencial;
        private System.Windows.Forms.Button btnNormal;
    }
}

