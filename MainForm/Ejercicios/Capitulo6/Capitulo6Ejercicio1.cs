using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Ejercicios.Capitulo6
{
    public partial class Capitulo6Ejercicio1 : Form
    {
        int cantidaCusos,cantidadEstudiantes,ContCalificacion,ContAulas=0;
        float[][] calificacion;

        public Capitulo6Ejercicio1()
        {
            InitializeComponent();
            CantidadnumericUpDown.Hide();
            CalificacionnumericUpDown.Hide();
            IntroducirCalbutton.Hide();
            Siguientebutton.Hide();
        }

        private void Accionbutton_Click(object sender, EventArgs e)
        {
            ContCalificacion = 0;

            calificacion[ContAulas] = new float[cantidadEstudiantes];

        }

        private void cantidadCusos()
        {
            cantidaCusos = Convert.ToInt32(CantidadnumericUpDown.Value);
            calificacion = new float[cantidaCusos][];
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            cantidaCusos = Convert.ToInt32(CantidadAulasnumericUpDown.Value);
            calificacion = new float[cantidaCusos][];
            CantidadAulasnumericUpDown.Hide();
            Aceptarbutton.Hide();
            CantidadnumericUpDown.Show();
            IntroducirCalbutton.Show();
        }

        private void IntroducirCalbutton_Click(object sender, EventArgs e)
        {
            cantidadEstudiantes = Convert.ToInt32(CantidadnumericUpDown.Value);
            CantidadnumericUpDown.Hide();
            IntroducirCalbutton.Hide();

            CalificacionnumericUpDown.Show();
            Siguientebutton.Show();
        }

        private void Nuevabutton_Click(object sender, EventArgs e)
        {
            CantidadnumericUpDown.Value = 0;
            CalificacionnumericUpDown.Value = 0;
        }

        
    }
}
