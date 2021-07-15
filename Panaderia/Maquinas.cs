using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panaderia
{
    public partial class Maquinas : Form
    {
        private int nrenglones = 0; // se crea atributo para ser reconocido en toda la clase
        public Maquinas()
        {
            InitializeComponent();
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnagregar_Click(object sender, EventArgs e) // evento
        {
            int nrenglon = dtgmaquinas.Rows.Add(); // agrega un nuevo renglon

            dtgmaquinas.Rows[nrenglon].Cells[0].Value = txtnumero.Text; // agrega a la columna asiganda con lo que se encuentra en el textbox
            dtgmaquinas.Rows[nrenglon].Cells[1].Value = txtnombre.Text; // agrega a la columna asiganda con lo que se encuentra en el textbox
            dtgmaquinas.Rows[nrenglon].Cells[2].Value = txtencargado.Text; // agrega a la columna asiganda con lo que se encuentra en el textbox
            dtgmaquinas.Rows[nrenglon].Cells[3].Value = txtultimo.Text; // agrega a la columna asiganda con lo que se encuentra en el textbox
            dtgmaquinas.Rows[nrenglon].Cells[4].Value = txtproximo.Text; // agrega a la columna asiganda con lo que se encuentra en el textbox

            txtnumero.Text = ""; // limpia textbox
            txtnombre.Text = ""; // limpia textbox
            txtencargado.Text = ""; // limpia txtbox
            txtultimo.Text = ""; // limpia textbox
            txtproximo.Text = ""; // limpia textbox



        }

        private void Dtgmaquinas_CellClick(object sender, DataGridViewCellEventArgs e) // evento
        {
             nrenglones = e.RowIndex;

            if (nrenglones != -1) // no permite seleccionar el renglon -1
            {

            }

        }

        private void Btnborrar_Click(object sender, EventArgs e) // evento 
        {
            if (nrenglones != -1)  // no permite que se elimine el renglon principal
            {
                dtgmaquinas.Rows.RemoveAt(nrenglones); // elimina renglones 
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Lbultimo_Click(object sender, EventArgs e)
        {

        }

        private void Txtnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtultimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);

        }

        private void Txtencargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);

        }

        private void Txtproximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.fecha(e);
        }

        private void Txtultimo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.fecha(e);

        }

        private void Txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.sololetras(e);
        }

        private void dtgmaquinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Maquinas_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Maquinas_Load(object sender, EventArgs e)
        {

        }

        private void txtultimo_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
