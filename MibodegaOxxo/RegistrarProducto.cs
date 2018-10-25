/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 15/10/2018
 * Hora: 03:03 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MibodegaOxxo
{
	/// <summary>
	/// Description of RegistrarProducto.
	/// </summary>
	public partial class RegistrarProducto : Form
	{
		public RegistrarProducto()
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
		void BtnGuardarProductoClick(object sender, EventArgs e)
		{
			//Validamos que los capos no esten vaccios y si lo estan decir que rellene el formulario completo
			if(txtCodigo.Text != "" || txtDescripcion.Text != "" || txtExistencia.Text != "" || txtPrecio.Text !="" ){
				
				//Creamos un nuevo objeto de tipo Producto para almacenar en la base de datos
				Producto pProducto=new Producto();
				
				//Establecemos los valores de las cajas de texto y el dataTimePicker
				pProducto.codigoIdProducto=Convert.ToInt32(txtCodigo.Text);
				pProducto.descripcion=txtDescripcion.Text;
				pProducto.precio=Convert.ToInt32(txtPrecio.Text);
				pProducto.fechaCaducidad=dtpFechaCaducidad.Value.Year + "/" + dtpFechaCaducidad.Value.Month + "/" + dtpFechaCaducidad.Value.Day;
				pProducto.existencia=Convert.ToInt32(txtExistencia.Text);
				
				//Le asignamos a resultado lo que devuelva la funcion de agregar
				int resultado=ProductoDAL.Agregar(pProducto);
				
				//Si resultado es mayor a 0 informamis de que si se guardo de lo contrario informar que hubo un error
				if(resultado>0){
					MessageBox.Show("Se ha guardado el producto con exito","Guardado",MessageBoxButtons.OK,MessageBoxIcon.Information);
					this.Close();
				}
				else{
					MessageBox.Show("No se pudo guardar el producto","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			else{
				MessageBox.Show("Campos Vacios por favor rellene el formulario completo","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}
	}
}
