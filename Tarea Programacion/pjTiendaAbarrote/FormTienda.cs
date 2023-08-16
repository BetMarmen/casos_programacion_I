using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjTiendaAbarrote
{
    public partial class FormTienda : Form
    {
        public FormTienda()
        {
            InitializeComponent();
        }

        private void FormTienda_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            // Obtener el precio y la cantidad ingresados por el usuario
            double precio = double.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtCantidad.Text);

            // Realizar el cálculo
            double total = precio * cantidad;

            // Mostrar el resultado en el TextBox de resultado
            txtTotal.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtTotal.Clear();
        }
    }
}
