/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 05/10/2018
 * Hora: 01:10 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MibodegaOxxo
{
	/// <summary>
	/// Description of Depositos.
	/// </summary>
	public partial class Depositos : Form
	{
		public Depositos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			if(Program.puesto=="Supervisor"||Program.puesto=="Empleado"){
				btnRealizarDeposito.Enabled=false;
			}
			else{
				btnRealizarDeposito.Enabled=true;
			}
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label2Click(object sender, EventArgs e)
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
		void BtnRealizarDepositoClick(object sender, EventArgs e)
		{
			abrirInPanel(new RealizarDepositos());
		}
		void BtnMostrarDepositosClick(object sender, EventArgs e)
		{
			abrirInPanel(new MostrarDepositos());
		}
		
		
	}
}
