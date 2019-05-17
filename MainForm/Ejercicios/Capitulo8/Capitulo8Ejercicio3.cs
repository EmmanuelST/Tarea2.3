using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Ejercicios.Capitulo8
{
    public partial class Capitulo8Ejercicio3 : Form
    {
        DateTime fecha = new DateTime();
        public Capitulo8Ejercicio3()
        {
            
            InitializeComponent();
            
        }


        private void setTiempo()
        {
            
           
            Horalabel.Text = DateTime.Now.ToShortTimeString();
           // Thread.Sleep(10000);
            setTiempo();

            
        }

        private void Iniciarbutton_Click(object sender, EventArgs e)
        {
            setTiempo();
        }
    }
}
