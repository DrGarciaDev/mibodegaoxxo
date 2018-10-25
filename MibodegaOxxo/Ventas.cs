/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 26/09/2018
 * Hora: 01:46 a. m.
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
	/// Description of Ventas.
	/// </summary>
	public partial class Ventas : Form
	{
		public Ventas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			if(Program.puesto=="Supervisor"){
				btnRealizarVenta.Enabled=false;
			}
			else{
				btnRealizarVenta.Enabled=true;
			}
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
		void BtnRealizarVentaClick(object sender, EventArgs e)
		{
			abrirInPanel(new RealizarVenta());
		}
		void BtnMostrarVentasClick(object sender, EventArgs e)
		{
			abrirInPanel(new MostrarVentas());
		}
	}
	
	public class Venta{
		public int folio {get; set;}
		public decimal totalDeVenta {get; set;}
		public string nombreDeUsuarioVenta {get; set;}
		public string fechaDeLaVenta {get; set;}
		public decimal dineroRecibido {get; set;}
		public decimal cambio {get;set;}
		
		public Venta (){}
		
		public Venta(int pFolio, decimal pTotalDeVenta, string pNombreDeUsuarioVenta, string pFechaDeLaVenta, decimal pDineroRecibido, decimal pCambio){
			this.folio=pFolio;
			this.totalDeVenta=pTotalDeVenta;
			this.nombreDeUsuarioVenta=pNombreDeUsuarioVenta;
			this.fechaDeLaVenta=pFechaDeLaVenta;
			this.dineroRecibido=pDineroRecibido;
			this.cambio=pCambio;
		}
	}
	
	class VentaDAL{
		public static int agregar(Venta pVenta){
			int retorno=0;
			MySqlCommand comando=new MySqlCommand(string.Format("Insert into Venta(fechaDeVenta,nombreDelUsuarioVenta,ventaTotal,dineroRecibido,cambio) values ('{0}','{1}',{2},{3},{4})",
			                                                    pVenta.fechaDeLaVenta,pVenta.nombreDeUsuarioVenta,pVenta.totalDeVenta,pVenta.dineroRecibido,pVenta.cambio),BDcomun.ObtenerConexion());
			retorno=comando.ExecuteNonQuery();
			return retorno;
		}
		
		public static List<Venta> mostrar(){
			List<Venta> lista=new List<Venta>();
			MySqlCommand comando=new MySqlCommand(string.Format("Select * from venta"),BDcomun.ObtenerConexion());
			MySqlDataReader leer=comando.ExecuteReader();
			
			while(leer.Read()){
				Venta pVenta=new Venta();
				pVenta.folio=leer.GetInt32(0);
				pVenta.fechaDeLaVenta=leer.GetString(1);
				pVenta.nombreDeUsuarioVenta=leer.GetString(2);
				pVenta.totalDeVenta=leer.GetDecimal(3);
				pVenta.dineroRecibido=leer.GetDecimal(4);
				pVenta.cambio=leer.GetDecimal(5);
				
				lista.Add(pVenta);
			}
			
			return lista;
		}
	}
}
