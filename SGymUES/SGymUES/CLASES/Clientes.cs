using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGymUES.CLASES
{
	class Clientes
	{
		// ------------------------------------Validacion Email-----------------------------------------
		public Boolean ValidarEmail(String email)
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

		// ------------------------------------Validacion Campos Alumnos-----------------------------------------
		public bool ValidarCamposAlumons(ErrorProvider Error,TextBox FolioPago,TextBox Nombre,TextBox Edad,TextBox Expediente,TextBox Celular, TextBox Direccion, TextBox Estado, TextBox Municipio
			, TextBox Email, RadioButton EnfermedadSi, RadioButton EnfermedadNo, RadioButton CertificadoSi, RadioButton CertificadoNo, TextBox Enfermedad, ComboBox Carrera,PictureBox Imagen)
		{
			bool Ok = true;
			if (String.IsNullOrEmpty(FolioPago.Text))
			{
				Ok = false;
				Error.SetError(FolioPago, "Ingresa un folio de pago");
			}
			else
			{
				Ok = true;
				Error.SetError(FolioPago, "");
			}
			if (String.IsNullOrEmpty(Nombre.Text))
			{
				Ok = false;
				Error.SetError(Nombre, "Ingresa el nombre");
			}
			else
			{
				Ok = true;
				Error.SetError(Nombre, "");
			}
			if (String.IsNullOrEmpty(Edad.Text))
			{
				Ok = false;
				Error.SetError(Edad, "Ingresa la edad");
			}
			else
			{
				Ok = true;
				Error.SetError(Edad, "");
			}
			if (String.IsNullOrEmpty(Expediente.Text))
			{
				Ok = false;
				Error.SetError(Expediente, "Ingresa el n° de expediente");
			}
			else
			{
				Ok = true;
				Error.SetError(Expediente, "");
			}
			if (String.IsNullOrEmpty(Celular.Text))
			{
				Ok = false;
				Error.SetError(Celular, "Ingresa un numero celular");
			}
			else
			{
				Ok = true;
				Error.SetError(Celular, "");
			}
			if (String.IsNullOrEmpty(Direccion.Text))
			{
				Ok = false;
				Error.SetError(Direccion, "Ingresa la direccion");
			}
			else
			{
				Ok = true;
				Error.SetError(Direccion, "");
			}
			if (String.IsNullOrEmpty(Estado.Text))
			{
				Ok = false;
				Error.SetError(Estado, "Ingresa un estado");
			}
			else
			{
				Ok = true;
				Error.SetError(Estado, "");
			}
			if (String.IsNullOrEmpty(Municipio.Text))
			{
				Ok = false;
				Error.SetError(Municipio, "Ingresa una municipio");
			}
			else
			{
				Ok = true;
				Error.SetError(Municipio, "");
			}
			if (String.IsNullOrEmpty(Email.Text))
			{
				Ok = false;
				Error.SetError(Email, "Ingresa un correo electronico valido");
			}
			else
			{
				Ok = true;
			}
			if (EnfermedadNo.Checked == false && EnfermedadSi.Checked == false)
			{
				Ok = false;
				Error.SetError(EnfermedadSi, "Selecciona una opcion");

			}
			else
			{
				Ok = true;
				Error.SetError(EnfermedadSi, "");

			}
			if (EnfermedadSi.Checked && String.IsNullOrEmpty(Enfermedad.Text))
			{
				Ok = false;
				Error.SetError(Enfermedad, "Ingresa la enfermedad que padeece");
			}
			else
			{
				Ok = true;
				Error.SetError(Enfermedad, "");
			}
			if (CertificadoNo.Checked == false && CertificadoSi.Checked == false)
			{
				Ok = false;
				Error.SetError(CertificadoSi, "Selecciona una opcion");
			}
			else
			{
				Ok = true;
				Error.SetError(CertificadoSi, "");
			}
			if (Carrera.SelectedIndex == 0)
			{
				Ok = false;
				Error.SetError(Carrera, "Selecciona la carrera");
			}
			else
			{
				Ok = true;
				Error.SetError(Carrera, "");
			}
			if (Imagen.Image == null)
			{
				Ok = false;
				Error.SetError(Imagen, "Debes ingresar una foto");
			}
			else
			{
				Ok = true;
				Error.SetError(Imagen, "");
			}
			return Ok;
		}

		// ------------------------------------Validacion Campos Equipo Representativo-----------------------------------------
		public bool ValidarCamposER(ErrorProvider Error, TextBox Nombre, TextBox Edad, TextBox Expediente, TextBox Celular, TextBox Direccion, TextBox Estado, TextBox Municipio
			, TextBox Email, RadioButton EnfermedadSi, RadioButton EnfermedadNo, RadioButton CertificadoSi, RadioButton CertificadoNo, TextBox Enfermedad, ComboBox Carrera, PictureBox Imagen,
			ComboBox Deporte, ComboBox Entrenador)
		{
			bool Ok = true;
			
			if (String.IsNullOrEmpty(Nombre.Text))
			{
				Ok = false;
				Error.SetError(Nombre, "Ingresa el nombre");
			}
			else
			{
				Ok = true;
				Error.SetError(Nombre, "");
			}
			if (String.IsNullOrEmpty(Edad.Text))
			{
				Ok = false;
				Error.SetError(Edad, "Ingresa la edad");
			}
			else
			{
				Ok = true;
				Error.SetError(Edad, "");
			}
			if (String.IsNullOrEmpty(Expediente.Text))
			{
				Ok = false;
				Error.SetError(Expediente, "Ingresa el n° de expediente");
			}
			else
			{
				Ok = true;
				Error.SetError(Expediente, "");
			}
			if (String.IsNullOrEmpty(Celular.Text))
			{
				Ok = false;
				Error.SetError(Celular, "Ingresa un numero celular");
			}
			else
			{
				Ok = true;
				Error.SetError(Celular, "");
			}
			if (String.IsNullOrEmpty(Direccion.Text))
			{
				Ok = false;
				Error.SetError(Direccion, "Ingresa la direccion");
			}
			else
			{
				Ok = true;
				Error.SetError(Direccion, "");
			}
			if (String.IsNullOrEmpty(Estado.Text))
			{
				Ok = false;
				Error.SetError(Estado, "Ingresa un estado");
			}
			else
			{
				Ok = true;
				Error.SetError(Estado, "");
			}
			if (String.IsNullOrEmpty(Municipio.Text))
			{
				Ok = false;
				Error.SetError(Municipio, "Ingresa una municipio");
			}
			else
			{
				Ok = true;
				Error.SetError(Municipio, "");
			}
			if (String.IsNullOrEmpty(Email.Text))
			{
				Ok = false;
				Error.SetError(Email, "Ingresa un correo electronico valido");
			}
			else
			{
				Ok = true;
			}
			if (EnfermedadNo.Checked == false && EnfermedadSi.Checked == false)
			{
				Ok = false;
				Error.SetError(EnfermedadSi, "Selecciona una opcion");

			}
			else
			{
				Ok = true;
				Error.SetError(EnfermedadSi, "");

			}
			if (EnfermedadSi.Checked && String.IsNullOrEmpty(Enfermedad.Text))
			{
				Ok = false;
				Error.SetError(Enfermedad, "Ingresa la enfermedad que padece");
			}
			else
			{
				Ok = true;
				Error.SetError(Enfermedad, "");
			}
			if (CertificadoNo.Checked == false && CertificadoSi.Checked == false)
			{
				Ok = false;
				Error.SetError(CertificadoSi, "Selecciona una opcion");
			}
			else
			{
				Ok = true;
				Error.SetError(CertificadoSi, "");
			}
			if (Carrera.SelectedIndex == 0)
			{
				Ok = false;
				Error.SetError(Carrera, "Selecciona la carrera");
			}
			else
			{
				Ok = true;
				Error.SetError(Carrera, "");
			}
			if (Deporte.SelectedIndex == 0)
			{
				Ok = false;
				Error.SetError(Deporte, "Selecciona el deporte");
			}
			else
			{
				Ok = true;
				Error.SetError(Deporte, "");
			}
			if (Entrenador.SelectedIndex == 0)
			{
				Ok = false;
				Error.SetError(Entrenador, "Selecciona el entrenador");
			}
			else
			{
				Ok = true;
				Error.SetError(Entrenador, "");
			}
			if (Imagen.Image == null)
			{
				Ok = false;
				Error.SetError(Imagen, "Debes ingresar una foto");
			}
			else
			{
				Ok = true;
				Error.SetError(Imagen, "");
			}
			return Ok;
		}

		// ------------------------------------Validacion Campos Empleados-----------------------------------------
		public bool ValidarCamposEmpleados(ErrorProvider Error, TextBox Nombre, TextBox Edad, TextBox Empleado, TextBox Celular, TextBox Direccion, TextBox Estado, TextBox Municipio
					, TextBox Email, RadioButton EnfermedadSi, RadioButton EnfermedadNo, RadioButton CertificadoSi, RadioButton CertificadoNo, TextBox Enfermedad, ComboBox Area, PictureBox Imagen)
		{
			bool Ok = true;
			if (String.IsNullOrEmpty(Nombre.Text))
			{
				Ok = false;
				Error.SetError(Nombre, "Ingresa el nombre");
			}
			else
			{
				Ok = true;
				Error.SetError(Nombre, "");
			}
			if (String.IsNullOrEmpty(Edad.Text))
			{
				Ok = false;
				Error.SetError(Edad, "Ingresa la edad");
			}
			else
			{
				Ok = true;
				Error.SetError(Edad, "");
			}
			if (String.IsNullOrEmpty(Empleado.Text))
			{
				Ok = false;
				Error.SetError(Empleado, "Ingresa el n° de empleado");
			}
			else
			{
				Ok = true;
				Error.SetError(Empleado, "");
			}
			if (String.IsNullOrEmpty(Celular.Text))
			{
				Ok = false;
				Error.SetError(Celular, "Ingresa un numero celular");
			}
			else
			{
				Ok = true;
				Error.SetError(Celular, "");
			}
			if (String.IsNullOrEmpty(Direccion.Text))
			{
				Ok = false;
				Error.SetError(Direccion, "Ingresa la direccion");
			}
			else
			{
				Ok = true;
				Error.SetError(Direccion, "");
			}
			if (String.IsNullOrEmpty(Estado.Text))
			{
				Ok = false;
				Error.SetError(Estado, "Ingresa un estado");
			}
			else
			{
				Ok = true;
				Error.SetError(Estado, "");
			}
			if (String.IsNullOrEmpty(Municipio.Text))
			{
				Ok = false;
				Error.SetError(Municipio, "Ingresa una municipio");
			}
			else
			{
				Ok = true;
				Error.SetError(Municipio, "");
			}
			if (String.IsNullOrEmpty(Email.Text))
			{
				Ok = false;
				Error.SetError(Email, "Ingresa un correo electronico valido");
			}
			else
			{
				Ok = true;
			}
			if (EnfermedadNo.Checked == false && EnfermedadSi.Checked == false)
			{
				Ok = false;
				Error.SetError(EnfermedadSi, "Selecciona una opcion");

			}
			else
			{
				Ok = true;
				Error.SetError(EnfermedadSi, "");

			}
			if (EnfermedadSi.Checked && String.IsNullOrEmpty(Enfermedad.Text))
			{
				Ok = false;
				Error.SetError(Enfermedad, "Ingresa la enfermedad que padece");
			}
			else
			{
				Ok = true;
				Error.SetError(Enfermedad, "");
			}
			if (CertificadoNo.Checked == false && CertificadoSi.Checked == false)
			{
				Ok = false;
				Error.SetError(CertificadoSi, "Selecciona una opcion");
			}
			else
			{
				Ok = true;
				Error.SetError(CertificadoSi, "");
			}
			if (Area.SelectedIndex == 0)
			{
				Ok = false;
				Error.SetError(Area, "Selecciona el area");
			}
			else
			{
				Ok = true;
				Error.SetError(Area, "");
			}
			if (Imagen.Image == null)
			{
				Ok = false;
				Error.SetError(Imagen, "Debes ingresar una foto");
			}
			else
			{
				Ok = true;
				Error.SetError(Imagen, "");
			}
			return Ok;
		}

		// ------------------------------------LIMPIAR Campos Alumnos-----------------------------------------
		public void LimpiarCamposAlumons(ErrorProvider Error,TextBox FolioPago, TextBox Nombre, TextBox Edad, TextBox Expediente, TextBox Celular, TextBox Direccion, TextBox Estado, TextBox Municipio
			, TextBox Email, RadioButton EnfermedadSi, RadioButton EnfermedadNo, RadioButton CertificadoSi, RadioButton CertificadoNo, TextBox Enfermedad, ComboBox Carrera, PictureBox Imagen,PictureBox Add)
		{
			Error.Clear();
			FolioPago.Clear();
			Nombre.Clear();
			Edad.Clear();
			Expediente.Clear();
			Celular.Clear();
			Direccion.Clear();
			Estado.Clear();
			Municipio.Clear();
			Email.Clear();
			EnfermedadSi.Checked = false;
			EnfermedadNo.Checked = false;
			CertificadoSi.Checked = false;
			CertificadoNo.Checked = false;
			Enfermedad.Clear();
			Carrera.SelectedIndex = 0;
			Imagen.Image = null;
			Add.Visible = true ;
		}
		
		// ------------------------------------LIMPIAR Campos ER-----------------------------------------
		public void LimpiarCamposER(ErrorProvider Error, TextBox Nombre, TextBox Edad, TextBox Expediente, TextBox Celular, TextBox Direccion, TextBox Estado, TextBox Municipio
			, TextBox Email, RadioButton EnfermedadSi, RadioButton EnfermedadNo, RadioButton CertificadoSi, RadioButton CertificadoNo, TextBox Enfermedad, ComboBox Carrera, PictureBox Imagen,
			ComboBox Deporte, ComboBox Entrenador, PictureBox Add)
		{
			Error.Clear();
			Nombre.Clear();
			Edad.Clear();
			Expediente.Clear();
			Celular.Clear();
			Direccion.Clear();
			Estado.Clear();
			Municipio.Clear();
			Email.Clear();
			EnfermedadSi.Checked = false;
			EnfermedadNo.Checked = false;
			CertificadoSi.Checked = false;
			CertificadoNo.Checked = false;
			Enfermedad.Clear();
			Carrera.SelectedIndex = 0;
			Imagen.Image = null;
			Deporte.SelectedIndex = 0;
			Entrenador.SelectedIndex = 0;
			Add.Visible = true;
		}

		//------------------------------------------------------Limpiar Campos Empleados --------------------------------------------------------
		public void LimpiarCamposEmpleados(ErrorProvider Error, TextBox Nombre, TextBox Edad, TextBox Empleado, TextBox Celular, TextBox Direccion, TextBox Estado, TextBox Municipio
					, TextBox Email, RadioButton EnfermedadSi, RadioButton EnfermedadNo, RadioButton CertificadoSi, RadioButton CertificadoNo, TextBox Enfermedad, ComboBox Area, PictureBox Imagen, PictureBox Add)
		{
			Error.Clear();
			Nombre.Clear();
			Edad.Clear();
			Empleado.Clear();
			Celular.Clear();
			Direccion.Clear();
			Estado.Clear();
			Municipio.Clear();
			Email.Clear();
			EnfermedadSi.Checked = false;
			EnfermedadNo.Checked = false;
			CertificadoSi.Checked = false;
			CertificadoNo.Checked = false;
			Enfermedad.Clear();
			Area.SelectedIndex = 0;
			Imagen.Image = null;
			Add.Visible = true;
		}
	}
}
