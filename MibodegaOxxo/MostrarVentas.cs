/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 05/10/2018
 * Hora: 04:07 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MibodegaOxxo
{
	/// <summary>
	/// Description of MostrarVentas.
	/// </summary>
	public partial class MostrarVentas : Form
	{
		public MostrarVentas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnCerrarVentanaClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void Label2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnMostrarVentasClick(object sender, EventArgs e)
		{
			dgvMostrarVentas.DataSource=VentaDAL.mostrar();
		}
	}
}
