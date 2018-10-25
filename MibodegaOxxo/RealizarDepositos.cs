/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 05/10/2018
 * Hora: 09:46 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MibodegaOxxo
{
	/// <summary>
	/// Description of RealizarDepositos.
	/// </summary>
	public partial class RealizarDepositos : Form
	{
		public RealizarDepositos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			labelNombreUsuario.Text=Program.usuario;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label7Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
