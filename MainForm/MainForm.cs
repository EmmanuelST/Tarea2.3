using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainForm.Ejercicios;
using MainForm.Ejercicios.Capitulo7;

namespace MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public object Capitulo5Ejercicio4 { get; private set; }

        private void Cap5ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Capitulo5Ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void EjerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capitulo_5_Ejercicio_4 capitulo_5_Ejercicio_4 = new Capitulo_5_Ejercicio_4();
            capitulo_5_Ejercicio_4.Show();
        }

        private void Ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capitulo7Ejercicio2 capitulo7Ejercicio2 = new Capitulo7Ejercicio2();
            capitulo7Ejercicio2.Show();
        }
    }
}
