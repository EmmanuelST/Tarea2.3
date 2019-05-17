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

namespace MainForm.Ejercicios.Capitulo7
{
    public partial class Capitulo7Ejercicio2 : Form
    {
        private Hashtable diccionario = new Hashtable();
        public Capitulo7Ejercicio2()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(string.IsNullOrWhiteSpace(ClavetextBox.Text))
            {
                errorProvider1.SetError(ClavetextBox,"No puede estar vacio el campo de Palabra Clave.");
            }
            else
            {
                if (diccionario.Contains(ClavetextBox.Text.ToLower()))
                {
                    DefiniciontextBox.Text = (string)diccionario[ClavetextBox.Text.ToLower()];
                }
            }

            

        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(ClavetextBox.Text))
            {
                errorProvider1.SetError(ClavetextBox, "No puede estar vacio el campo de Palabra Clave.");
            }

            if (string.IsNullOrWhiteSpace(DefiniciontextBox.Text))
            {
                errorProvider1.SetError(DefiniciontextBox, "No puede estar vacio el campo de Definicion.");
            }else
            if (!diccionario.Contains(ClavetextBox.Text.ToLower()))
            {
                diccionario.Add(ClavetextBox.Text.ToLower(),(string)DefiniciontextBox.Text);
                ClavetextBox.Text = string.Empty;
                DefiniciontextBox.Text = string.Empty;
            }
        }
    }
}
