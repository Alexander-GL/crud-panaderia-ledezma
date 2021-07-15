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
    public partial class NotificacionMaquina : Form
    {
        public NotificacionMaquina()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se admite Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id;
            id = textBox1.Text;
            if (id == "")
            {
                MessageBox.Show("No se puede dejar el campo Clave vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Form NotificacionMaquina = new NotificacionMaquina();
            NotificacionMaquina.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Desición = new Desición();
            Desición.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            String texto3 = textBox1.Text;
            String texto4 = label5.Text;
            Form Noti2 = new Noti2(texto3, texto4);
            Noti2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Desición = new Desición();
            Desición.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string id;
            id = textBox1.Text;
            if (id == "")
            {
                MessageBox.Show("No se puede dejar el campo Clave vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                timer1.Enabled = true;
                timer1.Start();
                MessageBox.Show("Se ha definido la fecha de mantenimiento", "Notificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notificacion Cancelada", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
