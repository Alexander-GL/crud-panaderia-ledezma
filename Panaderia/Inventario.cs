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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }
        MySqlConnection conexion = new MySqlConnection("server = localhost; port = 3306; database = panaderia; Uid = root;Pwd = 271509Familia;");
        DataSet ds;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Nos va a llenar el dataGridView con la lista del empleado encontrado
            int search;
            search = Convert.ToInt32((textBox6.Text));
            dataGridView1.DataSource = InventarioDAL.Buscar(search);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand mostrar = new MySqlCommand("SELECT * FROM producto", conexion);

            MySqlDataAdapter con = new MySqlDataAdapter(mostrar);
            ds = new DataSet();
            con.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            conexion.Close();
        }
    }
}
