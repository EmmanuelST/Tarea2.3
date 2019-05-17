using System;
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
    public partial class Capitulo7Ejercicio5 : Form
    {
        public Capitulo7Ejercicio5()
        {
            InitializeComponent();
        }

        private void Agreagrbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if(string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                errorProvider.SetError(NombretextBox,"Este campo no puede estar vacio");
            }

            if(string.IsNullOrWhiteSpace(TelefonotextBox.Text))
            {
                errorProvider.SetError(TelefonotextBox,"Este campo no puede estar vacio");
            }else
            {
                ListViewItem lista = new ListViewItem(NombretextBox.Text);
                lista.SubItems.Add(TelefonotextBox.Text);
                ContactoslistView.Items.Add(lista);
            }
        }
    }
}
