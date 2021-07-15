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
    public partial class Noti2 : Form
    {
        public Noti2()
        {
            InitializeComponent();
        }
        public Noti2(String texto3, String texto4)
        {
            InitializeComponent();
            id1.Text = texto3;
            tipo.Text = texto4;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se le dara aviso a tu supervisor", "Atencion");
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por realizar tu trabajo", "Felicidades");
        }
    }
}
