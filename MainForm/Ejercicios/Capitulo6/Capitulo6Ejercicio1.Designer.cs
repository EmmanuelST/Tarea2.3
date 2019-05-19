namespace MainForm.Ejercicios.Capitulo6
{
    partial class Capitulo6Ejercicio1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Peticionlabel = new System.Windows.Forms.Label();
            this.Siguientebutton = new System.Windows.Forms.Button();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.NumerocolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PromediocolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CalificacionnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cantidadlabel = new System.Windows.Forms.Label();
            this.IntroducirCalbutton = new System.Windows.Forms.Button();
            this.CantidadAulasnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalificacionnumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadAulasnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular el Promedio con Arreglos  Jagger";
            // 
            // Peticionlabel
            // 
            this.Peticionlabel.AutoSize = true;
            this.Peticionlabel.Location = new System.Drawing.Point(7, 62);
            this.Peticionlabel.Name = "Peticionlabel";
            this.Peticionlabel.Size = new System.Drawing.Size(185, 13);
            this.Peticionlabel.TabIndex = 1;
            this.Peticionlabel.Text = "Introdusca la cantidad de Estudiantes";
            // 
            // Siguientebutton
            // 
            this.Siguientebutton.Location = new System.Drawing.Point(211, 30);
            this.Siguientebutton.Name = "Siguientebutton";
            this.Siguientebutton.Size = new System.Drawing.Size(75, 23);
            this.Siguientebutton.TabIndex = 3;
            this.Siguientebutton.Text = "Siguiente";
            this.Siguientebutton.UseVisualStyleBackColor = true;
            this.Siguientebutton.Click += new System.EventHandler(this.Accionbutton_Click);
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(10, 79);
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(176, 20);
            this.CantidadnumericUpDown.TabIndex = 5;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumerocolumnHeader,
            this.PromediocolumnHeader});
            this.listView1.Location = new System.Drawing.Point(10, 232);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(306, 115);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // NumerocolumnHeader
            // 
            this.NumerocolumnHeader.Text = "Curso #";
            this.NumerocolumnHeader.Width = 99;
            // 
            // PromediocolumnHeader
            // 
            this.PromediocolumnHeader.Text = "Promedio";
            this.PromediocolumnHeader.Width = 241;
            // 
            // CalificacionnumericUpDown
            // 
            this.CalificacionnumericUpDown.Location = new System.Drawing.Point(11, 30);
            this.CalificacionnumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CalificacionnumericUpDown.Name = "CalificacionnumericUpDown";
            this.CalificacionnumericUpDown.Size = new System.Drawing.Size(176, 20);
            this.CalificacionnumericUpDown.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Introdusca la Calificacion del estudiante#";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Aceptarbutton);
            this.groupBox1.Controls.Add(this.CantidadAulasnumericUpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IntroducirCalbutton);
            this.groupBox1.Controls.Add(this.CantidadnumericUpDown);
            this.groupBox1.Controls.Add(this.Peticionlabel);
            this.groupBox1.Location = new System.Drawing.Point(11, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 112);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infromacion de aula";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Cantidadlabel);
            this.groupBox2.Controls.Add(this.CalificacionnumericUpDown);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Siguientebutton);
            this.groupBox2.Location = new System.Drawing.Point(10, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 73);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calificaciones";
            // 
            // Cantidadlabel
            // 
            this.Cantidadlabel.AutoSize = true;
            this.Cantidadlabel.Location = new System.Drawing.Point(212, 13);
            this.Cantidadlabel.Name = "Cantidadlabel";
            this.Cantidadlabel.Size = new System.Drawing.Size(0, 13);
            this.Cantidadlabel.TabIndex = 11;
            // 
            // IntroducirCalbutton
            // 
            this.IntroducirCalbutton.Location = new System.Drawing.Point(210, 69);
            this.IntroducirCalbutton.Name = "IntroducirCalbutton";
            this.IntroducirCalbutton.Size = new System.Drawing.Size(75, 36);
            this.IntroducirCalbutton.TabIndex = 10;
            this.IntroducirCalbutton.Text = "Introducir califiacaión";
            this.IntroducirCalbutton.UseVisualStyleBackColor = true;
            this.IntroducirCalbutton.Click += new System.EventHandler(this.IntroducirCalbutton_Click);
            // 
            // CantidadAulasnumericUpDown
            // 
            this.CantidadAulasnumericUpDown.Location = new System.Drawing.Point(10, 33);
            this.CantidadAulasnumericUpDown.Name = "CantidadAulasnumericUpDown";
            this.CantidadAulasnumericUpDown.Size = new System.Drawing.Size(176, 20);
            this.CantidadAulasnumericUpDown.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Introdusca la cantidad de Aulas";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.Location = new System.Drawing.Point(210, 30);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(75, 23);
            this.Aceptarbutton.TabIndex = 13;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.UseVisualStyleBackColor = true;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // Capitulo6Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 416);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "Capitulo6Ejercicio1";
            this.Text = "Capitulo6Ejercicio1";
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalificacionnumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadAulasnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Peticionlabel;
        private System.Windows.Forms.Button Siguientebutton;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NumerocolumnHeader;
        private System.Windows.Forms.ColumnHeader PromediocolumnHeader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Cantidadlabel;
        private System.Windows.Forms.NumericUpDown CalificacionnumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button IntroducirCalbutton;
        private System.Windows.Forms.NumericUpDown CantidadAulasnumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Aceptarbutton;
    }
}