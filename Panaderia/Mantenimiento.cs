using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;       // Librerias

namespace Panaderia
{
    public partial class Mantenimiento : Form
    {
        public Mantenimiento(String texto, String texto2)
        {
            InitializeComponent();
            id1.Text = texto;
            tipo.Text = texto2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se le dara aviso a tu supervisor", "Atencion");
            this.Hide();
        }
        // Se mata la aplicacion completamente sin dar lugar a que este trabajando en segundo plano
        private void Mantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por realizar tu trabajo", "Felicidades");
        }
    }
}
