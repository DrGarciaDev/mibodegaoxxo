/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Modificado por Luis García
 * FECHA DE MODIFICACIÓN 27/10/2018
 * Fecha: 15/10/2018
 * Hora: 05:47 p. m.
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
	/// Description of ConsultarProveedor.
	/// </summary>
	public partial class ConsultarProveedor : Form
	{
		public ConsultarProveedor()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			if(Program.puesto=="Supervisor"){
				btnActualizarProveedor.Enabled=true;
			}
			else{
				btnActualizarProveedor.Enabled=false;
			}
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public Proveedor proveedorSeleccionado {get;set;}
		
		void BtnCerrarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnBuscarProveedorClick(object sender, EventArgs e)
		{
			if(ProveedorDAL.Buscar(txtNombreBusqueda.Text,txtRfcBusqueda.Text)!=null){
				dgvConsultaProveedor.DataSource = ProveedorDAL.Buscar(txtNombreBusqueda.Text,txtRfcBusqueda.Text);
				txtNombreBusqueda.Clear();
				txtRfcBusqueda.Clear();
			}
			else{
				MessageBox.Show("No se encontro el proveedor con ese nombre o empresa...","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		void BtnSeleccionarProveedorClick(object sender, EventArgs e)
		{
			if(dgvConsultaProveedor.SelectedRows.Count == 1){
				int id = Convert.ToInt32(dgvConsultaProveedor.CurrentRow.Cells[0].Value);
				proveedorSeleccionado = ProveedorDAL.ObtenerProveedor(id);
			}
			else{
				MessageBox.Show("Debe de seleccionar una proveedor de la lista","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
			if(proveedorSeleccionado != null){
				txtNombre.Text			= proveedorSeleccionado.nombre;
				txtApePaterno.Text		= proveedorSeleccionado.apellidoPaterno;
				txtApeMaterno.Text		= proveedorSeleccionado.apellidoMaterno;
				txtTelefono.Text		= proveedorSeleccionado.telefono;
				txtEmpresa.Text			= proveedorSeleccionado.nombreEmpresa;
				txtRfcEmpresa.Text		= proveedorSeleccionado.RFC;
				txtCorreo.Text			= proveedorSeleccionado.correo;
				
				/* OPCION PARA INHABILITAR LOS CAMPOS DE TEXTO EN CASO DE REQUERIRLO
				txtNombre.Enabled=false;
				txtApePaterno.Enabled=false;
				txtApeMaterno.Enabled=false;
				txtTelefono.Enabled=false;
				*/
			}
		}
		void BtnActualizarProveedorClick(object sender, EventArgs e)
		{
			Proveedor Objeto_Proveedor = new Proveedor();
			
			Objeto_Proveedor.IdProveedor		= proveedorSeleccionado.IdProveedor;
			Objeto_Proveedor.nombre				= txtNombre.Text;
			Objeto_Proveedor.apellidoPaterno	= txtApePaterno.Text;
			Objeto_Proveedor.apellidoMaterno	= txtApeMaterno.Text;
			Objeto_Proveedor.nombreEmpresa		= txtEmpresa.Text;
			Objeto_Proveedor.RFC				= txtRfcEmpresa.Text;
			Objeto_Proveedor.telefono			= txtTelefono.Text;
			Objeto_Proveedor.correo				= txtCorreo.Text;
			
			int resultado = ProveedorDAL.Actualizar(Objeto_Proveedor);
			
			if(resultado>0){
				MessageBox.Show("Proveedor actualizado con exito","Modificado",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else{
				MessageBox.Show("No se pudo Actualizar","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			limpiarCajasDeTextoProveedor();
			this.Close();
		}
		
		void limpiarCajasDeTextoProveedor(){
			
			txtNombre.Clear();
			txtApePaterno.Clear();
			txtApeMaterno.Clear();
			txtTelefono.Clear();
			txtEmpresa.Clear();
			txtRfcEmpresa.Clear();
			txtCorreo.Clear();
		}
		void BtnEliminarProveedorClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("¿Esta seguro de eliminar este Proveedor?","¿Estas Seguro?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes){
				if(ProveedorDAL.Eliminar(proveedorSeleccionado.IdProveedor)>0){
					MessageBox.Show("Se ha eliminado el registro correctamente","Eliminado",MessageBoxButtons.OK,MessageBoxIcon.Information);
					limpiarCajasDeTextoProveedor();
					
				}
				else{
					MessageBox.Show("No se pudo eliminar el registro seleccionado","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			else{
				MessageBox.Show("El registro se conservo --- CANCELADO","Registro conservado",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			this.Close();
		}
		
		
	}
}
