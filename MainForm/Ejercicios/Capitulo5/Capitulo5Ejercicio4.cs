using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Ejercicios
{
    public partial class Capitulo_5_Ejercicio_4 : Form
    {
        public Capitulo_5_Ejercicio_4()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(EntradatextBox.Text))
                if (Convert.ToInt32(EntradatextBox.Text) > 0)
                    Resultadolabel.Text = Factorial(Convert.ToInt32(EntradatextBox.Text)).ToString();

        }

        double Factorial(int numero)
        {
            double factorial = numero;

            for (int i = numero-1; i >0; i--)
                factorial *= i;

            return factorial ;
        }
    }
}
