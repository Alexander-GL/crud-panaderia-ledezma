using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;       // Librerias
using MySql.Data.MySqlClient;
namespace Panaderia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void Button1_Click_1(object sender, EventArgs e)
        {

            if (textBox1.Text == "Rafael" && textBox2.Text == "654321") // Si el usuario es correcto nos abrira la otra ventana.
            {
                this.Hide();
                Form MenuDueño = new MenuDueño();
                MenuDueño.Show();
            }
            else if (textBox1.Text == "Gerardo" && textBox2.Text == "271509")
            {
                this.Hide();
                Form MenuEncargado = new MenuEncargado();
                MenuEncargado.Show(); 
            }
            else    //Si no lo es mostrara este mensaje.
            {
                MessageBox.Show("Ingrese sus datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Se mata la aplicacion completamente sin dar lugar a que este trabajando en segundo plano
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se admite Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se admite Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
