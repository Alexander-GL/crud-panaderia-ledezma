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
    public partial class TipoUsuario : Form
    {
        public TipoUsuario()
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

        // Se declara la variable inicializada en 0 para usarla en el timer
        int conteo = 0;
        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Se oculta la ventana actual
            this.Hide();
            // Se crea un nuevo Form con su respectivo objeto
            Form Login = new Login();
            // Se muestra el Form creado
            Login.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Se oculta la ventana actual
            this.Hide();
            // Se crea un nuevo Form con su respectivo objeto
            Form LoginEmpleado = new LoginEmpleado();
            // Se muestra el Form creado
            LoginEmpleado.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Se oculta la ventana actual
            this.Hide();
            // Se crea un nuevo Form con su respectivo objeto
            Form Login = new Login();
            // Se muestra el Form creado
            Login.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void TipoUsuario_Load(object sender, EventArgs e)
        {
            // Iniciamos el timer y lo habilitamos
            timer1.Enabled = true;
            timer1.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Aumenta de uno en uno
            conteo++;
            // Se pone en una etiqueta la cual esta oculta
            label4.Text = Convert.ToString(conteo);
            // Comienza el conteo y cada tiempo establecido cambia de imagen
            if (conteo == 40)
            {
                pictureBox5.Image = Panaderia.Properties.Resources.pan1;
            }
            if (conteo == 80)
            {
                pictureBox5.Image = Panaderia.Properties.Resources.pan2;
            }
            if (conteo == 120)
            {
                pictureBox5.Image = Panaderia.Properties.Resources.pan3;
            }
            if (conteo == 160)
            {
                pictureBox5.Image = Panaderia.Properties.Resources.pan4;
            }
            if (conteo == 200)
            {
                pictureBox5.Image = Panaderia.Properties.Resources.pan5;
            }
            if (conteo == 240)
            {
                pictureBox5.Image = Panaderia.Properties.Resources.pan6;
            }
            if (conteo == 280)
            {
                pictureBox5.Image = Panaderia.Properties.Resources.pan7;
            }
            // Cuando el conteo sea igual 320 segundos el timer se va a detener y se pondra la ultima imagen
            if (conteo == 320)
            {
                timer1.Stop();
                pictureBox5.Image = Panaderia.Properties.Resources.pan8;
                // Se reiniciara y comenzara a hacer el mismo proceso
                conteo = 0;
                timer1.Start();
            }

        }
        // Estos enlaces nos dirigen o intentan dirigir a la empresa para la que estamos trabajando
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/alexander38493");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/eduardo.bher/");
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/@yesseniaitzel12");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=523328345470");
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            // Se oculta la ventana actual
            this.Hide();
            // Se crea un nuevo Form con su respectivo objeto
            Form Login = new Login();
            // Se muestra el Form creado
            Login.Show();
        }
        // Se mata la aplicacion completamente sin dar lugar a que este trabajando en segundo plano
        private void TipoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
