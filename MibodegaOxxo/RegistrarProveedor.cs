/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Modificado por Luis García
 * FECHA DE MODIFICACIÓN 27/10/2018
 * Fecha: 15/10/2018
 * Hora: 04:27 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MibodegaOxxo
{
	/// <summary>
	/// Description of RegistrarProveedor.
	/// </summary>
	public partial class RegistrarProveedor : Form
	{
		public RegistrarProveedor()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void BtnCerrarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnGuardarProveedorClick(object sender, EventArgs e)
		{
			//Validamos que los capos no esten vaccios y si lo estan decir que rellene el formulario completo
			if(textNombre.Text != "" || textPaterno.Text != "" || textMaterno.Text != "" || textEmpresa.Text !="" 
			   || textRFC.Text !="" || textTelefono.Text !="" || textCorreo.Text !=""){
				
				//Creamos un nuevo objeto de tipo Producto para almacenar en la base de datos
				Proveedor Objeto_Proveedor = new Proveedor();
				
				//Establecemos los valores de las cajas de texto y el dataTimePicker
				Objeto_Proveedor.nombre				= textNombre.Text;
				Objeto_Proveedor.apellidoPaterno	= textPaterno.Text;
				Objeto_Proveedor.apellidoMaterno	= textMaterno.Text;
				Objeto_Proveedor.nombreEmpresa		= textEmpresa.Text;
				Objeto_Proveedor.RFC				= textRFC.Text;
				Objeto_Proveedor.telefono			= textTelefono.Text;				
				Objeto_Proveedor.correo				= textCorreo.Text;

				//Le asignamos a resultado lo que devuelva la funcion de agregar
				int resultado = ProveedorDAL.Agregar(Objeto_Proveedor);
				
				//Si resultado es mayor a 0 informamis de que si se guardo de lo contrario informar que hubo un error
				if(resultado>0){
					MessageBox.Show("Se ha guardado el proveedor con exito","Guardado",MessageBoxButtons.OK,MessageBoxIcon.Information);
					this.Close();
				}
				else{
					MessageBox.Show("No se pudo guardar el proveedor","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			else{
				MessageBox.Show("Campos Vacios por favor rellene el formulario completo","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}
	}
}
