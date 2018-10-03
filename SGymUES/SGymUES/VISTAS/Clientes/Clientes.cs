using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGymUES.VISTAS.Clientes
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
			gbEmpleado.Visible = false;
			gbEquipoR.Visible = false;
			gbClientes.Visible = false;
			cmbTipoUsuario.SelectedIndex = 0;
			cmbArea.SelectedIndex = 0;
			cmbCarrera.SelectedIndex = 0;
			cmbCarreraAl.SelectedIndex = 0;
			cmbEntrenador.SelectedIndex = 0;
		}
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
			if (MessageBox.Show("", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Close();
			}           
        }

        private void lblCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void gbClientes_Enter(object sender, EventArgs e)
		{

		}

		private void lblFechaInicial_Click(object sender, EventArgs e)
		{

		}

		private void lblEdadAl_Click(object sender, EventArgs e)
		{

		}

		private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbTipoUsuario.SelectedItem.ToString() == "Alumno")
			{
				gbEmpleado.Visible = false;
				gbEquipoR.Visible = false;
				gbClientes.Visible = true;
			}
			else if (cmbTipoUsuario.SelectedItem.ToString() == "Empleado")
			{
				gbEmpleado.Visible = true;
				gbEquipoR.Visible = false;
				gbClientes.Visible = false;
			}
			else if (cmbTipoUsuario.SelectedItem.ToString() == "Equipo Representativo")
			{
				gbEmpleado.Visible = false;
				gbEquipoR.Visible = true;
				gbClientes.Visible = false;
			}
			else if (cmbTipoUsuario.SelectedItem.ToString()== "    ----Selecciona----")
			{
				gbEmpleado.Visible = false;
				gbEquipoR.Visible = false;
				gbClientes.Visible = false;
			}
		}

		private void btnListado_Click(object sender, EventArgs e)
		{

			CRUD_Cliente Lista = new CRUD_Cliente();
			Lista.Show();
		}
		//Validar formato de correo electronico
		#region
		private Boolean ValidarEmail(String email)
		{
			String expresion;
			expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
			if (Regex.IsMatch(email, expresion))
			{
				if (Regex.Replace(email, expresion, String.Empty).Length == 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}
		}
		#endregion
		//Validacion solo numeros para textbox
		#region 
		private void txtEdadEM_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
			else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
			else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
			else { e.Handled = true; }
		}

		private void txtCelEM_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
			else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
			else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
			else { e.Handled = true; }
		}

		private void txtEdadER_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
			else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
			else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
			else { e.Handled = true; }
		}

		private void txtCelER_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
			else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
			else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
			else { e.Handled = true; }
		}

		private void txtFolioPago_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
			else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
			else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
			else { e.Handled = true; }
		}

		private void txtEdadAl_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
			else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
			else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
			else { e.Handled = true; }
		}

		private void txtExpedienteAl_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
			else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
			else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
			else { e.Handled = true; }
		}

		private void txtCelularAl_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
			else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
			else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
			else { e.Handled = true; }
		}

		private void txtExpedienteER_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
			else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
			else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
			else { e.Handled = true; }
		}
		#endregion
		//Validacion solo letras textbox
		#region
		private void txtNombreEM_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsSeparator(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void txtDireccionEM_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}

		private void txtEstadoEM_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsSeparator(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void txtMunicipioEM_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsSeparator(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void txtNombreER_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsSeparator(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void txtEstadoER_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsSeparator(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void txtMunicipioER_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsSeparator(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsSeparator(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsSeparator(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void txtNombreAl_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsSeparator(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void txtEstadoAl_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsSeparator(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void txtMunicipioAl_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsSeparator(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void txtEnfermedadAl_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsSeparator(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}
		#endregion
		//Validacion de campos vacios
		#region
		private bool validarCampos()
		{
			bool Ok = true;
			if (String.IsNullOrEmpty(txtFolioPago.Text))
			{
				Ok = false;
				ErrorAl.SetError(txtFolioPago, "Ingresa un folio de pago"); }
			else if (String.IsNullOrEmpty(txtNombreAl.Text)) {
				ErrorAl.SetError(txtNombreAl, "Ingresa el nombre");
			} else if (String.IsNullOrEmpty(txtEdadAl.Text)) {
				ErrorAl.SetError(txtEdadAl, "Ingresa la edad");
			} else if (String.IsNullOrEmpty(txtExpedienteAl.Text)) {
				ErrorAl.SetError(txtExpedienteAl, "Ingresa el expediente");
			} else if (String.IsNullOrEmpty(txtCelularAl.Text)) {
				ErrorAl.SetError(txtCelularAl, "Ingrea un número celular");
			} else if (String.IsNullOrEmpty(txtDireccionAl.Text)) {
				ErrorAl.SetError(txtDireccionAl, "Ingresa la dirección");
			} else if (String.IsNullOrEmpty(txtEstadoAl.Text)) {
				ErrorAl.SetError(txtEstadoAl, "Ingresa el estado");
			} else if (String.IsNullOrEmpty(txtMunicipioAl.Text)) {
				ErrorAl.SetError(txtMunicipioAl, "Ingresa el municipio");
			} else if (String.IsNullOrEmpty(txtEmailAl.Text)) {
				ErrorAl.SetError(txtEmailAl, "Ingresa un email");
			} else if (rbEnferAlSi.Checked == false && rbEnferAlNo.Checked == false)
			{
				ErrorAl.SetError(rbEnferAlNo, "Debes seleccionar una opción");
			}
			else if (rbMedicoAlNo.Checked == false && rbMedicoAlSi.Checked == false) {
				ErrorAl.SetError(rbMedicoAlSi, "Debes seleccionar una opción");
			} else if (rbEnferAlSi.Checked == true && String.IsNullOrEmpty(txtEnfermedadAl.Text))
			{
				ErrorAl.SetError(txtEnfermedadAl, "Indique la enfermedad");
			}
			else
			{
				ErrorAl.SetError(txtFolioPago, "");
				ErrorAl.SetError(txtNombreAl, "");
				ErrorAl.SetError(txtEdadAl, "");
				ErrorAl.SetError(txtExpedienteAl, "");
				ErrorAl.SetError(txtCelularAl, "");
				ErrorAl.SetError(txtDireccionAl, "");
				ErrorAl.SetError(txtEstadoAl, "");
				ErrorAl.SetError(txtMunicipioAl, "");
				ErrorAl.SetError(txtEmailAl, "");
				ErrorAl.SetError(rbEnferAlNo, "");
				ErrorAl.SetError(txtEnfermedadAl, "");
				ErrorAl.SetError(rbMedicoAlSi, "");
			}
			return Ok;
		}
		#endregion
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (gbClientes.Visible == true) {
				if (ValidarEmail(txtEmailAl.Text) == true)
				{

				}
				else
				{
					txtEmailAl.Text="asda";
				}	
			} else if (gbEmpleado.Visible == true) {
				if (ValidarEmail(txtEmailEM.Text) == true)
				{

				}
				else
				{
					txtEmailEM.Text="Formato incorrecto";
				}
				
			} else if (gbEquipoR.Visible==true) {
				if (ValidarEmail(txtEmailER.Text) == true)
				{

				}
				else
				{
					txtEmailER.Text="asda";
				}
						
			}
			validarCampos();
		}
	}
}
