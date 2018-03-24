namespace holamundo
{
    partial class Form1
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
            this.btnhola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnhola
            // 
            this.btnhola.Location = new System.Drawing.Point(83, 72);
            this.btnhola.Name = "btnhola";
            this.btnhola.Size = new System.Drawing.Size(75, 23);
            this.btnhola.TabIndex = 0;
            this.btnhola.Text = "button1";
            this.btnhola.UseVisualStyleBackColor = true;
            this.btnhola.Click += new System.EventHandler(this.btnhola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnhola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnhola;
    }
}

