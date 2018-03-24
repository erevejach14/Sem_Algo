namespace AlQuaedaAirlines
{
    partial class ControlVeulosForm
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
            this.listViewPaVu = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.agregarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.labeldu = new System.Windows.Forms.Label();
            this.labelcost = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_agrega = new System.Windows.Forms.Button();
            this.button_cancela = new System.Windows.Forms.Button();
            this.labelori = new System.Windows.Forms.Label();
            this.labeldes = new System.Windows.Forms.Label();
            this.labelagre = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labeltype = new System.Windows.Forms.Label();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewPaVu
            // 
            this.listViewPaVu.FullRowSelect = true;
            this.listViewPaVu.Location = new System.Drawing.Point(44, 37);
            this.listViewPaVu.Name = "listViewPaVu";
            this.listViewPaVu.Size = new System.Drawing.Size(323, 162);
            this.listViewPaVu.TabIndex = 0;
            this.listViewPaVu.UseCompatibleStateImageBehavior = false;
            this.listViewPaVu.View = System.Windows.Forms.View.Details;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(415, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // agregarbutton
            // 
            this.agregarbutton.Location = new System.Drawing.Point(426, 91);
            this.agregarbutton.Name = "agregarbutton";
            this.agregarbutton.Size = new System.Drawing.Size(75, 23);
            this.agregarbutton.TabIndex = 2;
            this.agregarbutton.Text = "Agregar";
            this.agregarbutton.UseVisualStyleBackColor = true;
            this.agregarbutton.Click += new System.EventHandler(this.agregarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(426, 138);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 3;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.Location = new System.Drawing.Point(426, 175);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelarbutton.TabIndex = 4;
            this.cancelarbutton.Text = "Regresar";
            this.cancelarbutton.UseVisualStyleBackColor = true;
            this.cancelarbutton.Click += new System.EventHandler(this.cancelarbutton_Click);
            // 
            // labeldu
            // 
            this.labeldu.AutoSize = true;
            this.labeldu.Location = new System.Drawing.Point(162, 82);
            this.labeldu.Name = "labeldu";
            this.labeldu.Size = new System.Drawing.Size(53, 13);
            this.labeldu.TabIndex = 25;
            this.labeldu.Text = "Duracion ";
            // 
            // labelcost
            // 
            this.labelcost.AutoSize = true;
            this.labelcost.Location = new System.Drawing.Point(177, 56);
            this.labelcost.Name = "labelcost";
            this.labelcost.Size = new System.Drawing.Size(34, 13);
            this.labelcost.TabIndex = 24;
            this.labelcost.Text = "Costo";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(221, 79);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(71, 20);
            this.textBox4.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(221, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(71, 20);
            this.textBox3.TabIndex = 22;
            // 
            // button_agrega
            // 
            this.button_agrega.Location = new System.Drawing.Point(217, 212);
            this.button_agrega.Name = "button_agrega";
            this.button_agrega.Size = new System.Drawing.Size(75, 23);
            this.button_agrega.TabIndex = 21;
            this.button_agrega.Text = "Agregar";
            this.button_agrega.UseVisualStyleBackColor = true;
            this.button_agrega.Click += new System.EventHandler(this.button_agrega_Click);
            // 
            // button_cancela
            // 
            this.button_cancela.Location = new System.Drawing.Point(99, 212);
            this.button_cancela.Name = "button_cancela";
            this.button_cancela.Size = new System.Drawing.Size(75, 23);
            this.button_cancela.TabIndex = 20;
            this.button_cancela.Text = "Cancelar";
            this.button_cancela.UseVisualStyleBackColor = true;
            this.button_cancela.Click += new System.EventHandler(this.button_cancela_Click);
            // 
            // labelori
            // 
            this.labelori.AutoSize = true;
            this.labelori.Location = new System.Drawing.Point(173, 10);
            this.labelori.Name = "labelori";
            this.labelori.Size = new System.Drawing.Size(38, 13);
            this.labelori.TabIndex = 19;
            this.labelori.Text = "Origen";
            // 
            // labeldes
            // 
            this.labeldes.AutoSize = true;
            this.labeldes.Location = new System.Drawing.Point(168, 29);
            this.labeldes.Name = "labeldes";
            this.labeldes.Size = new System.Drawing.Size(43, 13);
            this.labeldes.TabIndex = 18;
            this.labeldes.Text = "Destino";
            // 
            // labelagre
            // 
            this.labelagre.AutoSize = true;
            this.labelagre.Location = new System.Drawing.Point(63, 9);
            this.labelagre.Name = "labelagre";
            this.labelagre.Size = new System.Drawing.Size(86, 13);
            this.labelagre.TabIndex = 17;
            this.labelagre.Text = "Agrega un Vuelo";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(267, 138);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(79, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(217, 29);
            this.textBox2.MaxLength = 1;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox5.Location = new System.Drawing.Point(217, 3);
            this.textBox5.MaxLength = 1;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            // 
            // labeltype
            // 
            this.labeltype.AutoSize = true;
            this.labeltype.Location = new System.Drawing.Point(173, 101);
            this.labeltype.Name = "labeltype";
            this.labeltype.Size = new System.Drawing.Size(24, 13);
            this.labeltype.TabIndex = 26;
            this.labeltype.Text = "tipo";
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Location = new System.Drawing.Point(221, 106);
            this.textBoxTipo.MaxLength = 1;
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(71, 20);
            this.textBoxTipo.TabIndex = 27;
            // 
            // ControlVeulosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 240);
            this.Controls.Add(this.textBoxTipo);
            this.Controls.Add(this.labeltype);
            this.Controls.Add(this.labeldu);
            this.Controls.Add(this.labelcost);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button_agrega);
            this.Controls.Add(this.button_cancela);
            this.Controls.Add(this.labelori);
            this.Controls.Add(this.labeldes);
            this.Controls.Add(this.labelagre);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.cancelarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.agregarbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listViewPaVu);
            this.Name = "ControlVeulosForm";
            this.Text = "ControlVeulosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPaVu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button agregarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button cancelarbutton;
        private System.Windows.Forms.Label labeldu;
        private System.Windows.Forms.Label labelcost;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_agrega;
        private System.Windows.Forms.Button button_cancela;
        private System.Windows.Forms.Label labelori;
        private System.Windows.Forms.Label labeldes;
        private System.Windows.Forms.Label labelagre;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labeltype;
        private System.Windows.Forms.TextBox textBoxTipo;
    }
}