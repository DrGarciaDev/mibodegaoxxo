/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Modificado por Luis García
 * FECHA DE MODIFICACIÓN 27/10/2018
 * Fecha: 05/10/2018
 * Hora: 01:37 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace MibodegaOxxo
{
	/// <summary>
	/// Description of Proveedores.
	/// </summary>
	public partial class Proveedores : Form
	{
		public Proveedores()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			if(Program.puesto=="Supervisor"||Program.puesto=="Comisionista"){
				btnConsultarProveedor.Enabled=true;
			}
			else{
				btnConsultarProveedor.Enabled=false;
			}
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
	
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
		void BtnRegistrarProductoClick(object sender, EventArgs e)
		{
			abrirInPanel(new RegistrarProveedor());
		}
		void Button1Click(object sender, EventArgs e)
		{
			abrirInPanel(new MostrarProveedores());
		}
		void BtnConsultarProveedorClick(object sender, EventArgs e)
		{
			abrirInPanel(new ConsultarProveedor());
		}
		
	}
	
	public class Proveedor{
		public int IdProveedor {get; set;}
		public string nombre {get; set;}
		public string apellidoPaterno {get; set;}
		public string apellidoMaterno {get; set;}
		public string nombreEmpresa{get; set;}
		public string RFC{get; set;}
		public string telefono{get; set;}
		public string correo{get; set;}
		
		public Proveedor(){}
		
		public Proveedor(int pIdProveedor, string pNombre, string pApellidoPaterno, 
		                 string pApellidoMaterno, string pNombreEmpresa,
		                 string pRFC, string pTelefono, string pCorreo){
			this.IdProveedor		= pIdProveedor;
			this.nombre				= pNombre;
			this.apellidoPaterno	= pApellidoPaterno;
			this.apellidoMaterno	= pApellidoMaterno;
			this.nombreEmpresa		= pNombreEmpresa;
			this.RFC				= pRFC;
			this.telefono			= pTelefono;
			this.correo				= pCorreo;
		}
	}
	
	class ProveedorDAL{
		
		public static int Agregar(Proveedor pProveedor){
			int retornar = 0;
			MySqlCommand comando = new MySqlCommand(string.Format("insert into proveedor(nombre, apellidoPaterno, apellidoMaterno, nombreEmpresa, rfcEmpresa, telefono, correo)  values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
			 pProveedor.nombre, pProveedor.apellidoPaterno, pProveedor.apellidoMaterno, pProveedor.nombreEmpresa, pProveedor.RFC, pProveedor.telefono, pProveedor.correo), BDcomun.ObtenerConexion() );
			
			retornar = comando.ExecuteNonQuery();
			return retornar;
		}
		
		//La clase LIST viene de la libreria Using System.collections.generic
		public static List<Proveedor> Mostrar(){
			List<Proveedor> lista = new List<Proveedor>();
			
			MySqlCommand comado = new MySqlCommand(string.Format("select * from proveedor;"),BDcomun.ObtenerConexion());
			MySqlDataReader leer = comado.ExecuteReader();
			
			while(leer.Read()){
				Proveedor Objeto_Proveedor = new Proveedor();
				
				Objeto_Proveedor.IdProveedor		= leer.GetInt32(0);
				Objeto_Proveedor.nombre				= leer.GetString(1);
				Objeto_Proveedor.apellidoPaterno	= leer.GetString(2);
				Objeto_Proveedor.apellidoMaterno	= leer.GetString(3);
				Objeto_Proveedor.nombreEmpresa		= leer.GetString(4);
				Objeto_Proveedor.RFC				= leer.GetString(5);
				Objeto_Proveedor.telefono			= leer.GetString(6);
				Objeto_Proveedor.correo				= leer.GetString(7);				
				
				lista.Add(Objeto_Proveedor);
			}
			return lista;
		}
		
		public static List<Proveedor> Buscar(string pNombre, string pRfc){
			List<Proveedor> lista = new List<Proveedor>();
			
			MySqlCommand comando = new MySqlCommand(string.Format("select * from proveedor where nombre = '{0}' or rfcEmpresa='{1}'",pNombre,pRfc),BDcomun.ObtenerConexion());
			MySqlDataReader leer = comando.ExecuteReader();
			
			while(leer.Read()){
				
				Proveedor Objeto_Proveedor = new Proveedor();
				
				Objeto_Proveedor.IdProveedor		= leer.GetInt32(0);
				Objeto_Proveedor.nombre				= leer.GetString(1);
				Objeto_Proveedor.apellidoPaterno	= leer.GetString(2);
				Objeto_Proveedor.apellidoMaterno	= leer.GetString(3);
				Objeto_Proveedor.nombreEmpresa		= leer.GetString(4);
				Objeto_Proveedor.RFC				= leer.GetString(5);
				Objeto_Proveedor.telefono			= leer.GetString(6);
				Objeto_Proveedor.correo				= leer.GetString(7);
				
				lista.Add(Objeto_Proveedor);
				
			}
			
			return lista;
		}
		
		public static Proveedor ObtenerProveedor(int pIdProveedor){
			Proveedor Objeto_Proveedor = new Proveedor();
			MySqlConnection conexion = BDcomun.ObtenerConexion();
			
			MySqlCommand comando = new MySqlCommand(string.Format("select * from proveedor where idProveedor = {0}",pIdProveedor),conexion);
			MySqlDataReader leer = comando.ExecuteReader();
			
			if(leer.Read()){
				Objeto_Proveedor.IdProveedor		= leer.GetInt32(0);
				Objeto_Proveedor.nombre				= leer.GetString(1);
				Objeto_Proveedor.apellidoPaterno	= leer.GetString(2);
				Objeto_Proveedor.apellidoMaterno	= leer.GetString(3);
				Objeto_Proveedor.nombreEmpresa		= leer.GetString(4);
				Objeto_Proveedor.RFC				= leer.GetString(5);
				Objeto_Proveedor.telefono			= leer.GetString(6);
				Objeto_Proveedor.correo				= leer.GetString(7);
			}
			else{
				MessageBox.Show("No se encuentra ningun proveedor con ese id unico","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
			
			conexion.Close();
			return Objeto_Proveedor;
		}
		
		public static int Actualizar(Proveedor pProveedor){
			int retorno = 0;
			
			MySqlConnection conexion = BDcomun.ObtenerConexion();
			
			MySqlCommand comando = new MySqlCommand(string.Format("Update proveedor set nombre='{0}', apellidoPaterno = '{1}', apellidoMaterno = '{2}', nombreEmpresa = '{3}', rfcEmpresa = '{4}', telefono = '{5}', correo = '{6}' where idProveedor = {7}",
			                                                     pProveedor.nombre, pProveedor.apellidoPaterno, pProveedor.apellidoMaterno, pProveedor.nombreEmpresa, pProveedor.RFC, pProveedor.telefono, pProveedor.correo, pProveedor.IdProveedor),conexion);
			
			retorno = comando.ExecuteNonQuery();
			conexion.Close();
			return retorno;
		}
		
		public static int Eliminar(int pId){
			int retorno = 0;
			MySqlConnection conexion = BDcomun.ObtenerConexion();
			MySqlCommand comando = new MySqlCommand(string.Format("Delete from proveedor where idProveedor = {0}",pId),conexion);
			retorno = comando.ExecuteNonQuery();
			conexion.Close();
			return retorno;
		}
	}
}
