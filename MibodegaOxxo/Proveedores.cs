/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 05/10/2018
 * Hora: 01:37 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MibodegaOxxo
{
	/// <summary>
	/// Description of Proveedores.
	/// </summary>
	public partial class Proveedores : Form
	{
		public Proveedores()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			if(Program.puesto=="Supervisor"||Program.puesto=="Comisionista"){
				btnConsultarProveedor.Enabled=true;
			}
			else{
				btnConsultarProveedor.Enabled=false;
			}
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void BtnCerrarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private void abrirInPanel(object formHijo){
			/*funcion para poder llamar un formulario hijo dentro de un formulario padre*/
			if(this.panelContenedor.Controls.Count>0){
				this.panelContenedor.Controls.RemoveAt(0);
			}
			Form fh=formHijo as Form; //creamos un formulario por defecto
			fh.TopLevel=false;//asignamos a la propiedad toplevel falso para que no aparesca arriba
			fh.Dock=DockStyle.Fill;//asignamos a la propiedad dock del formulario para rellenar el panel
			this.panelContenedor.Controls.Add(fh);//añadimos al panel el formulario hijo
			this.panelContenedor.Tag=fh;
			fh.Show();//que aparesca el formulario
		}
		void BtnRegistrarProductoClick(object sender, EventArgs e)
		{
			abrirInPanel(new RegistrarProveedor());
		}
		void Button1Click(object sender, EventArgs e)
		{
			abrirInPanel(new MostrarProveedores());
		}
		void BtnConsultarProveedorClick(object sender, EventArgs e)
		{
			abrirInPanel(new ConsultarProveedor());
		}
		
		
	}
}
