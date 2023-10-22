using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormsEmpresaEstrategiasProfecionales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUsu_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsu.Text;
            string contraseña = txtContra.Text;

            if (usuario == "admin" && contraseña == "1234")
            {
                Form2 formulario2 = new Form2(); // Crear objeto para cargar Form2
                formulario2.Show(); // Carga Formulario 2 Form2
                this.Hide(); // Deja en segundo plano la ventana actual
            }

            else if (usuario == "empleado" && contraseña == "4321")
            {
                Form2 formulario2 = new Form2(); // Crear objeto para cargar Form2
                formulario2.Show(); // Carga Formulario 2 Form2
                this.Hide(); // Deja en segundo plano la ventana actual
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))

            {
                e.Handled = false; // Si ingresa numeros se dice que la propiedad Handled se desactiva para que permita Numero
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true; // en el caso que se ingrese Cualquier otro valor se active y no permita ingreso
                MessageBox.Show(" Sólo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
