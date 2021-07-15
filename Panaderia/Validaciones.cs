using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Panaderia
{
    class Validaciones   // Clase para crear validaciones
    {
        public static void SoloNumeros(KeyPressEventArgs pE) // Metodo para validar solo numeros 
        {
            if (char.IsDigit(pE.KeyChar))  // condicion a cumplir
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))  // condicion 
            {
                pE.Handled = false;  // no muestra
            }
            else
            {
                pE.Handled = true;  // muestra
                MessageBox.Show("Solo permite ingresar numeros");  // mensaje para el usuario
            }
        }

        public static void sololetras(KeyPressEventArgs v)
        {
            if (char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            //else if (char.IsSeparator(v.KeyChar))
            //{
            //    v.Handled = true;
            //}
            else if (char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else {
                v.Handled = true;
                MessageBox.Show("Solo permite ingresar letras");

            }
        }
        public static void fecha(KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar)) // comprueba que solo se ingresen numeros
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar)) // comprueba que no se ingresen tipo char
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 47) // comprueba que no se ingresen tipo char
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                MessageBox.Show("Use el formato DD/MM/YY"); // envia mensaje al usuario
            }
        }



    }
}
