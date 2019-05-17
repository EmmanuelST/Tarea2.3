namespace MainForm
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitulo5Ejercicio4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitulo6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitulo7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejerciciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejerciciosToolStripMenuItem
            // 
            this.ejerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capitulo5Ejercicio4ToolStripMenuItem,
            this.capitulo6ToolStripMenuItem,
            this.capitulo7ToolStripMenuItem});
            this.ejerciciosToolStripMenuItem.Name = "ejerciciosToolStripMenuItem";
            this.ejerciciosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.ejerciciosToolStripMenuItem.Text = "&Ejercicios";
            this.ejerciciosToolStripMenuItem.Click += new System.EventHandler(this.EjerciciosToolStripMenuItem_Click);
            // 
            // capitulo5Ejercicio4ToolStripMenuItem
            // 
            this.capitulo5Ejercicio4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejercicio4ToolStripMenuItem});
            this.capitulo5Ejercicio4ToolStripMenuItem.Name = "capitulo5Ejercicio4ToolStripMenuItem";
            this.capitulo5Ejercicio4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.capitulo5Ejercicio4ToolStripMenuItem.Text = "Capitulo &5 ";
            this.capitulo5Ejercicio4ToolStripMenuItem.Click += new System.EventHandler(this.Capitulo5Ejercicio4ToolStripMenuItem_Click);
            // 
            // ejercicio4ToolStripMenuItem
            // 
            this.ejercicio4ToolStripMenuItem.Name = "ejercicio4ToolStripMenuItem";
            this.ejercicio4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio4ToolStripMenuItem.Text = "Ejercicio &4";
            this.ejercicio4ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio4ToolStripMenuItem_Click);
            // 
            // capitulo6ToolStripMenuItem
            // 
            this.capitulo6ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejercicio1ToolStripMenuItem});
            this.capitulo6ToolStripMenuItem.Name = "capitulo6ToolStripMenuItem";
            this.capitulo6ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.capitulo6ToolStripMenuItem.Text = "Capitulo &6";
            // 
            // ejercicio1ToolStripMenuItem
            // 
            this.ejercicio1ToolStripMenuItem.Name = "ejercicio1ToolStripMenuItem";
            this.ejercicio1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio1ToolStripMenuItem.Text = "Ejercicio 1";
            // 
            // capitulo7ToolStripMenuItem
            // 
            this.capitulo7ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejercicio2ToolStripMenuItem,
            this.ejercicio5ToolStripMenuItem});
            this.capitulo7ToolStripMenuItem.Name = "capitulo7ToolStripMenuItem";
            this.capitulo7ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.capitulo7ToolStripMenuItem.Text = "Capitulo &7";
            // 
            // ejercicio2ToolStripMenuItem
            // 
            this.ejercicio2ToolStripMenuItem.Name = "ejercicio2ToolStripMenuItem";
            this.ejercicio2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio2ToolStripMenuItem.Text = "Ejercicio &2";
            this.ejercicio2ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio2ToolStripMenuItem_Click);
            // 
            // ejercicio5ToolStripMenuItem
            // 
            this.ejercicio5ToolStripMenuItem.Name = "ejercicio5ToolStripMenuItem";
            this.ejercicio5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio5ToolStripMenuItem.Text = "Ejercicio &5";
            this.ejercicio5ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio5ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitulo5Ejercicio4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitulo6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitulo7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio5ToolStripMenuItem;
    }
}

