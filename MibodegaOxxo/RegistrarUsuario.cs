/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 15/10/2018
 * Hora: 09:21 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MibodegaOxxo
{
	/// <summary>
	/// Description of RegistrarUsuario.
	/// </summary>
	public partial class RegistrarUsuario : Form
	{
		public RegistrarUsuario()
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
		void BtnRegistrarUsuarioClick(object sender, EventArgs e)
		{
			Usuario pUsuario= new Usuario();
			pUsuario.nombre=txtNombre.Text;
			pUsuario.apellidoPaterno=txtApellidoPaterno.Text;
			pUsuario.apellidoMaterno=txtApellidoMaterno.Text;
			pUsuario.fechaNacimiento=dtpFechaNacimiento.Value.Year + "/" + dtpFechaNacimiento.Value.Month + "/" + dtpFechaNacimiento.Value.Day;
			pUsuario.correo=txtCorreo.Text;
			pUsuario.telefono=Convert.ToInt32(txtTelefono.Text);
			pUsuario.contraseña=txtContraseña.Text;
			pUsuario.puesto=cbxPuesto.Text;
			
			int resultado=UsuariosDAL.Agregar(pUsuario);
			if(resultado>0){
				MessageBox.Show("Se a guardado un usuario con exito", "Guardado", MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else{
				MessageBox.Show("No se pudo guardar el usuario", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
	}
}
