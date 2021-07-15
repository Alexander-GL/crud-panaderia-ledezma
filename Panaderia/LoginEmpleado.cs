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
    public partial class LoginEmpleado : Form
    {
        public LoginEmpleado()
        {
            InitializeComponent();
            
            comboBox1.Items.Add(" Salida ");
            comboBox2.Items.Add(" Entrada ");
            // No se cambie el contenido del comboBox
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            timer1.Enabled = true;
        }

        private void LoginEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            /*  this.Hide();
            Form Menu = new Menu();
            Menu.Show();    */
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form TipoUsuario = new TipoUsuario();
            TipoUsuario.Show();
        }
        // Se mata la aplicacion completamente sin dar lugar a que este trabajando en segundo plano
        private void LoginEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hora_Llegada pLlegada = new Hora_Llegada();
            pLlegada.Clave_Empleado = Convert.ToInt32(textBox1.Text.Trim());

            int resultado = EmpleadosDAL.H_Llegada(pLlegada);

            if (resultado > 0)
            {
                MessageBox.Show("Horario registrado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo registrar el horario", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 1)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                comboBox1.ResetText();
            }
            if (comboBox1.SelectedIndex != 0)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                comboBox1.ResetText();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hora_Llegada pSalida = new Hora_Llegada();
            pSalida.Clave_Empleado = Convert.ToInt32(textBox2.Text.Trim());

            int resultado = EmpleadosDAL.H_Salida(pSalida);

            if (resultado > 0)
            {
                MessageBox.Show("Horario registrado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo registrar el horario", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            textBox1.Clear();
            textBox2.Clear();
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

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se admite Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Hora_Llegada pLlegada = new Hora_Llegada();
            pLlegada.Llegada = label5.Text.Trim();

            int resultado1 = EmpleadosDAL.H_Llegada(pLlegada);

            Hora_Llegada pSalida = new Hora_Llegada();
            pSalida.Salida = label5.Text.Trim();

            int resultado2 = EmpleadosDAL.H_Salida(pSalida);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 1)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                comboBox2.ResetText();
            }
            if (comboBox1.SelectedIndex != 0)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                comboBox2.ResetText();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ConsultarAsistencia = new ConsultarAsistencia();
            ConsultarAsistencia.Show();
        }
    }
}
