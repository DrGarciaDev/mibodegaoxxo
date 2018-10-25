/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 05/10/2018
 * Hora: 01:52 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MibodegaOxxo
{
	partial class Usuarios
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnConsultarUsuario;
		private System.Windows.Forms.Button btnMostrarUsuarios;
		private System.Windows.Forms.Button btnRegistrarUsuario;
		private System.Windows.Forms.Label btnCerrar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelContenedor;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCerrar = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnConsultarUsuario = new System.Windows.Forms.Button();
			this.btnMostrarUsuarios = new System.Windows.Forms.Button();
			this.btnRegistrarUsuario = new System.Windows.Forms.Button();
			this.panelContenedor = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
			this.panel1.Controls.Add(this.btnCerrar);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnConsultarUsuario);
			this.panel1.Controls.Add(this.btnMostrarUsuarios);
			this.panel1.Controls.Add(this.btnRegistrarUsuario);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(952, 74);
			this.panel1.TabIndex = 0;
			// 
			// btnCerrar
			// 
			this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.Location = new System.Drawing.Point(916, 0);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(36, 26);
			this.btnCerrar.TabIndex = 10;
			this.btnCerrar.Text = "X";
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(429, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 26);
			this.label1.TabIndex = 9;
			this.label1.Text = "Usuarios";
			// 
			// btnConsultarUsuario
			// 
			this.btnConsultarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConsultarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnConsultarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConsultarUsuario.FlatAppearance.BorderSize = 0;
			this.btnConsultarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnConsultarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultarUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultarUsuario.ForeColor = System.Drawing.Color.White;
			this.btnConsultarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarUsuario.Image")));
			this.btnConsultarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnConsultarUsuario.Location = new System.Drawing.Point(652, 31);
			this.btnConsultarUsuario.Name = "btnConsultarUsuario";
			this.btnConsultarUsuario.Size = new System.Drawing.Size(297, 40);
			this.btnConsultarUsuario.TabIndex = 8;
			this.btnConsultarUsuario.Text = "Consultar usuario";
			this.btnConsultarUsuario.UseVisualStyleBackColor = false;
			this.btnConsultarUsuario.Click += new System.EventHandler(this.BtnConsultarUsuarioClick);
			// 
			// btnMostrarUsuarios
			// 
			this.btnMostrarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMostrarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnMostrarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMostrarUsuarios.FlatAppearance.BorderSize = 0;
			this.btnMostrarUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnMostrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMostrarUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMostrarUsuarios.ForeColor = System.Drawing.Color.White;
			this.btnMostrarUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarUsuarios.Image")));
			this.btnMostrarUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMostrarUsuarios.Location = new System.Drawing.Point(327, 31);
			this.btnMostrarUsuarios.Name = "btnMostrarUsuarios";
			this.btnMostrarUsuarios.Size = new System.Drawing.Size(322, 40);
			this.btnMostrarUsuarios.TabIndex = 7;
			this.btnMostrarUsuarios.Text = "Mostrar Usuarios";
			this.btnMostrarUsuarios.UseVisualStyleBackColor = false;
			this.btnMostrarUsuarios.Click += new System.EventHandler(this.BtnMostrarUsuariosClick);
			// 
			// btnRegistrarUsuario
			// 
			this.btnRegistrarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnRegistrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnRegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegistrarUsuario.FlatAppearance.BorderSize = 0;
			this.btnRegistrarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrarUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrarUsuario.ForeColor = System.Drawing.Color.White;
			this.btnRegistrarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarUsuario.Image")));
			this.btnRegistrarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRegistrarUsuario.Location = new System.Drawing.Point(3, 31);
			this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
			this.btnRegistrarUsuario.Size = new System.Drawing.Size(322, 40);
			this.btnRegistrarUsuario.TabIndex = 6;
			this.btnRegistrarUsuario.Text = "Registrar Usuario";
			this.btnRegistrarUsuario.UseVisualStyleBackColor = false;
			this.btnRegistrarUsuario.Click += new System.EventHandler(this.BtnRegistrarUsuarioClick);
			// 
			// panelContenedor
			// 
			this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContenedor.Location = new System.Drawing.Point(0, 74);
			this.panelContenedor.Name = "panelContenedor";
			this.panelContenedor.Size = new System.Drawing.Size(952, 472);
			this.panelContenedor.TabIndex = 1;
			// 
			// Usuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 546);
			this.Controls.Add(this.panelContenedor);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Usuarios";
			this.Text = "Usuarios";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
