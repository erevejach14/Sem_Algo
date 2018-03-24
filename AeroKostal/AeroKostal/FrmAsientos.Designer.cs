namespace AeroKostal
{
    partial class FrmAsientos
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
            this.buttons = new System.Windows.Forms.Button[20];
            this.SuspendLayout();
            // 
            // button1
            //
            for (int i = 0; i < 20; i++)
            {
                System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();
                if(i%2==0){
                    button1.Location = new System.Drawing.Point(15, (30*((i+1)/2)));
                }
                else {
                    button1.Location = new System.Drawing.Point(15+100,(30*(i/2)));
                }
                button1.Name = "button" + i;
                button1.Size = new System.Drawing.Size(95, 30);
                button1.TabIndex = 0;
                button1.Text = (i+1).ToString(); ///aqui es de manera visual, solo afecta la parte del usuario
                button1.UseVisualStyleBackColor = true;
                button1.Click += new System.EventHandler(this.buttons_Click);
                Controls.Add(button1);
                this.buttons[i] = button1;
            }
            // 
            // FrmAsientosPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 300);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAsientos";
            this.Text = "Elije asiento";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button [] buttons;
    }
}