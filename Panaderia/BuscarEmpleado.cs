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
    public partial class BuscarEmpleado : Form
    {
        public BuscarEmpleado()
        {
            InitializeComponent();
        }

        MySqlConnection conexion = new MySqlConnection("server = localhost; port = 3306; database = panaderia; Uid = root;Pwd = 271509Familia;");
        DataSet ds;

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
        // Clase publica para la seleccion del empleado que despues nos ayudara para editar el empleado
        public Empleado Seleccion { get; set; }

        private void button1_Click_1(object sender, EventArgs e)
        { 
            // Nos va a llenar el dataGridView con la lista del empleado encontrado
            int search;
            search = Convert.ToInt32((textBox6.Text));
            dataGridView1.DataSource = EmpleadosDAL.Buscar(search);
            MessageBox.Show("Una vez seleccionada la fila que deseas editar (>) presiona la opción 'EDITAR'", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Se selecciona la fila del empleado
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int clave = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Seleccion = EmpleadosDAL.ObtenerEmpleado(clave);

                this.Hide();
            }
            else
                MessageBox.Show("Es necesario que seleccione una fila");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar el Cliente Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (EmpleadosDAL.Eliminar(EmpleadoActual.Clave) > 0)
                {
                    MessageBox.Show("Cliente Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Cliente", "Cliente No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        // Se mata la aplicacion completamente sin dar lugar a que este trabajando en segundo plano
        private void BuscarEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void BuscarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se admite Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand mostrar = new MySqlCommand("SELECT * FROM empleado", conexion);

            MySqlDataAdapter con = new MySqlDataAdapter(mostrar);
            ds = new DataSet();
            con.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            conexion.Close();
        }
    }
}
