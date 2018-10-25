/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 15/10/2018
 * Hora: 10:31 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MibodegaOxxo
{
	partial class ConsultarUsuario
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label btnCerrar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtNombreUsuario;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
		private System.Windows.Forms.TextBox txtPuesto;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtApellidoMaterno;
		private System.Windows.Forms.TextBox txtApellidoPaterno;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvConsultarUsuario;
		private System.Windows.Forms.Button btnSeleccionar;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarUsuario));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtNombreUsuario = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btnCerrar = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
			this.txtPuesto = new System.Windows.Forms.TextBox();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
			this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvConsultarUsuario = new System.Windows.Forms.DataGridView();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvConsultarUsuario)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
			this.panel1.Controls.Add(this.btnBuscar);
			this.panel1.Controls.Add(this.txtNombreUsuario);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.btnCerrar);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(730, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(222, 472);
			this.panel1.TabIndex = 3;
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.ForeColor = System.Drawing.Color.White;
			this.btnBuscar.Location = new System.Drawing.Point(12, 369);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(198, 34);
			this.btnBuscar.TabIndex = 11;
			this.btnBuscar.Text = "buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			// 
			// txtNombreUsuario
			// 
			this.txtNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreUsuario.Location = new System.Drawing.Point(12, 311);
			this.txtNombreUsuario.Name = "txtNombreUsuario";
			this.txtNombreUsuario.Size = new System.Drawing.Size(198, 27);
			this.txtNombreUsuario.TabIndex = 10;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(12, 265);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(198, 21);
			this.label11.TabIndex = 9;
			this.label11.Text = "Nombre del Usuario:";
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
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 33);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(216, 182);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.dtpFechaNacimiento);
			this.panel2.Controls.Add(this.txtPuesto);
			this.panel2.Controls.Add(this.txtCorreo);
			this.panel2.Controls.Add(this.txtContraseña);
			this.panel2.Controls.Add(this.txtTelefono);
			this.panel2.Controls.Add(this.txtApellidoMaterno);
			this.panel2.Controls.Add(this.txtApellidoPaterno);
			this.panel2.Controls.Add(this.txtNombre);
			this.panel2.Controls.Add(this.btnEliminar);
			this.panel2.Controls.Add(this.btnActualizar);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.dgvConsultarUsuario);
			this.panel2.Controls.Add(this.btnSeleccionar);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(730, 472);
			this.panel2.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(377, 241);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 23);
			this.label2.TabIndex = 35;
			this.label2.Text = "Apellido paterno";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(442, 273);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 34;
			this.label6.Text = "Telefono";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 308);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(181, 23);
			this.label3.TabIndex = 32;
			this.label3.Text = "Fecha de nacimiento";
			// 
			// dtpFechaNacimiento
			// 
			this.dtpFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaNacimiento.Location = new System.Drawing.Point(186, 305);
			this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
			this.dtpFechaNacimiento.Size = new System.Drawing.Size(228, 27);
			this.dtpFechaNacimiento.TabIndex = 31;
			// 
			// txtPuesto
			// 
			this.txtPuesto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPuesto.Location = new System.Drawing.Point(76, 382);
			this.txtPuesto.Name = "txtPuesto";
			this.txtPuesto.Size = new System.Drawing.Size(644, 27);
			this.txtPuesto.TabIndex = 30;
			// 
			// txtCorreo
			// 
			this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCorreo.Location = new System.Drawing.Point(77, 346);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(644, 27);
			this.txtCorreo.TabIndex = 29;
			// 
			// txtContraseña
			// 
			this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContraseña.Location = new System.Drawing.Point(522, 305);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(199, 27);
			this.txtContraseña.TabIndex = 28;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.Location = new System.Drawing.Point(523, 271);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(198, 27);
			this.txtTelefono.TabIndex = 27;
			// 
			// txtApellidoMaterno
			// 
			this.txtApellidoMaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoMaterno.Location = new System.Drawing.Point(166, 271);
			this.txtApellidoMaterno.Name = "txtApellidoMaterno";
			this.txtApellidoMaterno.Size = new System.Drawing.Size(211, 27);
			this.txtApellidoMaterno.TabIndex = 26;
			// 
			// txtApellidoPaterno
			// 
			this.txtApellidoPaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoPaterno.Location = new System.Drawing.Point(522, 236);
			this.txtApellidoPaterno.Name = "txtApellidoPaterno";
			this.txtApellidoPaterno.Size = new System.Drawing.Size(198, 27);
			this.txtApellidoPaterno.TabIndex = 25;
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(165, 236);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(212, 27);
			this.txtNombre.TabIndex = 24;
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.Color.White;
			this.btnEliminar.Location = new System.Drawing.Point(12, 426);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(198, 34);
			this.btnEliminar.TabIndex = 23;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			// 
			// btnActualizar
			// 
			this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnActualizar.FlatAppearance.BorderSize = 0;
			this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.ForeColor = System.Drawing.Color.White;
			this.btnActualizar.Location = new System.Drawing.Point(522, 426);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(198, 34);
			this.btnActualizar.TabIndex = 22;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = false;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(12, 384);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 21;
			this.label8.Text = "Puesto";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(420, 308);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(109, 23);
			this.label7.TabIndex = 20;
			this.label7.Text = "Contraseña";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 346);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 18;
			this.label5.Text = "Correo";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 274);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(149, 23);
			this.label4.TabIndex = 17;
			this.label4.Text = "Apellido materno";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 241);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 14;
			this.label1.Text = "Nombre";
			// 
			// dgvConsultarUsuario
			// 
			this.dgvConsultarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvConsultarUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvConsultarUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvConsultarUsuario.BackgroundColor = System.Drawing.Color.White;
			this.dgvConsultarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvConsultarUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvConsultarUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvConsultarUsuario.ColumnHeadersHeight = 30;
			this.dgvConsultarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvConsultarUsuario.EnableHeadersVisualStyles = false;
			this.dgvConsultarUsuario.GridColor = System.Drawing.Color.Black;
			this.dgvConsultarUsuario.Location = new System.Drawing.Point(9, 9);
			this.dgvConsultarUsuario.Name = "dgvConsultarUsuario";
			this.dgvConsultarUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvConsultarUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.dgvConsultarUsuario.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvConsultarUsuario.Size = new System.Drawing.Size(711, 181);
			this.dgvConsultarUsuario.TabIndex = 13;
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSeleccionar.FlatAppearance.BorderSize = 0;
			this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
			this.btnSeleccionar.Location = new System.Drawing.Point(259, 196);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(198, 34);
			this.btnSeleccionar.TabIndex = 12;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = false;
			// 
			// ConsultarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 472);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ConsultarUsuario";
			this.Text = "ConsultarUsuario";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvConsultarUsuario)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
