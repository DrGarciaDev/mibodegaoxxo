/*
 * Created by SharpDevelop.
 * User: Carlos
 * Date: 20/09/2018
 * Time: 07:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MibodegaOxxo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void Panel2Paint(object sender, PaintEventArgs e)
		{
	
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			RegistrarUsuario registrarU = new RegistrarUsuario();
			registrarU.Show();
		}
		void Label5Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			try{//Si no hay error en la base de datos
				if(txtContraseña.Text!=""||txtUsuario.Text!=""){
					
					string usuario,contraseña,puesto="";
					usuario=txtUsuario.Text;
					contraseña=txtContraseña.Text;
					
					//Comando SQL para consultar si hay usuarios seleccionar nombre, contraseña y puesto estableciendo la conexion a MySQL
					MySqlCommand comando=new MySqlCommand(string.Format("select nombre,contraseña,puesto from usuario where nombre='" + usuario + "' and contraseña='" + contraseña +"';"),BDcomun.ObtenerConexion());
					//Leer el comando
					MySqlDataReader reader=comando.ExecuteReader();
					//Si hay lectura de datos 
					if(reader.Read()){
						//establesemos el nombre de usuario y el puesto para que aparescan en la ventana principal del sistema
						Program.usuario=txtUsuario.Text;
						Program.puesto=reader.GetString(2);
						MessageBox.Show("Bienvenido al sistema","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
						MibodegaVentanaPrincipal ventanaPrincipal=new MibodegaVentanaPrincipal();
						ventanaPrincipal.Show();
						this.Visible=false;
					}
					else{
						MessageBox.Show("Usuario o contraseña incorrectas","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
				}
				else{
					MessageBox.Show("Campos de texto vacios, por favor llene los campos de texto","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				}
			}
			catch{
				MessageBox.Show("No se pudo conectar a la base de datos, porfavor verifique su conexion","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
		}
		
		void TxtUsuarioEnter(object sender, EventArgs e)
		{
			if(txtUsuario.Text=="USUARIO"){
				txtUsuario.Text="";
			}
		}
		void TxtUsuarioLeave(object sender, EventArgs e)
		{
			if(txtUsuario.Text==""){
				txtUsuario.Text="USUARIO";
			}
		}
		void TxtContraseñaEnter(object sender, EventArgs e)
		{
			if(txtContraseña.Text=="CONTRASEÑA"){
				txtContraseña.Text="";
			}
		}
		void TxtContraseñaLeave(object sender, EventArgs e)
		{
			if(txtContraseña.Text==""){
				txtContraseña.Text="CONTRASEÑA";
			}
		}
	}
	
	public class BDcomun{
		public static MySqlConnection ObtenerConexion(){
			MySqlConnection conectar = new MySqlConnection("server=127.0.0.1;database=mibodegaoxxo;uid=root;pwd='';");
			conectar.Open();
			return conectar;
		}
	}
}
