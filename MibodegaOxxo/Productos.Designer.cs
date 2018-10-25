/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 05/10/2018
 * Hora: 01:21 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MibodegaOxxo
{
	partial class Productos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnMostrarProductos;
		private System.Windows.Forms.Button btnRegistrarProducto;
		private System.Windows.Forms.Label btnCerrar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnConsultarProducto;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnConsultarProducto = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnMostrarProductos = new System.Windows.Forms.Button();
			this.btnRegistrarProducto = new System.Windows.Forms.Button();
			this.panelContenedor = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
			this.panel1.Controls.Add(this.btnConsultarProducto);
			this.panel1.Controls.Add(this.btnCerrar);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnMostrarProductos);
			this.panel1.Controls.Add(this.btnRegistrarProducto);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(952, 77);
			this.panel1.TabIndex = 0;
			// 
			// btnConsultarProducto
			// 
			this.btnConsultarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConsultarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnConsultarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConsultarProducto.FlatAppearance.BorderSize = 0;
			this.btnConsultarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnConsultarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultarProducto.ForeColor = System.Drawing.Color.White;
			this.btnConsultarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarProducto.Image")));
			this.btnConsultarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnConsultarProducto.Location = new System.Drawing.Point(637, 34);
			this.btnConsultarProducto.Name = "btnConsultarProducto";
			this.btnConsultarProducto.Size = new System.Drawing.Size(315, 40);
			this.btnConsultarProducto.TabIndex = 8;
			this.btnConsultarProducto.Text = "Consultar producto";
			this.btnConsultarProducto.UseVisualStyleBackColor = false;
			this.btnConsultarProducto.Click += new System.EventHandler(this.BtnConsultarProductoClick);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.Location = new System.Drawing.Point(920, 0);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(32, 31);
			this.btnCerrar.TabIndex = 7;
			this.btnCerrar.Text = "X";
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(387, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 31);
			this.label1.TabIndex = 6;
			this.label1.Text = "Productos";
			// 
			// btnMostrarProductos
			// 
			this.btnMostrarProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMostrarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnMostrarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMostrarProductos.FlatAppearance.BorderSize = 0;
			this.btnMostrarProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnMostrarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMostrarProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMostrarProductos.ForeColor = System.Drawing.Color.White;
			this.btnMostrarProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarProductos.Image")));
			this.btnMostrarProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMostrarProductos.Location = new System.Drawing.Point(320, 34);
			this.btnMostrarProductos.Name = "btnMostrarProductos";
			this.btnMostrarProductos.Size = new System.Drawing.Size(315, 40);
			this.btnMostrarProductos.TabIndex = 5;
			this.btnMostrarProductos.Text = "Mostrar productos";
			this.btnMostrarProductos.UseVisualStyleBackColor = false;
			this.btnMostrarProductos.Click += new System.EventHandler(this.BtnMostrarProductosClick);
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
			this.btnRegistrarProducto.Location = new System.Drawing.Point(0, 34);
			this.btnRegistrarProducto.Name = "btnRegistrarProducto";
			this.btnRegistrarProducto.Size = new System.Drawing.Size(318, 40);
			this.btnRegistrarProducto.TabIndex = 4;
			this.btnRegistrarProducto.Text = "Registrar productos";
			this.btnRegistrarProducto.UseVisualStyleBackColor = false;
			this.btnRegistrarProducto.Click += new System.EventHandler(this.BtnRegistrarProductoClick);
			// 
			// panelContenedor
			// 
			this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContenedor.Location = new System.Drawing.Point(0, 77);
			this.panelContenedor.Name = "panelContenedor";
			this.panelContenedor.Size = new System.Drawing.Size(952, 469);
			this.panelContenedor.TabIndex = 1;
			// 
			// Productos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 546);
			this.Controls.Add(this.panelContenedor);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Productos";
			this.Text = "Productos";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
