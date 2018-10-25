/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 25/09/2018
 * Hora: 11:06 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MibodegaOxxo
{
	/// <summary>
	/// Description of MibodegaVentanaPrincipal.
	/// </summary>
	public partial class MibodegaVentanaPrincipal : Form
	{
		public MibodegaVentanaPrincipal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			label5.Text=Program.usuario;
			label6.Text=Program.puesto;
			if(label6.Text=="Supervisor"){
				btnUsuarios.Enabled=true;
			}
			else{
				btnUsuarios.Enabled=false;
			}
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//Comandos para poder manejar el movimiento de la ventana
		[DllImport("user32.DLL",EntryPoint="ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL",EntryPoint="SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
		
		void BtnSlideClick(object sender, EventArgs e)
		{	//para manejar el menu vertical
			if(MenuVertical.Width==250){//Si el ancho del menu es = a 250
				MenuVertical.Width=78;//cambiar el arncho del menu y del panel de formularios
				panelContenedor.Width=1122;
			}
			else{//sino regresar a sus valores por defecto
				MenuVertical.Width=250;
				panelContenedor.Width=950;
			}
		}
		void IconoCerrarClick(object sender, EventArgs e)
		{
			Application.Exit();//cerrar la aplicacion (terminar)
		}
		void IconoMaximizarClick(object sender, EventArgs e)
		{	/*Para maximizar la ventana*/
			this.WindowState=FormWindowState.Maximized;
			iconoEstrechar.Visible=true;
			iconoMaximizar.Visible=false;
		}
		void IconoEstrecharClick(object sender, EventArgs e)
		{
			/*Para dejar normal el tamaño de la ventana*/
			this.WindowState=FormWindowState.Normal;
			iconoEstrechar.Visible=false;
			iconoMaximizar.Visible=true;
			
		}
		void IconoMinimizarClick(object sender, EventArgs e)
		{	//Para minimizar la ventana
			this.WindowState=FormWindowState.Minimized;
		}
		void BarraDeTituloMouseDown(object sender, MouseEventArgs e)
		{
			/*Al momento de seleccionar la barra de titulo de la ventana principal y sin dejar de apretar con el
			 * mouse se podra arrastrar la ventana con estas instrucciones*/
			ReleaseCapture();
			SendMessage(this.Handle,0x112,0xf012,0);
		}
		void Label3MouseDown(object sender, MouseEventArgs e)
		{
			/*Al momento de seleccionar la barra de titulo de la ventana principal y sin dejar de apretar con el
			 * mouse se podra arrastrar la ventana con estas instrucciones*/
			ReleaseCapture();
			SendMessage(this.Handle,0x112,0xf012,0);	
		}
		
		private void abrirInPanel(object formHijo){
			/*funcion para poder llamar un formulario hijo dentro de un formulario padre*/
			if(this.panelContenedor.Controls.Count>0){
				this.panelContenedor.Controls.RemoveAt(0);
			}
			Form fh=formHijo as Form; //creamos un formulario por defecto
			fh.TopLevel=false;//asignamos a la propiedad toplevel falso para que no aparesca arriba
			fh.Dock=DockStyle.Fill;//asignamos a la propiedad dock del formulario para rellenar el panel
			this.panelContenedor.Controls.Add(fh);//añadimos al panel el formulario hijo
			this.panelContenedor.Tag=fh;
			fh.Show();//que aparesca el formulario
		}
		
		void BtnVentasClick(object sender, EventArgs e)
		{
			abrirInPanel(new Ventas());
		}
		void BtnDepositosClick(object sender, EventArgs e)
		{
			abrirInPanel(new Depositos());
		}
		void BtnProductosClick(object sender, EventArgs e)
		{
			abrirInPanel(new Productos());
		}
		void BtnProveedoresClick(object sender, EventArgs e)
		{
			abrirInPanel(new Proveedores());
		}
		void BtnUsuariosClick(object sender, EventArgs e)
		{
			abrirInPanel(new Usuarios());
		}
		void HoraFechaTick(object sender, EventArgs e)
		{
			lblHora.Text=DateTime.Now.ToLongTimeString();
			lblFecha.Text=DateTime.Now.ToLongDateString();
		}
		void BarraDeTituloPaint(object sender, PaintEventArgs e)
		{
	
		}
	}
}
