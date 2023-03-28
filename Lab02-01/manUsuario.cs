using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class manUsuario : Form
    {
        public manUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DNI = txtDNI.Text;
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string Direccion = txtDireccion.Text;
            string FechaNac = dateTimePicker1.Value.Date.ToShortDateString();
            string Apellido = txtApellido.Text;
            string Email = txtEmail.Text;

            dgvUsuarios.Rows.Add(DNI, nombre, telefono, Direccion, FechaNac, Apellido, Email);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
