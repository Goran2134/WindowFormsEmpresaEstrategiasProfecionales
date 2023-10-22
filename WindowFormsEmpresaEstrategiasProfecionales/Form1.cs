using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowFormsEmpresaEstrategiasProfecionales.Models;

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
            // data test access -- mock data
            TypeUser admin = new TypeUser
            {
                Id = 1,
                Name = "admin",
                Descriptions = "usuario con permisos para crear empleados"
            };
             
            User user = new User
            {
                Name = "Nombre",
                Rut = "RUT12345",
                Address = "Dirección de usuario",
                LasName = "Apellido",
                Id = 123,
            };

            Access access = new Access
            {
                Id = 1,
                UserName = "goran",
                Password = "1234",
                State = "Activo",
                TypeUser = admin,
                User = user
            };
            // end mock data 

            if (access.login(txtUsu.Text, txtContra.Text))
            {
                if (access.TypeUser.Name == "admin")
                {
                    Form2 formulario2 = new Form2();
                    formulario2.Show();
                    this.Hide(); 
                }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
