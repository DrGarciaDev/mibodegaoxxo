/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 19/10/2018
 * Hora: 04:12 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MibodegaOxxo
{
	/// <summary>
	/// Description of MostrarUsuarios.
	/// </summary>
	public partial class MostrarUsuarios : Form
	{
		public MostrarUsuarios()
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
	}
}
