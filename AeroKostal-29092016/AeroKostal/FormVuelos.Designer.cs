namespace AeroKostal
{
    partial class FormVuelos
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
            this.btn_venta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonOrdenFecha = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listViewVuelos = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRuta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAsientos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCosto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDuracion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.labelOrigen = new System.Windows.Forms.Label();
            this.labelDestino = new System.Windows.Forms.Label();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_venta
            // 
            this.btn_venta.Enabled = false;
            this.btn_venta.Location = new System.Drawing.Point(408, 14);
            this.btn_venta.Name = "btn_venta";
            this.btn_venta.Size = new System.Drawing.Size(75, 23);
            this.btn_venta.TabIndex = 1;
            this.btn_venta.Text = "Aceptar";
            this.btn_venta.UseVisualStyleBackColor = true;
            this.btn_venta.Click += new System.EventHandler(this.btn_venta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOrdenFecha
            // 
            this.buttonOrdenFecha.Location = new System.Drawing.Point(408, 43);
            this.buttonOrdenFecha.Name = "buttonOrdenFecha";
            this.buttonOrdenFecha.Size = new System.Drawing.Size(75, 23);
            this.buttonOrdenFecha.TabIndex = 3;
            this.buttonOrdenFecha.Text = "Por Fecha";
            this.buttonOrdenFecha.UseVisualStyleBackColor = true;
            this.buttonOrdenFecha.Click += new System.EventHandler(this.buttonOrdenFecha_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(489, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Por Asientos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listViewVuelos
            // 
            this.listViewVuelos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnRuta,
            this.columnAsientos,
            this.columnCosto,
            this.columnDuracion,
            this.columnFecha,
            this.columnHora});
            this.listViewVuelos.FullRowSelect = true;
            this.listViewVuelos.Location = new System.Drawing.Point(12, 14);
            this.listViewVuelos.Name = "listViewVuelos";
            this.listViewVuelos.Size = new System.Drawing.Size(390, 200);
            this.listViewVuelos.TabIndex = 5;
            this.listViewVuelos.UseCompatibleStateImageBehavior = false;
            this.listViewVuelos.View = System.Windows.Forms.View.Details;
            this.listViewVuelos.SelectedIndexChanged += new System.EventHandler(this.listViewVuelos_SelectedIndexChanged);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 0;
            // 
            // columnRuta
            // 
            this.columnRuta.Text = "Ruta";
            this.columnRuta.Width = 55;
            // 
            // columnAsientos
            // 
            this.columnAsientos.Text = "Asientos";
            this.columnAsientos.Width = 55;
            // 
            // columnCosto
            // 
            this.columnCosto.Text = "Costo";
            this.columnCosto.Width = 55;
            // 
            // columnDuracion
            // 
            this.columnDuracion.Text = "Duracion";
            this.columnDuracion.Width = 70;
            // 
            // columnFecha
            // 
            this.columnFecha.Text = "Fecha";
            this.columnFecha.Width = 70;
            // 
            // columnHora
            // 
            this.columnHora.Text = "Hora";
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "Ñ",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBoxOrigen.Location = new System.Drawing.Point(489, 72);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(73, 21);
            this.comboBoxOrigen.TabIndex = 6;
            this.comboBoxOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrigen_SelectedIndexChanged);
            this.comboBoxOrigen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxOrigen_MouseClick);
            // 
            // labelOrigen
            // 
            this.labelOrigen.AutoSize = true;
            this.labelOrigen.Location = new System.Drawing.Point(408, 75);
            this.labelOrigen.Name = "labelOrigen";
            this.labelOrigen.Size = new System.Drawing.Size(41, 13);
            this.labelOrigen.TabIndex = 7;
            this.labelOrigen.Text = "Origen:";
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(408, 102);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(46, 13);
            this.labelDestino.TabIndex = 9;
            this.labelDestino.Text = "Destino:";
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "Ñ",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBoxDestino.Location = new System.Drawing.Point(489, 99);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(73, 21);
            this.comboBoxDestino.TabIndex = 8;
            this.comboBoxDestino.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestino_SelectedIndexChanged);
            this.comboBoxDestino.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxDestino_MouseClick);
            // 
            // FormVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 226);
            this.Controls.Add(this.labelDestino);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.labelOrigen);
            this.Controls.Add(this.comboBoxOrigen);
            this.Controls.Add(this.listViewVuelos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonOrdenFecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_venta);
            this.Name = "FormVuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vuelos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_venta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOrdenFecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listViewVuelos;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnRuta;
        private System.Windows.Forms.ColumnHeader columnAsientos;
        private System.Windows.Forms.ColumnHeader columnCosto;
        private System.Windows.Forms.ColumnHeader columnDuracion;
        private System.Windows.Forms.ColumnHeader columnFecha;
        private System.Windows.Forms.ColumnHeader columnHora;
        private System.Windows.Forms.ComboBox comboBoxOrigen;
        private System.Windows.Forms.Label labelOrigen;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.ComboBox comboBoxDestino;
    }
}