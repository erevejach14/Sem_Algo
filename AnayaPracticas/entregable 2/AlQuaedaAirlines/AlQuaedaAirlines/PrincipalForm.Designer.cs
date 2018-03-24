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
            this.BusquedaPasajerosbutton = new System.Windows.Forms.Button();
            this.VuelosButton = new System.Windows.Forms.Button();
            this.VusquedaVuelosbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ruta
            // 
            this.Ruta.Location = new System.Drawing.Point(125, 227);
            this.Ruta.Name = "Ruta";
            this.Ruta.Size = new System.Drawing.Size(128, 38);
            this.Ruta.TabIndex = 5;
            this.Ruta.Text = "Sugerencia de Ruta";
            this.Ruta.UseVisualStyleBackColor = true;
            // 
            // BusquedaPasajerosbutton
            // 
            this.BusquedaPasajerosbutton.Location = new System.Drawing.Point(147, 174);
            this.BusquedaPasajerosbutton.Name = "BusquedaPasajerosbutton";
            this.BusquedaPasajerosbutton.Size = new System.Drawing.Size(87, 34);
            this.BusquedaPasajerosbutton.TabIndex = 4;
            this.BusquedaPasajerosbutton.Text = "Busqueda Pasajeros";
            this.BusquedaPasajerosbutton.UseVisualStyleBackColor = true;
            this.BusquedaPasajerosbutton.Click += new System.EventHandler(this.Busqueda_Click);
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
            // VusquedaVuelosbutton
            // 
            this.VusquedaVuelosbutton.Location = new System.Drawing.Point(147, 120);
            this.VusquedaVuelosbutton.Name = "VusquedaVuelosbutton";
            this.VusquedaVuelosbutton.Size = new System.Drawing.Size(87, 34);
            this.VusquedaVuelosbutton.TabIndex = 6;
            this.VusquedaVuelosbutton.Text = "Busqueda Vuelos";
            this.VusquedaVuelosbutton.UseVisualStyleBackColor = true;
            this.VusquedaVuelosbutton.Click += new System.EventHandler(this.VusquedaVuelosbutton_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 300);
            this.Controls.Add(this.VusquedaVuelosbutton);
            this.Controls.Add(this.Ruta);
            this.Controls.Add(this.BusquedaPasajerosbutton);
            this.Controls.Add(this.VuelosButton);
            this.Name = "PrincipalForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ruta;
        private System.Windows.Forms.Button BusquedaPasajerosbutton;
        private System.Windows.Forms.Button VuelosButton;
        private System.Windows.Forms.Button VusquedaVuelosbutton;
    }
}

