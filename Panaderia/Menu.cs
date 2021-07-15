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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        // Esto sirve para que a la hora de abrir el programa no se vea que parpadean las imagenes mientras cargan
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void PictureBox3_Click(object sender, EventArgs e)
        { 
            // Se crea un nuevo Form con su respectivo objeto
            Form EditarEmpleado = new EditarEmpleado();
            // Se muestra el Form creado
            EditarEmpleado.Show();

            MessageBox.Show("Para editar un empleado debes presionar primero la opción 'BUSCAR'", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            // Se crea un nuevo Form con su respectivo objeto
            Form AgregarEmpleado = new AgregarEmpleado();
            // Se muestra el Form creado
            AgregarEmpleado.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            // Se crea un nuevo Form con su respectivo objeto
            BuscarEmpleado buscar = new BuscarEmpleado();
            // Se muestra el Form creado
            buscar.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            // Se crea un nuevo Form con su respectivo objeto
            Form Maquinas = new Maquinas();
            // Se muestra el Form creado
            Maquinas.Show();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            // Se oculta la ventana actual
            this.Hide();
            // Se crea un nuevo Form con su respectivo objeto
            Form LoginEmpleado = new LoginEmpleado();
            // Se muestra el Form creado
            LoginEmpleado.Show();
        }
        // Estos enlaces nos dirigen o intentan dirigir a la empresa para la que estamos trabajando
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/alexander38493");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/alex_glop/");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/Alexand55937250");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=523328345470");
        }
        // Se mata la aplicacion completamente sin dar lugar a que este trabajando en segundo plano
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click_2(object sender, EventArgs e)
        {
            Form Desición = new Desición();
            Desición.Show();
        }
    }
}