/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Modificado por Luis García
 * FECHA DE MODIFICACIÓN 27/10/2018
 * Fecha: 15/10/2018
 * Hora: 05:40 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MibodegaOxxo
{
	/// <summary>
	/// Description of MostrarProveedores.
	/// </summary>
	public partial class MostrarProveedores : Form
	{
		public MostrarProveedores()
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
		void BtnMostrarProveedoresClick(object sender, EventArgs e)
		{
			dgvMostrarProveedores.DataSource = ProveedorDAL.Mostrar();
		}
	}
}
