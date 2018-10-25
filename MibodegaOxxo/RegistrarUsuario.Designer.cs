/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 15/10/2018
 * Hora: 09:21 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MibodegaOxxo
{
	partial class RegistrarUsuario
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label btnCerrar;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtApellidoMaterno;
		private System.Windows.Forms.TextBox txtApellidoPaterno;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRegistrarUsuario;
		private System.Windows.Forms.ComboBox cbxPuesto;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarUsuario));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCerrar = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnRegistrarUsuario = new System.Windows.Forms.Button();
			this.cbxPuesto = new System.Windows.Forms.ComboBox();
			this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
			this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
			this.panel1.Controls.Add(this.btnCerrar);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(730, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(222, 472);
			this.panel1.TabIndex = 1;
			// 
			// btnCerrar
			// 
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.Location = new System.Drawing.Point(189, 0);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(33, 30);
			this.btnCerrar.TabIndex = 2;
			this.btnCerrar.Text = "X";
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(3, 262);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(216, 176);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(216, 182);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.btnRegistrarUsuario);
			this.panel2.Controls.Add(this.cbxPuesto);
			this.panel2.Controls.Add(this.dtpFechaNacimiento);
			this.panel2.Controls.Add(this.txtContraseña);
			this.panel2.Controls.Add(this.txtCorreo);
			this.panel2.Controls.Add(this.txtTelefono);
			this.panel2.Controls.Add(this.txtApellidoMaterno);
			this.panel2.Controls.Add(this.txtApellidoPaterno);
			this.panel2.Controls.Add(this.txtNombre);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(730, 472);
			this.panel2.TabIndex = 3;
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
			this.btnRegistrarUsuario.Location = new System.Drawing.Point(208, 420);
			this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
			this.btnRegistrarUsuario.Size = new System.Drawing.Size(322, 40);
			this.btnRegistrarUsuario.TabIndex = 16;
			this.btnRegistrarUsuario.Text = "Guardar Usuario";
			this.btnRegistrarUsuario.UseVisualStyleBackColor = false;
			this.btnRegistrarUsuario.Click += new System.EventHandler(this.BtnRegistrarUsuarioClick);
			// 
			// cbxPuesto
			// 
			this.cbxPuesto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxPuesto.FormattingEnabled = true;
			this.cbxPuesto.Items.AddRange(new object[] {
			"Supervisor",
			"Comisionista",
			"Empleado"});
			this.cbxPuesto.Location = new System.Drawing.Point(9, 379);
			this.cbxPuesto.Name = "cbxPuesto";
			this.cbxPuesto.Size = new System.Drawing.Size(712, 29);
			this.cbxPuesto.TabIndex = 15;
			// 
			// dtpFechaNacimiento
			// 
			this.dtpFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaNacimiento.Location = new System.Drawing.Point(9, 172);
			this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
			this.dtpFechaNacimiento.Size = new System.Drawing.Size(712, 27);
			this.dtpFechaNacimiento.TabIndex = 14;
			// 
			// txtContraseña
			// 
			this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContraseña.Location = new System.Drawing.Point(9, 325);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.PasswordChar = '*';
			this.txtContraseña.Size = new System.Drawing.Size(712, 27);
			this.txtContraseña.TabIndex = 13;
			// 
			// txtCorreo
			// 
			this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCorreo.Location = new System.Drawing.Point(9, 273);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(712, 27);
			this.txtCorreo.TabIndex = 12;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.Location = new System.Drawing.Point(9, 223);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(712, 27);
			this.txtTelefono.TabIndex = 11;
			// 
			// txtApellidoMaterno
			// 
			this.txtApellidoMaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoMaterno.Location = new System.Drawing.Point(9, 122);
			this.txtApellidoMaterno.Name = "txtApellidoMaterno";
			this.txtApellidoMaterno.Size = new System.Drawing.Size(712, 27);
			this.txtApellidoMaterno.TabIndex = 10;
			// 
			// txtApellidoPaterno
			// 
			this.txtApellidoPaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoPaterno.Location = new System.Drawing.Point(9, 73);
			this.txtApellidoPaterno.Name = "txtApellidoPaterno";
			this.txtApellidoPaterno.Size = new System.Drawing.Size(712, 27);
			this.txtApellidoPaterno.TabIndex = 9;
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(12, 25);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(712, 27);
			this.txtNombre.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(12, 353);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 7;
			this.label8.Text = "Puesto";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(12, 302);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(113, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Contraseña";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 201);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Telefono";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 250);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Correo";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(171, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Apellido materno";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 151);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(190, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Fecha de nacimiento";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(190, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Apellido paterno";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// RegistrarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 472);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RegistrarUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RegistrarUsuario";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
