namespace MainForm.Ejercicios.Capitulo8
{
    partial class Capitulo8Ejercicio3
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
            this.label1 = new System.Windows.Forms.Label();
            this.Horalabel = new System.Windows.Forms.Label();
            this.Iniciarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hacer un programa que muestre la hora";
            // 
            // Horalabel
            // 
            this.Horalabel.AutoSize = true;
            this.Horalabel.Location = new System.Drawing.Point(30, 53);
            this.Horalabel.Name = "Horalabel";
            this.Horalabel.Size = new System.Drawing.Size(98, 13);
            this.Horalabel.TabIndex = 1;
            this.Horalabel.Text = "00:00  00/00/0000";
            this.Horalabel.Click += new System.EventHandler(this.Horalabel_Click);
            // 
            // Iniciarbutton
            // 
            this.Iniciarbutton.Location = new System.Drawing.Point(199, 53);
            this.Iniciarbutton.Name = "Iniciarbutton";
            this.Iniciarbutton.Size = new System.Drawing.Size(75, 49);
            this.Iniciarbutton.TabIndex = 2;
            this.Iniciarbutton.Text = "Mostrar Hora y Fecha";
            this.Iniciarbutton.UseVisualStyleBackColor = true;
            this.Iniciarbutton.Click += new System.EventHandler(this.Iniciarbutton_Click);
            // 
            // Capitulo8Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 138);
            this.Controls.Add(this.Iniciarbutton);
            this.Controls.Add(this.Horalabel);
            this.Controls.Add(this.label1);
            this.Name = "Capitulo8Ejercicio3";
            this.Text = "Capitulo8Ejercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Horalabel;
        private System.Windows.Forms.Button Iniciarbutton;
    }
}