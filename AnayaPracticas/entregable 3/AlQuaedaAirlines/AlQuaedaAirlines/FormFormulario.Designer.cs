namespace AlQuaedaAirlines
{
    partial class FormFormulario
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
            
            int ind = getind();
            this.buttons = new System.Windows.Forms.Button[ind];
            this.SuspendLayout();
            // 
            // buttons
            //
            int i;
            for (i = 0; i < ind; i++)
            {
                System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();
                if (i % 2 == 0)
                {
                    button1.Location = new System.Drawing.Point(292, ((30 * ((i + 1) / 2))+7));
                }
                else
                {
                    button1.Location = new System.Drawing.Point(292 + 100, ((30 * (i / 2))+ 7));
                } ///Por estética de los botones he implementado este ordenamiento descubierto por un compañero
                button1.Name = "button" + i;
                button1.Size = new System.Drawing.Size(100, 30);
                button1.TabIndex = (10+i);
                button1.Text = (i + 1).ToString(); ///aqui es de manera visual, solo afecta la parte del usuario
                button1.UseVisualStyleBackColor = true;
                button1.Click += new System.EventHandler(this.buttons_Click);
                Controls.Add(button1);
                this.buttons[i] = button1;
            }
            
            this.labelAsiento = new System.Windows.Forms.Label();
            this.sellbutton = new System.Windows.Forms.Button();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.edge = new System.Windows.Forms.Label();
            this.LastNam = new System.Windows.Forms.Label();
            this.Asiento = new System.Windows.Forms.Label();
            this.Vuelolabel = new System.Windows.Forms.Label();
            this.Vuelola = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAsiento
            // 
            this.labelAsiento.AutoSize = true;
            this.labelAsiento.Location = new System.Drawing.Point(223, 193);
            this.labelAsiento.Name = "labelAsiento";
            this.labelAsiento.Size = new System.Drawing.Size(16, 13);
            this.labelAsiento.TabIndex = 10;
            this.labelAsiento.Text = "-1";
            // 
            // sellbutton
            // 
            this.sellbutton.Location = new System.Drawing.Point(40, 224);
            this.sellbutton.Name = "sellbutton";
            this.sellbutton.Size = new System.Drawing.Size(75, 23);
            this.sellbutton.TabIndex = 0;
            this.sellbutton.Text = "compra";
            this.sellbutton.UseVisualStyleBackColor = true;
            this.sellbutton.Click += new System.EventHandler(this.sellbutton_Click);
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(114, 116);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdad.TabIndex = 9;
            this.textBoxEdad.TextChanged += new System.EventHandler(this.textBoxEdad_TextChanged);
            this.textBoxEdad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEdad_KeyDown);
            this.textBoxEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEdad_KeyPress);
            this.textBoxEdad.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxEdad_PreviewKeyDown);
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(114, 78);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellidos.TabIndex = 8;
            this.textBoxApellidos.TextChanged += new System.EventHandler(this.textBoxApellidos_TextChanged);
            this.textBoxApellidos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNombre_KeyDown);
            this.textBoxApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            this.textBoxApellidos.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxNombre_PreviewKeyDown);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(114, 33);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 7;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            this.textBoxNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNombre_KeyDown);
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            this.textBoxNombre.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxNombre_PreviewKeyDown);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(43, 33);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(44, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Nombre";
            // 
            // edge
            // 
            this.edge.AutoSize = true;
            this.edge.Location = new System.Drawing.Point(40, 124);
            this.edge.Name = "edge";
            this.edge.Size = new System.Drawing.Size(32, 13);
            this.edge.TabIndex = 1;
            this.edge.Text = "Edad";
            // 
            // LastNam
            // 
            this.LastNam.AutoSize = true;
            this.LastNam.Location = new System.Drawing.Point(40, 78);
            this.LastNam.Name = "LastNam";
            this.LastNam.Size = new System.Drawing.Size(44, 13);
            this.LastNam.TabIndex = 2;
            this.LastNam.Text = "Apellido";
            // 
            // Asiento
            // 
            this.Asiento.AutoSize = true;
            this.Asiento.Location = new System.Drawing.Point(137, 193);
            this.Asiento.Name = "Asiento";
            this.Asiento.Size = new System.Drawing.Size(45, 13);
            this.Asiento.TabIndex = 3;
            this.Asiento.Text = "Asiento:";
            // 
            // Vuelolabel
            // 
            this.Vuelolabel.AutoSize = true;
            this.Vuelolabel.Location = new System.Drawing.Point(137, 171);
            this.Vuelolabel.Name = "Vuelolabel";
            this.Vuelolabel.Size = new System.Drawing.Size(30, 13);
            this.Vuelolabel.TabIndex = 4;
            this.Vuelolabel.Text = "Ruta";
            // 
            // Vuelola
            // 
            this.Vuelola.AutoSize = true;
            this.Vuelola.Location = new System.Drawing.Point(223, 171);
            this.Vuelola.Name = "Vuelola";
            this.Vuelola.Size = new System.Drawing.Size(16, 13);
            this.Vuelola.TabIndex = 5;
            this.Vuelola.Text = "-1";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(140, 224);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 11+i;
            this.cancel.Text = "cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // FormFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 625);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Vuelolabel);
            this.Controls.Add(this.Vuelola);
            this.Controls.Add(this.Asiento);
            this.Controls.Add(this.labelAsiento);
            this.Controls.Add(this.sellbutton);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.name);
            this.Controls.Add(this.edge);
            this.Controls.Add(this.LastNam);
            this.Name = "FormFormulario";
            this.Text = "FormFormulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button[] buttons;
        private System.Windows.Forms.Label labelAsiento;
        private System.Windows.Forms.Button sellbutton;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label edge;
        private System.Windows.Forms.Label LastNam;
        private System.Windows.Forms.Label Asiento;
        private System.Windows.Forms.Label Vuelolabel;
        private System.Windows.Forms.Label Vuelola;
        private System.Windows.Forms.Button cancel;
    }
}