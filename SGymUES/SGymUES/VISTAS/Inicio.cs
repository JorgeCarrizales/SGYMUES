using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SGymUES
{
    public partial class Form1 : Form
    {
		public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
        #region Funcionalidades del formulario
        //Funcion para poder arrastrar el formulario desde la barra superior
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //-----------------------------Fin funcion para arrastrar formulario -----------------------------------
        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        //Funcion para permitir mover formulario desde la barra de arriba
        private void Header_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Funcion de cambio de tamaño de barra lateral
        private void btnBar_Click_1(object sender, EventArgs e)
        {
            ////Efecto de minimizado de barra lateral
            if (Dashboard.Width == 250)
            {
                Dashboard.Width = 60;
                lblNombre.Visible = false;
                lblCargo.Visible = false;
                lblCerrarSesion.Visible = false;
            }
            else
            {
                Dashboard.Width = 250;
                lblNombre.Visible = true;
                lblCargo.Visible = true;
                lblCerrarSesion.Visible = true;
            }
        }
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //---------------------------Fin botones -----------------------------------
        //Funcion para abrir formularios dentro del panel 
        private void OpenFormInPanel<MyForm>() where MyForm : Form, new()
        {
            Form Formulario;
            Formulario = Body.Controls.OfType<MyForm>().FirstOrDefault();//Busca en la coleccion el formulario
            //Si el formulario/instancia no existe
            if (Formulario == null)
            {
                Formulario = new MyForm();
                Formulario.TopLevel = false;
                Formulario.Dock = DockStyle.Fill;
                Body.Controls.Add(Formulario);
                Body.Tag = Formulario;
                Formulario.Show();
                Formulario.BringToFront();
                //Funcion para validar y cambiar color de boton mientras se tiene abierto un formulario
                Formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }//Si el formulario/Instancia existe
            else
            {
                Formulario.BringToFront();
            }
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            //OpenFormInPanel<SGymUES.VISTAS.Ajustes.Ajustes>();
            btnClientes.BackColor = Color.DarkRed;
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Funcion para validar y cambiar color de boton mientras se tiene abierto un formulario
        private void CloseForms(Object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Clientes"] == null)
            {
                btnClientes.BackColor = Color.Brown;
            }
            if (Application.OpenForms["Ajustes"] == null)
            {
                btnClientes.BackColor = Color.Brown;
            }
        }

		//Contador para mostrar la hora actual
		private void TimerHora_Tick(object sender, EventArgs e)
		{
			lblHora.Text = DateTime.Now.ToLongTimeString();
			lblFecha.Text = DateTime.Now.ToLongDateString();
		}
		#endregion

		private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenFormInPanel<SGymUES.VISTAS.Clientes.Clientes>();
            btnClientes.BackColor = Color.DarkRed;
        }

        private void Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

		private void Header_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
