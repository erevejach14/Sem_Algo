namespace AeroKostal
{
    partial class FormPrincipal
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
            this.btnCompra = new System.Windows.Forms.Button();
            this.buttonPasajeros = new System.Windows.Forms.Button();
            this.buttonVuelos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(12, 12);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(75, 23);
            this.btnCompra.TabIndex = 0;
            this.btnCompra.Text = "Comprar";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnVuelos_Click);
            // 
            // buttonPasajeros
            // 
            this.buttonPasajeros.Location = new System.Drawing.Point(127, 12);
            this.buttonPasajeros.Name = "buttonPasajeros";
            this.buttonPasajeros.Size = new System.Drawing.Size(75, 23);
            this.buttonPasajeros.TabIndex = 1;
            this.buttonPasajeros.Text = "Pasajeros";
            this.buttonPasajeros.UseVisualStyleBackColor = true;
            this.buttonPasajeros.Click += new System.EventHandler(this.buttonPasajeros_Click);
            // 
            // buttonVuelos
            // 
            this.buttonVuelos.Location = new System.Drawing.Point(12, 41);
            this.buttonVuelos.Name = "buttonVuelos";
            this.buttonVuelos.Size = new System.Drawing.Size(75, 23);
            this.buttonVuelos.TabIndex = 2;
            this.buttonVuelos.Text = "Vuelos";
            this.buttonVuelos.UseVisualStyleBackColor = true;
            this.buttonVuelos.Click += new System.EventHandler(this.buttonVuelos_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 76);
            this.Controls.Add(this.buttonVuelos);
            this.Controls.Add(this.buttonPasajeros);
            this.Controls.Add(this.btnCompra);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button buttonPasajeros;
        private System.Windows.Forms.Button buttonVuelos;
    }
}

