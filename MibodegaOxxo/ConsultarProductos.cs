/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 15/10/2018
 * Hora: 03:48 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace MibodegaOxxo
{
	/// <summary>
	/// Description of ConsultarProductos.
	/// </summary>
	public partial class ConsultarProductos : Form
	{
		public ConsultarProductos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			if(Program.puesto=="Supervisor"){
				btnActualizar.Enabled=true;//Habilitar boton
			}
			else{
				btnActualizar.Enabled=false;//inhabilitar boton
			}
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public Producto productoSeleccionado {get;set;}
		
		void BtnBuscarClick(object sender, EventArgs e)
		{
			
			if(ProductoDAL.Buscar(Convert.ToInt32(txtCodigoProducto.Text),txtDescripcionProducto.Text)!=null){
				dgvProductos.DataSource=ProductoDAL.Buscar(Convert.ToInt32(txtCodigoProducto.Text),txtDescripcionProducto.Text);
				txtCodigoProducto.Clear();
				txtDescripcionProducto.Clear();
			}
			else{
				MessageBox.Show("No se encontro el producto con ese codigo o esa descripcion","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		void BtnCerrarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnSeleccionarClick(object sender, EventArgs e)
		{
			if(dgvProductos.SelectedRows.Count == 1){
				int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
				productoSeleccionado=ProductoDAL.ObtenerProducto(id);
			}
			else{
				MessageBox.Show("Debe de seleccionar una fila","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
			if(productoSeleccionado != null){
				txtCodigo.Text=Convert.ToString(productoSeleccionado.codigoIdProducto);
				txtDescripcion.Text=productoSeleccionado.descripcion;
				txtPrecio.Text=Convert.ToString(productoSeleccionado.precio);
				dtpFechaCaducidad.Text=productoSeleccionado.fechaCaducidad;
				txtExistencia.Text=Convert.ToString(productoSeleccionado.existencia);
				
				txtCodigo.Enabled=false;
				txtDescripcion.Enabled=false;
				txtPrecio.Enabled=false;
				dtpFechaCaducidad.Enabled=false;
			}
		}
		void BtnActualizarClick(object sender, EventArgs e)
		{
			Producto pProducto=new Producto();
			pProducto.codigoIdProducto=productoSeleccionado.codigoIdProducto;
			pProducto.descripcion=txtDescripcion.Text;
			pProducto.precio=Convert.ToInt32(txtPrecio.Text);
			pProducto.fechaCaducidad=dtpFechaCaducidad.Text;
			pProducto.existencia=Convert.ToInt32(txtExistencia.Text);
			
			int resultado=ProductoDAL.Actualizar(pProducto);
			
			if(resultado>0){
				MessageBox.Show("Se ha modificado la existencia del producto","Modificado",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else{
				MessageBox.Show("No se pudo Actualizar","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			limpiarCajasDeTexto();
			this.Close();
		}
		
		void limpiarCajasDeTexto(){
			
			txtCodigo.Clear();
			txtDescripcion.Clear();
			txtPrecio.Clear();
			txtExistencia.Clear();
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("¿Esta seguro de eliminar este Producto?","¿Estas Seguro?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes){
				if(ProductoDAL.Eliminar(productoSeleccionado.codigoIdProducto)>0){
					MessageBox.Show("Se ha eliminado el registro correctamente","Eliminado",MessageBoxButtons.OK,MessageBoxIcon.Information);
					limpiarCajasDeTexto();
					
				}
				else{
					MessageBox.Show("No se pudo eliminar el registro seleccionado","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			else{
				MessageBox.Show("El registro se conservo","Registro conservado",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			this.Close();
		}
		
	}
}
