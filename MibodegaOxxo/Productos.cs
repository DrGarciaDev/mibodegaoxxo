/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 05/10/2018
 * Hora: 01:21 p. m.
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
	/// Description of Productos.
	/// </summary>
	public partial class Productos : Form
	{
		public Productos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
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
		
		void BtnCerrarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnRegistrarProductoClick(object sender, EventArgs e)
		{
			abrirInPanel(new RegistrarProducto());
		}
		void BtnMostrarProductosClick(object sender, EventArgs e)
		{
			abrirInPanel(new MotrarProductos());
		}
		void BtnConsultarProductoClick(object sender, EventArgs e)
		{
			abrirInPanel(new ConsultarProductos());
		}
	}
	
	public class Producto{
		public int codigoIdProducto {get; set;}
		public string descripcion {get; set;}
		public int precio {get; set;}
		public string fechaCaducidad {get; set;}
		public int existencia{get; set;}
		
		public Producto(){}
		
		public Producto(int pCodigoIdProducto, string pDescripcion, int pPrecio, string pFechaCaducidad, int pExistencia){
			this.codigoIdProducto=pCodigoIdProducto;
			this.descripcion=pDescripcion;
			this.precio=pPrecio;
			this.fechaCaducidad=pFechaCaducidad;
			this.existencia=pExistencia;
		}
	}
	
	class ProductoDAL{
		public static int Agregar(Producto pProducto){
			int retornar=0;
			MySqlCommand comando=new MySqlCommand(string.Format("insert into producto(codigoIdProducto,descripcion,precio,fechaCaducidad,existencia)  values ({0},'{1}',{2},'{3}',{4})",
			                                                    pProducto.codigoIdProducto,pProducto.descripcion,pProducto.precio,pProducto.fechaCaducidad,pProducto.existencia),BDcomun.ObtenerConexion());
			
			retornar=comando.ExecuteNonQuery();
			return retornar;
		}
		
		//La clase LIST viene de la libreria Using System.collections.generic
		public static List<Producto> Mostrar(){
			List<Producto> lista = new List<Producto>();
			
			MySqlCommand comado = new MySqlCommand(string.Format("select * from producto;"),BDcomun.ObtenerConexion());
			MySqlDataReader leer = comado.ExecuteReader();
			
			while(leer.Read()){
				Producto pProducto=new Producto();
				pProducto.codigoIdProducto=leer.GetInt32(0);
				pProducto.descripcion=leer.GetString(1);
				pProducto.precio=leer.GetInt32(2);
				pProducto.fechaCaducidad=leer.GetString(3);
				pProducto.existencia=leer.GetInt32(4);
				
				lista.Add(pProducto);
			}
			return lista;
		}
		
		public static List<Producto> Buscar(int pCodigo, string pDescripcion){
			List<Producto> lista=new List<Producto>();
			
			MySqlCommand comando = new MySqlCommand(string.Format("select * from producto where codigoIdProducto = {0} or descripcion='{1}'",pCodigo,pDescripcion),BDcomun.ObtenerConexion());
			MySqlDataReader leer = comando.ExecuteReader();
			
			while(leer.Read()){
				Producto pProducto=new Producto();
				pProducto.codigoIdProducto=leer.GetInt32(0);
				pProducto.descripcion=leer.GetString(1);
				pProducto.precio=leer.GetInt32(2);
				pProducto.fechaCaducidad=leer.GetString(3);
				pProducto.existencia=leer.GetInt32(4);
				lista.Add(pProducto);
				
			}
			
		
			return lista;
		}
		
		public static Producto ObtenerProducto(int pCodigoId){
			Producto pProducto = new Producto();
			MySqlConnection conexion=BDcomun.ObtenerConexion();
			
			MySqlCommand comando = new MySqlCommand(string.Format("select * from producto where codigoIdProducto = {0}",pCodigoId),conexion);
			MySqlDataReader leer = comando.ExecuteReader();
			
			if(leer.Read()){
				pProducto.codigoIdProducto=leer.GetInt32(0);
				pProducto.descripcion=leer.GetString(1);
				pProducto.precio=leer.GetInt32(2);
				pProducto.fechaCaducidad=leer.GetString(3);
				pProducto.existencia=leer.GetInt32(4);
			}
			else{
				MessageBox.Show("No se encuentra ningun producto con ese codigo","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
			
			conexion.Close();
			return pProducto;
		}
		
		public static int Actualizar(Producto pProducto){
			int retorno=0;
			MySqlConnection conexion=BDcomun.ObtenerConexion();
			MySqlCommand comando=new MySqlCommand(string.Format("Update producto set existencia={0} where codigoIdProducto={1}",
			                                                     pProducto.existencia,pProducto.codigoIdProducto),conexion);
			retorno=comando.ExecuteNonQuery();
			conexion.Close();
			return retorno;
		}
		
		public static int Eliminar(int pId){
			int retorno=0;
			MySqlConnection conexion=BDcomun.ObtenerConexion();
			MySqlCommand comando=new MySqlCommand(string.Format("Delete from producto where codigoIdProducto={0}",pId),conexion);
			retorno=comando.ExecuteNonQuery();
			conexion.Close();
			return retorno;
		}
	}
}
