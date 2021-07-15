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
    public partial class Desición : Form
    {
        public Desición()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form NotificacionAuto = new NotificacionAuto();
            NotificacionAuto.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form NotificacionMaquina = new NotificacionMaquina();
            NotificacionMaquina.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form NotificacionAuto = new NotificacionAuto();
            NotificacionAuto.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form NotificacionMaquina = new NotificacionMaquina();
            NotificacionMaquina.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form Maquinas = new Maquinas();
            Maquinas.Show();
        }
    }
}
