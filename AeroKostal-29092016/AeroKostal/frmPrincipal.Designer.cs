﻿namespace AeroKostal
{
    partial class frmPrincipal
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
            this.btnVuelos = new System.Windows.Forms.Button();
            this.buttonPasajeros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVuelos
            // 
            this.btnVuelos.Location = new System.Drawing.Point(12, 12);
            this.btnVuelos.Name = "btnVuelos";
            this.btnVuelos.Size = new System.Drawing.Size(75, 23);
            this.btnVuelos.TabIndex = 0;
            this.btnVuelos.Text = "Vuelos";
            this.btnVuelos.UseVisualStyleBackColor = true;
            this.btnVuelos.Click += new System.EventHandler(this.btnVuelos_Click);
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 44);
            this.Controls.Add(this.buttonPasajeros);
            this.Controls.Add(this.btnVuelos);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVuelos;
        private System.Windows.Forms.Button buttonPasajeros;
    }
}

