/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 05/10/2018
 * Hora: 01:37 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MibodegaOxxo
{
	partial class Proveedores
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnConsultarProveedor;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnRegistrarProducto;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCerrar = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnConsultarProveedor = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnRegistrarProducto = new System.Windows.Forms.Button();
			this.panelContenedor = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
			this.panel1.Controls.Add(this.btnCerrar);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnConsultarProveedor);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.btnRegistrarProducto);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(952, 81);
			this.panel1.TabIndex = 0;
			// 
			// btnCerrar
			// 
			this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.Location = new System.Drawing.Point(920, 0);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(32, 32);
			this.btnCerrar.TabIndex = 9;
			this.btnCerrar.Text = "X";
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(378, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(165, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "Proveedores";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// btnConsultarProveedor
			// 
			this.btnConsultarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConsultarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnConsultarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConsultarProveedor.FlatAppearance.BorderSize = 0;
			this.btnConsultarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnConsultarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultarProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultarProveedor.ForeColor = System.Drawing.Color.White;
			this.btnConsultarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarProveedor.Image")));
			this.btnConsultarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnConsultarProveedor.Location = new System.Drawing.Point(638, 38);
			this.btnConsultarProveedor.Name = "btnConsultarProveedor";
			this.btnConsultarProveedor.Size = new System.Drawing.Size(314, 40);
			this.btnConsultarProveedor.TabIndex = 7;
			this.btnConsultarProveedor.Text = "Consultar Proveedor";
			this.btnConsultarProveedor.UseVisualStyleBackColor = false;
			this.btnConsultarProveedor.Click += new System.EventHandler(this.BtnConsultarProveedorClick);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(323, 38);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(314, 40);
			this.button1.TabIndex = 6;
			this.button1.Text = "Mostrar Proveedores";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnRegistrarProducto
			// 
			this.btnRegistrarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnRegistrarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnRegistrarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegistrarProducto.FlatAppearance.BorderSize = 0;
			this.btnRegistrarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnRegistrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrarProducto.ForeColor = System.Drawing.Color.White;
			this.btnRegistrarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarProducto.Image")));
			this.btnRegistrarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRegistrarProducto.Location = new System.Drawing.Point(0, 38);
			this.btnRegistrarProducto.Name = "btnRegistrarProducto";
			this.btnRegistrarProducto.Size = new System.Drawing.Size(322, 40);
			this.btnRegistrarProducto.TabIndex = 5;
			this.btnRegistrarProducto.Text = "Registrar proveedor";
			this.btnRegistrarProducto.UseVisualStyleBackColor = false;
			this.btnRegistrarProducto.Click += new System.EventHandler(this.BtnRegistrarProductoClick);
			// 
			// panelContenedor
			// 
			this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContenedor.Location = new System.Drawing.Point(0, 81);
			this.panelContenedor.Name = "panelContenedor";
			this.panelContenedor.Size = new System.Drawing.Size(952, 465);
			this.panelContenedor.TabIndex = 1;
			// 
			// Proveedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 546);
			this.Controls.Add(this.panelContenedor);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Proveedores";
			this.Text = "Proveedores";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
