/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 05/10/2018
 * Hora: 01:52 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MibodegaOxxo
{
	/// <summary>
	/// Description of Usuarios.
	/// </summary>
	public partial class Usuarios : Form
	{
		public Usuarios()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnCerrarClick(object sender, EventArgs e)
		{
			this.Close();
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
		void BtnRegistrarUsuarioClick(object sender, EventArgs e)
		{
			abrirInPanel(new RegistrarUsuario());
		}
		void BtnMostrarUsuariosClick(object sender, EventArgs e)
		{
			abrirInPanel(new MostrarUsuarios());
		}
		void BtnConsultarUsuarioClick(object sender, EventArgs e)
		{
			abrirInPanel(new ConsultarUsuario());
		}
		
		
	}
	
	class Usuario{
		public int IdUsuario {get; set;}
		public string nombre {get; set;}
		public string apellidoPaterno {get; set;}
		public string apellidoMaterno {get; set;}
		public string fechaNacimiento {get; set;}
		public string correo {get; set;}
		public int telefono {get; set;}
		public string contraseña {get; set;}
		public string puesto {get; set;}
		
		public Usuario(){ }
		
		public Usuario(int pId, string pNombre, string pApellidoPaterno, string pApellidoMaterno, string pFechaNacimineto,
		               string pCorreo, int pTelefono, string pContraseña, string pPuesto){
			this.IdUsuario=pId;
			this.nombre=pNombre;
			this.apellidoPaterno=pApellidoPaterno;
			this.apellidoMaterno=pApellidoMaterno;
			this.fechaNacimiento=pFechaNacimineto;
			this.correo=pCorreo;
			this.telefono=pTelefono;
			this.contraseña=pContraseña;
			this.puesto=pPuesto;
		}
	}
	
	class UsuariosDAL{
		//Insertar Usuario
		public static int Agregar(Usuario pUsuario){
			int retornar=0;
			MySqlCommand comando=new MySqlCommand(string.Format("insert into usuario(nombre,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,telefono,contraseña,puesto) values ('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}')",
			                                                    pUsuario.nombre,pUsuario.apellidoPaterno,pUsuario.apellidoMaterno,pUsuario.fechaNacimiento,pUsuario.correo,pUsuario.telefono,pUsuario.contraseña,pUsuario.puesto),BDcomun.ObtenerConexion());
			
			retornar=comando.ExecuteNonQuery();
			return retornar;
		}
		
		
	}
}
