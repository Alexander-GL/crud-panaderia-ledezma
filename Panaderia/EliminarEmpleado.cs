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
    public partial class EliminarEmpleado : Form
    {
        public EliminarEmpleado()
        {
            InitializeComponent();
        }
        public Empleado EmpleadoActual { get; set; }
        public Empleado Seleccion { get; set; }
        private void Button1_Click(object sender, EventArgs e)
        {
            /*  this.Hide();
            Form Menu = new Menu();
            Menu.Show();    */
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
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
        private void EliminarEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int clave = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Seleccion = EmpleadosDAL.ObtenerEmpleado(clave);

                this.Hide();
                Form EditarEmpleado = new EditarEmpleado();
                EditarEmpleado.Show();
            }
            else
                MessageBox.Show("Es necesario que seleccione una fila");
        }

        private void EliminarEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
