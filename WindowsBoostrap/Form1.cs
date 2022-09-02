using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBoostrap
{
    public partial class FormBoostrap : Form
    {
        public FormBoostrap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El mensaje es: " + textBoxMensaje.Text);
        }

        private void SelecAnimales_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(SelecAnimales.Text + " escogido");
        }

        private void AceptarCondiciones_CheckedChanged(object sender, EventArgs e)
        {
            if (AceptarCondiciones.Checked)
            {
                MessageBox.Show("Aceptas");
            }
            else
            {
                MessageBox.Show("Ya no aceptas");
            }
        }

        private void radioButtonMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMujer.Checked)
            {
                MessageBox.Show("Tienes almeja");
            }
        }

        private void radioButtonHombre_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHombre.Checked)
            {
                MessageBox.Show("Tienes pija");
            }
        }

        private void listPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listPaises.Text + " escogido");
        }
    }
}
