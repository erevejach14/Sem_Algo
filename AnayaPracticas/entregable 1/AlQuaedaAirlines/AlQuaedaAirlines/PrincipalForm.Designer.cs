namespace AlQuaedaAirlines
{
    partial class PrincipalForm
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
            this.Ruta = new System.Windows.Forms.Button();
            this.Busqueda = new System.Windows.Forms.Button();
            this.VuelosButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ruta
            // 
            this.Ruta.Location = new System.Drawing.Point(122, 199);
            this.Ruta.Name = "Ruta";
            this.Ruta.Size = new System.Drawing.Size(128, 38);
            this.Ruta.TabIndex = 5;
            this.Ruta.Text = "Sugerencia de Ruta";
            this.Ruta.UseVisualStyleBackColor = true;
            // 
            // Busqueda
            // 
            this.Busqueda.Location = new System.Drawing.Point(147, 126);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(87, 34);
            this.Busqueda.TabIndex = 4;
            this.Busqueda.Text = "Busqueda";
            this.Busqueda.UseVisualStyleBackColor = true;
            // 
            // VuelosButton
            // 
            this.VuelosButton.Location = new System.Drawing.Point(147, 58);
            this.VuelosButton.Name = "VuelosButton";
            this.VuelosButton.Size = new System.Drawing.Size(87, 38);
            this.VuelosButton.TabIndex = 3;
            this.VuelosButton.Text = "Vuelos";
            this.VuelosButton.UseVisualStyleBackColor = true;
            this.VuelosButton.Click += new System.EventHandler(this.VuelosButton_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 300);
            this.Controls.Add(this.Ruta);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.VuelosButton);
            this.Name = "PrincipalForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ruta;
        private System.Windows.Forms.Button Busqueda;
        private System.Windows.Forms.Button VuelosButton;
    }
}

