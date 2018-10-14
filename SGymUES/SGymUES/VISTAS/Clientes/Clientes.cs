using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
		CLASES.Clientes ClasesClientes = new CLASES.Clientes();
		private void Clientes_Load(object sender, EventArgs e)
		{
			gbEmpleado.Visible = false;
			gbEquipoR.Visible = false;
			gbClientes.Visible = false;
			cmbTipoUsuario.SelectedIndex = 0;
			cmbArea.SelectedIndex = 0;
			cmbCarreraER.SelectedIndex = 0;
			cmbCarreraAl.SelectedIndex = 0;
			cmbEntrenador.SelectedIndex = 0;
			cmbDeporte.SelectedIndex = 0;
			dtpInicioAl.Value = DateTime.Now;
			dtpVencimientoAl.Value = DateTime.Now.AddDays(30);
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
			if (MessageBox.Show("a", "b", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
			else if (cmbTipoUsuario.SelectedItem.ToString() == "    ----Selecciona----")
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
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (gbClientes.Visible == true)
			{
				ClasesClientes.ValidarCamposAlumons(ErrorAl, txtFolioPago, txtNombreAl, txtEdadAl, txtExpedienteAl, txtCelularAl, txtDireccionAl, txtEstadoAl, txtMunicipioAl, txtEmailAl, rbEnferAlSi, rbEnferAlNo, rbMedicoAlSi, rbMedicoAlNo, txtEnfermedadAl, cmbCarreraAl, cmbSexoAl,pbFotoAl);
				if (ClasesClientes.ValidarEmail(txtEmailAl.Text) == true)
				{
					rbEnferAlNo.Checked = false;
					rbEnferAlSi.Checked = false;
					txtEnfermedadAl.Enabled = false;
					ErrorAl.SetError(txtEmailAl, "");
				}
				else
				{
					ErrorAl.SetError(txtEmailAl, "Ingresa un correo valido");
				}

			}
			else if (gbEmpleado.Visible == true)
			{
				ClasesClientes.ValidarCamposEmpleados(ErrorAl, txtNombreEM, txtEdadEM, txtNEmpleado, txtCelEM, txtDireccionEM, txtEstadoEM, txtMunicipioEM, txtEmailEM, rbEnferEMSi, rbEnferEMNo, rbMedEMSi, rbMedEMNo, txtEnfermedadEM, cmbArea, cmbSexoEM,pbFotoEM);
				if (ClasesClientes.ValidarEmail(txtEmailEM.Text) == true)
				{
					rbEnferEMNo.Checked = false;
					rbEnferEMSi.Checked = false;
					txtEnfermedadEM.Enabled = false;
					ErrorAl.SetError(txtEmailEM, "");
				}
				else
				{
					ErrorAl.SetError(txtEmailEM, "Ingresa un correo valido");
				}

			}
			else if (gbEquipoR.Visible == true)
			{
				ClasesClientes.ValidarCamposER(ErrorAl, txtNombreER, txtEdadER, txtExpedienteER, txtCelER, txtDireccionER, txtEstadoER, txtMunicipioER, txtEmailER, rbEnferERSi, rbEnferERNo, rbMedERSi, rbMedERNo, txtEnfermedadER, cmbCarreraER, cmbSexoER, pbER, cmbDeporte, cmbEntrenador);
				if (ClasesClientes.ValidarEmail(txtEmailER.Text) == true)
				{
					rbEnferERNo.Checked = false;
					rbEnferERSi.Checked = false;
					txtEnfermedadER.Enabled = false;
					ErrorAl.SetError(txtEmailER, "");
				}
				else
				{
					ErrorAl.SetError(txtEmailER, "Ingresa un correo valido");
				}

			}

		}

		private void gbEnfermedadesAl_Enter(object sender, EventArgs e)
		{

		}

		private void txtEnfermedadAl_TextChanged(object sender, EventArgs e)
		{

		}

		private void rbEnferAlSi_CheckedChanged(object sender, EventArgs e)
		{

			txtEnfermedadAl.Enabled = true;
		}

		private void rbEnferAlNo_CheckedChanged(object sender, EventArgs e)
		{
			txtEnfermedadAl.Enabled = false;
		}

		private void txtExpedienteAl_TextChanged(object sender, EventArgs e)
		{

		}

		private void dtpInicioAl_ValueChanged(object sender, EventArgs e)
		{

		}

		private void AddFoto_Click(object sender, EventArgs e)
		{
			//Creacion de objeto para abrir archivos
			OpenFileDialog Open = new OpenFileDialog();
			//Realizamos un filtro para los tipo de imagenes que se permitiran introducir
			Open.Filter = "Archivos JPEG(*.jpg)|*.jpg | PNG(*.png)|*.png";
			//Se inicia el directorio inicial donde se buscará la imagen
			//Open.InitialDirectory = "C:/desktop";
			if (Open.ShowDialog() == DialogResult.OK)
			{
				//Guardamos la direccion del archivo en una variable
				String Dir = Open.FileName;
				//transformamos la imagen en un mapa de bits
				Bitmap Picture = new Bitmap(Dir);
				//Se almacena la imagen en el picture box
				pbFotoAl.Image = (Image)Picture;
			}
			if (pbFotoAl.Image == null)
			{
				AddFoto.Visible = true;
			}
			else
			{
				AddFoto.Visible = false;
			}
		}
		//Foto Equipo Representativo
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			//Creacion de objeto para abrir archivos
			OpenFileDialog Open = new OpenFileDialog();
			//Realizamos un filtro para los tipo de imagenes que se permitiran introducir
			Open.Filter = "Archivos JPEG(*.jpg)|*.jpg | PNG(*.png)|*.png";
			//Se inicia el directorio inicial donde se buscará la imagen
			//Open.InitialDirectory = "C:/desktop";
			if (Open.ShowDialog() == DialogResult.OK)
			{
				//Guardamos la direccion del archivo en una variable
				String Dir = Open.FileName;
				//transformamos la imagen en un mapa de bits
				Bitmap Picture = new Bitmap(Dir);
				//Se almacena la imagen en el picture box
				pbER.Image = (Image)Picture;
			}
			if (pbER.Image == null)
			{
				AddFotoER.Visible = true;
			}
			else
			{
				AddFotoER.Visible = false;
			}
		}

		private void AddFotoEM_Click(object sender, EventArgs e)
		{
			//Creacion de objeto para abrir archivos
			OpenFileDialog Open = new OpenFileDialog();
			//Realizamos un filtro para los tipo de imagenes que se permitiran introducir
			Open.Filter = "Archivos JPEG(*.jpg)|*.jpg | PNG(*.png)|*.png";
			//Se inicia el directorio inicial donde se buscará la imagen
			//Open.InitialDirectory = "C:/desktop";
			if (Open.ShowDialog() == DialogResult.OK)
			{
				//Guardamos la direccion del archivo en una variable
				String Dir = Open.FileName;
				//transformamos la imagen en un mapa de bits
				Bitmap Picture = new Bitmap(Dir);
				//Se almacena la imagen en el picture box
				pbFotoEM.Image = (Image)Picture;
			}
			if (pbFotoEM.Image == null)
			{
				AddFotoEM.Visible = true;
			}
			else
			{
				AddFotoEM.Visible = false;
			}
		}

		private void txtEnfermedadEM_TextChanged(object sender, EventArgs e)
		{
			if (rbEnferEMSi.Checked == true)
			{
				txtEnfermedadEM.Enabled = true;
			}
			else
			{
				txtEnfermedadEM.Enabled = false;
			}
		}

		private void txtEnfermedadER_TextChanged(object sender, EventArgs e)
		{

		}

		private void rbMedERSi_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void rbMedERNo_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void rbEnferERSi_CheckedChanged(object sender, EventArgs e)
		{
			txtEnfermedadER.Enabled = true;
		}

		private void rbEnferERNo_CheckedChanged(object sender, EventArgs e)
		{
			txtEnfermedadER.Enabled = false;
		}

		private void rbEnferEMSi_CheckedChanged(object sender, EventArgs e)
		{
			txtEnfermedadEM.Enabled = true;
		}

		private void rbEnferEMNo_CheckedChanged(object sender, EventArgs e)
		{
			txtEnfermedadEM.Enabled = false;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			if (gbClientes.Visible == true)
			{
				ClasesClientes.LimpiarCamposAlumons(ErrorAl, txtFolioPago, txtNombreAl, txtEdadAl, txtExpedienteAl, txtCelularAl, txtDireccionAl, txtEstadoAl, txtMunicipioAl, txtEmailAl,
					rbEnferAlSi, rbEnferAlNo, rbMedicoAlSi, rbMedicoAlNo, txtEnfermedadAl, cmbCarreraAl,cmbSexoAl, pbFotoAl, AddFoto);
			}
			else if (gbEmpleado.Visible == true)
			{
				ClasesClientes.LimpiarCamposEmpleados(ErrorAl,txtNombreEM,txtEdadEM,txtNEmpleado,txtCelEM,txtDireccionEM,txtEstadoEM,txtMunicipioEM,txtEmailEM,rbEnferEMSi,rbEnferEMNo,
					rbMedEMSi,rbMedEMNo,txtEnfermedadEM,cmbArea,cmbSexoEM,pbFotoEM,AddFotoEM);
			}
			else if (gbEquipoR.Visible == true)
			{
				ClasesClientes.LimpiarCamposER(ErrorAl, txtNombreER, txtEdadER, txtExpedienteER, txtCelER,txtDireccionER,txtEstadoER,txtMunicipioER,txtEmailER,rbEnferERSi,rbEnferERNo,
					rbMedERSi,rbMedERNo,txtEnfermedadER,cmbCarreraER,cmbSexoER,pbER,cmbDeporte,cmbEntrenador,AddFotoER);

			}
		}
	}
}
