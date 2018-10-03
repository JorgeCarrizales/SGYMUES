using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGymUES.VISTAS.Clientes
{
    public partial class CRUD_Cliente : Form
    {
        public CRUD_Cliente()
        {
            InitializeComponent();
        }
		#region
		//funcion para poder arrastrar formulario
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
		//Fin Función Arrastrar
		#endregion
		private void CRUD_Cliente_Load(object sender, EventArgs e)
		{
			cmbTipoUsuario.SelectedIndex = 0;
			gbEditAl.Visible = false;
			gbEditEmpleado.Visible = false;
			gbEditER.Visible = false;

		}

		private void btnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Header_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
	}
}
