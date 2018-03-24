namespace AlQuaedaAirlines
{
    partial class VuelosForm
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
            this.reservarbutton = new System.Windows.Forms.Button();
            this.listViewVuelos = new System.Windows.Forms.ListView();
            this.columnRuta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAsientos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCosto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDuracion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reservarbutton
            // 
            this.reservarbutton.Location = new System.Drawing.Point(460, 74);
            this.reservarbutton.Name = "reservarbutton";
            this.reservarbutton.Size = new System.Drawing.Size(75, 23);
            this.reservarbutton.TabIndex = 4;
            this.reservarbutton.Text = "reservar";
            this.reservarbutton.UseVisualStyleBackColor = true;
            this.reservarbutton.Click += new System.EventHandler(this.reservarbutton_Click);
            // 
            // listViewVuelos
            // 
            this.listViewVuelos.AllowColumnReorder = true;
            this.listViewVuelos.AllowDrop = true;
            this.listViewVuelos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnRuta,
            this.columnAsientos,
            this.columnCosto,
            this.columnDuracion,
            this.columnFecha,
            this.columnHora,
            this.columnID});
            this.listViewVuelos.FullRowSelect = true;
            this.listViewVuelos.HideSelection = false;
            this.listViewVuelos.Location = new System.Drawing.Point(32, 43);
            this.listViewVuelos.Name = "listViewVuelos";
            this.listViewVuelos.Size = new System.Drawing.Size(413, 128);
            this.listViewVuelos.TabIndex = 5;
            this.listViewVuelos.UseCompatibleStateImageBehavior = false;
            this.listViewVuelos.View = System.Windows.Forms.View.Details;
            this.listViewVuelos.SelectedIndexChanged += new System.EventHandler(this.listViewVuelos_SelectedIndexChanged);
            this.listViewVuelos.TabIndexChanged += new System.EventHandler(this.listViewVuelos_SelectedIndexChanged);
            // 
            // columnRuta
            // 
            this.columnRuta.Text = "Ruta";
            this.columnRuta.Width = 49;
            // 
            // columnAsientos
            // 
            this.columnAsientos.Text = "Asientos";
            // 
            // columnCosto
            // 
            this.columnCosto.Text = "Costo";
            // 
            // columnDuracion
            // 
            this.columnDuracion.Text = "Duracion";
            // 
            // columnFecha
            // 
            this.columnFecha.Text = "Fecha";
            this.columnFecha.Width = 87;
            // 
            // columnHora
            // 
            this.columnHora.Text = "Hora";
            this.columnHora.Width = 97;
            // 
            // columnID
            // 
            this.columnID.Text = "";
            this.columnID.Width = 0;
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.Location = new System.Drawing.Point(460, 124);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelarbutton.TabIndex = 6;
            this.cancelarbutton.Text = "Regresar";
            this.cancelarbutton.UseVisualStyleBackColor = true;
            this.cancelarbutton.Click += new System.EventHandler(this.cancelarbutton_Click);
            // 
            // VuelosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 218);
            this.Controls.Add(this.cancelarbutton);
            this.Controls.Add(this.listViewVuelos);
            this.Controls.Add(this.reservarbutton);
            this.Name = "VuelosForm";
            this.Text = "VuelosForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reservarbutton;
        private System.Windows.Forms.ListView listViewVuelos;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnRuta;
        private System.Windows.Forms.ColumnHeader columnAsientos;
        private System.Windows.Forms.ColumnHeader columnCosto;
        private System.Windows.Forms.ColumnHeader columnDuracion;
        private System.Windows.Forms.ColumnHeader columnFecha;
        private System.Windows.Forms.ColumnHeader columnHora;
        private System.Windows.Forms.Button cancelarbutton;
    }
}