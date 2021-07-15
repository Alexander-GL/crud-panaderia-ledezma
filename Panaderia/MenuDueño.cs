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
    public partial class MenuDueño : Form
    {
        public MenuDueño()
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

        private void AbrirFormhijoDueño(object formhijodueño)
        {
            if (this.panelContenedorDueño.Controls.Count > 0)
                this.panelContenedorDueño.Controls.RemoveAt(0);
            Form fh = formhijodueño as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorDueño.Controls.Add(fh);
            this.panelContenedorDueño.Tag = fh;
            fh.Show();

        } 

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            AbrirFormhijoDueño(new EditarEmpleado());

            MessageBox.Show("Para editar un empleado debes presionar primero la opción 'BUSCAR'", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormhijoDueño(new AgregarEmpleado());
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormhijoDueño(new BuscarEmpleado());
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            AbrirFormhijoDueño(new Maquinas());
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginEmpleado Empleados = new LoginEmpleado();
            Empleados.Show();
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
            AbrirFormhijoDueño(new Desición());
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginEmpleado Empleados = new LoginEmpleado();
            Empleados.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            AbrirFormhijoDueño(new Desición());
        }

        private void label7_Click(object sender, EventArgs e)
        {
            AbrirFormhijoDueño(new Maquinas());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AbrirFormhijoDueño(new AgregarEmpleado());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AbrirFormhijoDueño(new EditarEmpleado());

            MessageBox.Show("Para editar un empleado debes presionar primero la opción 'BUSCAR'", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AbrirFormhijoDueño(new BuscarEmpleado());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginEmpleado Empleados = new LoginEmpleado();
            Empleados.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormhijoDueño(new Desición());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormhijoDueño(new AgregarEmpleado());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormhijoDueño(new EditarEmpleado());

            MessageBox.Show("Para editar un empleado debes presionar primero la opción 'BUSCAR'", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormhijoDueño(new BuscarEmpleado());
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormhijoDueño(new Inventario());
        }
    }
}