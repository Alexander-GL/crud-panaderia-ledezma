using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panaderia
{
    public partial class NotificacionAuto : Form
    {
        public NotificacionAuto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id;
            id = textBox1.Text;
            if (id == "")
            {
                MessageBox.Show("No se puede dejar el campo Matricula vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                timer1.Enabled = true;
                timer1.Start();
                MessageBox.Show("Se ha definido la fecha de mantenimiento", "Notificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notificacion Cancelada", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(textBox1.Text);
            if (id == 1)
            {
                label5.Text = Convert.ToString("Toyota 2019");
            }
            else
            {
                label5.Text = "";

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            String texto = textBox1.Text;
            String texto2 = label5.Text;
            Form Mantenimiento = new Mantenimiento(texto, texto2);
            Mantenimiento.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Desición = new Desición();
            Desición.Show();
        }
    }
}
