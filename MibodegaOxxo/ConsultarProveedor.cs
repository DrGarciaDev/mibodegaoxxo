/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 15/10/2018
 * Hora: 05:47 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

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
				btnActualizar.Enabled=true;
			}
			else{
				btnActualizar.Enabled=false;
			}
			
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
