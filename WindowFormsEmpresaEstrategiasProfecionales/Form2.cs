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
    public partial class Form2 : Form
    {
        int i = 1;
        int poc = 0;
        int indiceComboafp = 0;
        int IndiceCombo2medica = 0;
        public Form2()
        {
            InitializeComponent();
            Limpiar();
        }

        private void btnCerra_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        void Limpiar()
        {
            txtRut.Clear();
            txtNom.Clear();
            txtApelli.Clear();
            txtDireccion.Clear();
            txtHorasExtra.Clear();
            txtHorasTra.Clear();
            txtSueldoBru.Clear();
            txtSueldoLiqui.Clear();
            btnModi.Enabled = false;
            btnElimi.Enabled = false;
        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtRut.Clear();
            txtNom.Clear();
            txtApelli.Clear();
            txtDireccion.Clear();
            txtHorasExtra.Clear();
            txtHorasTra.Clear();
            txtSueldoBru.Clear();
            txtSueldoLiqui.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Rut, Nombre, Apellidos, Direccion, SueldoLiqui;
            Rut = txtRut.Text;
            Nombre = txtNom.Text;
            Apellidos = txtApelli.Text;
            Direccion = txtDireccion.Text;
            SueldoLiqui = txtHorasExtra.Text;
            dgvEmpleados.Rows.Add(i + "", Rut, Nombre, Apellidos, Direccion, SueldoLiqui);
            Limpiar();
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvEmpleados.CurrentRow.Index;
            txtRut.Text = dgvEmpleados[0, poc].Value.ToString();
            txtNom.Text = dgvEmpleados[1, poc].Value.ToString();
            txtApelli.Text = dgvEmpleados[2, poc].Value.ToString();
            txtDireccion.Text = dgvEmpleados[3, poc].Value.ToString();
            txtHorasTra.Text = dgvEmpleados[4, poc].Value.ToString();
            txtHorasExtra.Text = dgvEmpleados[5, poc].Value.ToString();
            txtSueldoLiqui.Text = dgvEmpleados[6, poc].Value.ToString();
            
            btnGuar.Enabled = false;
            btnModi.Enabled = true;
            btnElimi.Enabled = true;

        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show(" Sólo se permiten letras o espacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnElimi_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Rows.RemoveAt(poc);
            btnGuar.Enabled = true;
            Limpiar();
        }

        private void btnGuar_Click(object sender, EventArgs e)
        {
            string Rut, Nombre, Apellidos, Direccion, SueldoLiqui, Horastrabaja, horasextra;
            Rut = txtRut.Text;
            Nombre = txtNom.Text;
            Apellidos = txtApelli.Text;
            Direccion = txtDireccion.Text;
            Horastrabaja = txtHorasTra.Text;
            horasextra = txtHorasExtra.Text;
            SueldoLiqui = txtSueldoLiqui.Text;
            if (Convert.ToInt32(Horastrabaja) >= 0 && Convert.ToInt32(horasextra) >= 0)
            {
                dgvEmpleados.Rows.Add(i + Rut, Nombre, Apellidos, Direccion, Horastrabaja, horasextra, SueldoLiqui);
                i++;
                Limpiar() ;
            }
            else
            {
                MessageBox.Show(" Las horas trabajadas deben ser mayor a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHorasExtra.Clear();
                txtHorasExtra.Focus();
            }

            btnGuar.Enabled = false;
            btnModi.Enabled = true;
            btnElimi.Enabled = true;
        }

        private void btnModi_Click(object sender, EventArgs e)
        {
 
            string Rut, Nombre, Apellidos, Direccion, SueldoLiqui, Horastrabaja, horasextra;
            Rut = txtRut.Text;
            Nombre = txtNom.Text;
            Apellidos = txtApelli.Text;
            Direccion = txtDireccion.Text;
            Horastrabaja = txtHorasTra.Text;
            horasextra = txtHorasExtra.Text;
            SueldoLiqui = txtSueldoLiqui.Text;
         
            dgvEmpleados[0, poc].Value = Rut;
            dgvEmpleados[1, poc].Value = Nombre;
            dgvEmpleados[2, poc].Value = Apellidos;
            dgvEmpleados[3, poc].Value = Direccion;
            dgvEmpleados[4, poc].Value = Horastrabaja;
            dgvEmpleados[5, poc].Value = horasextra;
            dgvEmpleados[6, poc].Value = SueldoLiqui;
            btnGuar.Enabled = true;
            Limpiar();
        }

        private void txtHorasTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cbAfp_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceComboafp = cbAfp.SelectedIndex;
            IndiceCombo2medica = cbMedico.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor, valor2, porcen,porcenisapre, sueldobruto, SuledoLiquido, total;
            valor = Convert.ToDouble(txtHorasTra.Text);
            porcen = 0;
            valor2 = Convert.ToDouble(txtHorasExtra.Text);
            porcenisapre = 0;
            if (valor > 0 && valor2 == 0)
            {
                sueldobruto = (valor * 5000);
            }
            else if (valor > 0 && valor2 > 0)
            {
                sueldobruto = (valor * 5000) + (valor2 * 7000);
            }
            else
            {
                sueldobruto = 0;
                MessageBox.Show(" Valores mayor a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

            switch (indiceComboafp)//afp
            {
                case 0:
                    porcen = (valor * 7) / 100;// Afp
                    
                    break;
                case 1:
                    porcen = (valor * 9) / 100;
                    
                    break;
                case 2:
                    porcen = (valor * 12) / 100;
                    
                    break;
                case 3:
                    porcen = (valor * 13) / 100;
                    
                    break;

                
                    
            }
            switch (IndiceCombo2medica)//medica
            {
                case 0:
                    
                    porcenisapre = (valor2 * 12) / 100;// Medico
                    break;
                case 1:
                    
                    porcenisapre = (valor2 * 13) / 100;
                    break;
                case 2:
                    
                    porcenisapre = (valor2 * 14) / 100;
                    break;
                case 3:
                    
                    porcenisapre = (valor2 * 15) / 100;
                    break;



            }
            txtSueldoBru.Text = Convert.ToString(sueldobruto);
            SuledoLiquido = (sueldobruto - porcen - porcenisapre);
            txtSueldoLiqui.Text = SuledoLiquido.ToString();
        }
    }
}
