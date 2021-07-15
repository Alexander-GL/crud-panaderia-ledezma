using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;       // Librerias

namespace Panaderia
{
    public partial class EditarEmpleado : Form
    {
        public EditarEmpleado()
        {
            InitializeComponent();
            comboBox1.Items.Add(" Encargado ");
            comboBox1.Items.Add(" Panadero ");
            comboBox1.Items.Add(" Mantenimiento ");
            comboBox1.Items.Add(" Cajero ");
            comboBox1.Items.Add(" Repartidor ");
            comboBox1.Items.Add(" Conserje ");
            // No se cambie el contenido del comboBox
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public Empleado EmpleadoActual { get; set; }
        private void Button1_Click(object sender, EventArgs e)
        {
            /*  this.Hide();
            Form Menu = new Menu();
            Menu.Show();    */
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Ingresa la clave de usuario, presiona la opción 'BUSCAR' y por último selecciona la fila que deseas editar (>)", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            BuscarEmpleadoEditor buscar = new BuscarEmpleadoEditor();
            buscar.ShowDialog();

            if (buscar.Seleccion != null)
            {
                EmpleadoActual = buscar.Seleccion;
                textBox1.Text = buscar.Seleccion.Nombre;
                textBox2.Text = buscar.Seleccion.Apellido1;
                textBox3.Text = buscar.Seleccion.Apellido2;
                textBox4.Text = buscar.Seleccion.Direccion;
                textBox5.Text = buscar.Seleccion.Telefono;
                comboBox1.Text = buscar.Seleccion.Puesto;
                textBox6.Text = buscar.Seleccion.Clave.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleado pEmpleado = new Empleado();
            int Clave;
            Clave = Convert.ToInt32(textBox6.Text);
            pEmpleado.Clave = EmpleadoActual.Clave;
            pEmpleado.Nombre = textBox1.Text.Trim();
            pEmpleado.Apellido1 = textBox2.Text.Trim();
            pEmpleado.Apellido2 = textBox3.Text.Trim();
            pEmpleado.Direccion = textBox4.Text.Trim();
            pEmpleado.Telefono = textBox5.Text.Trim();
            pEmpleado.Puesto = comboBox1.Text.Trim();

            if (EmpleadosDAL.Actualizar(pEmpleado) > 0)
            {
                MessageBox.Show("Los datos del cliente se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar el Cliente Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (EmpleadosDAL.Eliminar(EmpleadoActual.Clave) > 0)
                {
                    MessageBox.Show("Cliente Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    comboBox1.ResetText();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Cliente", "Cliente No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void EditarEmpleado_Load(object sender, EventArgs e)
        {

        }
        // Se mata la aplicacion completamente sin dar lugar a que este trabajando en segundo plano
        private void EditarEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
