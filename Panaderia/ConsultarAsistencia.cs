using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Panaderia
{
    public partial class ConsultarAsistencia : Form
    {
        public ConsultarAsistencia()
        {
            InitializeComponent();
        }

        MySqlConnection conexion = new MySqlConnection("server = localhost; port = 3306; database = panaderia; Uid = root;Pwd = 271509Familia;");
        DataSet ds;

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand mostrar = new MySqlCommand("SELECT Clave_Empleado, Llegada, Salida FROM asistencia_empleados", conexion);

            MySqlDataAdapter con = new MySqlDataAdapter(mostrar);
            ds = new DataSet();
            con.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            conexion.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
