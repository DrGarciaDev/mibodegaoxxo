/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 15/10/2018
 * Hora: 05:47 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MibodegaOxxo
{
	partial class ConsultarProveedor
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnBuscarProveedor;
		private System.Windows.Forms.TextBox txtRfcBusqueda;
		private System.Windows.Forms.TextBox txtNombreBusqueda;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label btnCerrar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnSeleccionarProveedor;
		private System.Windows.Forms.DataGridView dgvConsultaProveedor;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtRfcEmpresa;
		private System.Windows.Forms.TextBox txtEmpresa;
		private System.Windows.Forms.TextBox txtApeMaterno;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtApePaterno;
		private System.Windows.Forms.Button btnActualizarProveedor;
		private System.Windows.Forms.Button btnEliminarProveedor;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarProveedor));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.btnBuscarProveedor = new System.Windows.Forms.Button();
			this.txtRfcBusqueda = new System.Windows.Forms.TextBox();
			this.txtNombreBusqueda = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btnCerrar = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnActualizarProveedor = new System.Windows.Forms.Button();
			this.btnEliminarProveedor = new System.Windows.Forms.Button();
			this.txtEmpresa = new System.Windows.Forms.TextBox();
			this.txtApePaterno = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtRfcEmpresa = new System.Windows.Forms.TextBox();
			this.txtApeMaterno = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSeleccionarProveedor = new System.Windows.Forms.Button();
			this.dgvConsultaProveedor = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvConsultaProveedor)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.btnBuscarProveedor);
			this.panel1.Controls.Add(this.txtRfcBusqueda);
			this.panel1.Controls.Add(this.txtNombreBusqueda);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.btnCerrar);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(728, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(224, 465);
			this.panel1.TabIndex = 2;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(14, 282);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(188, 21);
			this.label10.TabIndex = 11;
			this.label10.Text = "RFC de la empresa:";
			// 
			// btnBuscarProveedor
			// 
			this.btnBuscarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscarProveedor.FlatAppearance.BorderSize = 0;
			this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscarProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarProveedor.ForeColor = System.Drawing.Color.White;
			this.btnBuscarProveedor.Location = new System.Drawing.Point(14, 356);
			this.btnBuscarProveedor.Name = "btnBuscarProveedor";
			this.btnBuscarProveedor.Size = new System.Drawing.Size(198, 34);
			this.btnBuscarProveedor.TabIndex = 10;
			this.btnBuscarProveedor.Text = "buscar";
			this.btnBuscarProveedor.UseVisualStyleBackColor = false;
			this.btnBuscarProveedor.Click += new System.EventHandler(this.BtnBuscarProveedorClick);
			// 
			// txtRfcBusqueda
			// 
			this.txtRfcBusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRfcBusqueda.Location = new System.Drawing.Point(14, 304);
			this.txtRfcBusqueda.Name = "txtRfcBusqueda";
			this.txtRfcBusqueda.Size = new System.Drawing.Size(198, 27);
			this.txtRfcBusqueda.TabIndex = 9;
			// 
			// txtNombreBusqueda
			// 
			this.txtNombreBusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreBusqueda.Location = new System.Drawing.Point(14, 252);
			this.txtNombreBusqueda.Name = "txtNombreBusqueda";
			this.txtNombreBusqueda.Size = new System.Drawing.Size(198, 27);
			this.txtNombreBusqueda.TabIndex = 8;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(14, 228);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(198, 21);
			this.label11.TabIndex = 6;
			this.label11.Text = "Nombre del proveedor:";
			// 
			// btnCerrar
			// 
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.Location = new System.Drawing.Point(189, 2);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(33, 30);
			this.btnCerrar.TabIndex = 5;
			this.btnCerrar.Text = "X";
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 31);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(216, 182);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.btnActualizarProveedor);
			this.panel2.Controls.Add(this.btnEliminarProveedor);
			this.panel2.Controls.Add(this.txtEmpresa);
			this.panel2.Controls.Add(this.txtApePaterno);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.txtNombre);
			this.panel2.Controls.Add(this.txtCorreo);
			this.panel2.Controls.Add(this.txtTelefono);
			this.panel2.Controls.Add(this.txtRfcEmpresa);
			this.panel2.Controls.Add(this.txtApeMaterno);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.btnSeleccionarProveedor);
			this.panel2.Controls.Add(this.dgvConsultaProveedor);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(728, 465);
			this.panel2.TabIndex = 3;
			// 
			// btnActualizarProveedor
			// 
			this.btnActualizarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnActualizarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnActualizarProveedor.FlatAppearance.BorderSize = 0;
			this.btnActualizarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActualizarProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizarProveedor.ForeColor = System.Drawing.Color.White;
			this.btnActualizarProveedor.Location = new System.Drawing.Point(515, 417);
			this.btnActualizarProveedor.Name = "btnActualizarProveedor";
			this.btnActualizarProveedor.Size = new System.Drawing.Size(198, 34);
			this.btnActualizarProveedor.TabIndex = 34;
			this.btnActualizarProveedor.Text = "Actualizar";
			this.btnActualizarProveedor.UseVisualStyleBackColor = false;
			this.btnActualizarProveedor.Click += new System.EventHandler(this.BtnActualizarProveedorClick);
			// 
			// btnEliminarProveedor
			// 
			this.btnEliminarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnEliminarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminarProveedor.FlatAppearance.BorderSize = 0;
			this.btnEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminarProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminarProveedor.ForeColor = System.Drawing.Color.White;
			this.btnEliminarProveedor.Location = new System.Drawing.Point(55, 417);
			this.btnEliminarProveedor.Name = "btnEliminarProveedor";
			this.btnEliminarProveedor.Size = new System.Drawing.Size(198, 34);
			this.btnEliminarProveedor.TabIndex = 33;
			this.btnEliminarProveedor.Text = "Eliminar";
			this.btnEliminarProveedor.UseVisualStyleBackColor = false;
			this.btnEliminarProveedor.Click += new System.EventHandler(this.BtnEliminarProveedorClick);
			// 
			// txtEmpresa
			// 
			this.txtEmpresa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmpresa.Location = new System.Drawing.Point(205, 314);
			this.txtEmpresa.Name = "txtEmpresa";
			this.txtEmpresa.Size = new System.Drawing.Size(508, 27);
			this.txtEmpresa.TabIndex = 32;
			// 
			// txtApePaterno
			// 
			this.txtApePaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApePaterno.Location = new System.Drawing.Point(528, 241);
			this.txtApePaterno.Name = "txtApePaterno";
			this.txtApePaterno.Size = new System.Drawing.Size(185, 27);
			this.txtApePaterno.TabIndex = 31;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(387, 241);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 23);
			this.label2.TabIndex = 30;
			this.label2.Text = "Apellido paterno";
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(204, 243);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(162, 27);
			this.txtNombre.TabIndex = 28;
			// 
			// txtCorreo
			// 
			this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCorreo.Location = new System.Drawing.Point(204, 384);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(509, 27);
			this.txtCorreo.TabIndex = 27;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.Location = new System.Drawing.Point(528, 279);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(185, 27);
			this.txtTelefono.TabIndex = 26;
			// 
			// txtRfcEmpresa
			// 
			this.txtRfcEmpresa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRfcEmpresa.Location = new System.Drawing.Point(205, 349);
			this.txtRfcEmpresa.Name = "txtRfcEmpresa";
			this.txtRfcEmpresa.Size = new System.Drawing.Size(508, 27);
			this.txtRfcEmpresa.TabIndex = 25;
			// 
			// txtApeMaterno
			// 
			this.txtApeMaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApeMaterno.Location = new System.Drawing.Point(204, 279);
			this.txtApeMaterno.Name = "txtApeMaterno";
			this.txtApeMaterno.Size = new System.Drawing.Size(162, 27);
			this.txtApeMaterno.TabIndex = 23;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(387, 281);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 20;
			this.label7.Text = "Telefono";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(13, 386);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(266, 23);
			this.label6.TabIndex = 19;
			this.label6.Text = "Correo";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 354);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(172, 23);
			this.label5.TabIndex = 18;
			this.label5.Text = "RFC de la Empresa";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 318);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(266, 23);
			this.label4.TabIndex = 17;
			this.label4.Text = "Nombre de la Empresa";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 282);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(147, 23);
			this.label3.TabIndex = 16;
			this.label3.Text = "Apellido materno";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 241);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 23);
			this.label1.TabIndex = 14;
			this.label1.Text = "Nombre del Proveedor";
			// 
			// btnSeleccionarProveedor
			// 
			this.btnSeleccionarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnSeleccionarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSeleccionarProveedor.FlatAppearance.BorderSize = 0;
			this.btnSeleccionarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeleccionarProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSeleccionarProveedor.ForeColor = System.Drawing.Color.White;
			this.btnSeleccionarProveedor.Location = new System.Drawing.Point(293, 203);
			this.btnSeleccionarProveedor.Name = "btnSeleccionarProveedor";
			this.btnSeleccionarProveedor.Size = new System.Drawing.Size(198, 34);
			this.btnSeleccionarProveedor.TabIndex = 12;
			this.btnSeleccionarProveedor.Text = "Seleccionar";
			this.btnSeleccionarProveedor.UseVisualStyleBackColor = false;
			this.btnSeleccionarProveedor.Click += new System.EventHandler(this.BtnSeleccionarProveedorClick);
			// 
			// dgvConsultaProveedor
			// 
			this.dgvConsultaProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvConsultaProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvConsultaProveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvConsultaProveedor.BackgroundColor = System.Drawing.Color.White;
			this.dgvConsultaProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvConsultaProveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvConsultaProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvConsultaProveedor.ColumnHeadersHeight = 30;
			this.dgvConsultaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvConsultaProveedor.EnableHeadersVisualStyles = false;
			this.dgvConsultaProveedor.GridColor = System.Drawing.Color.Black;
			this.dgvConsultaProveedor.Location = new System.Drawing.Point(12, 12);
			this.dgvConsultaProveedor.Name = "dgvConsultaProveedor";
			this.dgvConsultaProveedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvConsultaProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.dgvConsultaProveedor.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvConsultaProveedor.Size = new System.Drawing.Size(701, 185);
			this.dgvConsultaProveedor.TabIndex = 0;
			// 
			// ConsultarProveedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 465);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ConsultarProveedor";
			this.Text = "ConsultarProveedor";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvConsultaProveedor)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
