using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Ejercicios.Capitulo8
{
    public partial class Capitulo8Ejercicio5 : Form
    {
        public Capitulo8Ejercicio5()
        {
            InitializeComponent();
        }

        private void Iniciarbutton_Click(object sender, EventArgs e)
        {
      
            ArrayList lista = new ArrayList();
            lista.Add(TextoUnotextBox.Text);
            lista.Add(TextoDostextBox.Text);
            lista.Sort();

            MostrarUnotextBox.Text = (string)lista[0];
            MostraDostextBox.Text = (string)lista[1];

            lista.Clear();
            
        }

        private void Capitulo8Ejercicio5_Load(object sender, EventArgs e)
        {

        }
    }
}
