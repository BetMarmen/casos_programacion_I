using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjPromedioNotas
{
    public partial class FormPromedio : Form
    {
        public FormPromedio()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Pnota = double.Parse(txtPrimerN.Text);
            double Snota = double.Parse(txtSegundaN.Text);
            double Tnota = double.Parse(txtTercerN.Text);
            double promedio = (Pnota + Snota + Tnota)/3;
            txtCalcular.Text = promedio.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            txtCalcular.Clear();
            txtPrimerN.Clear();
            txtSegundaN.Clear();
            txtTercerN.Clear();
        }
    }
}
