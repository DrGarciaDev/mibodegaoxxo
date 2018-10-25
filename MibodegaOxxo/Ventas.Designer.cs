/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 26/09/2018
 * Hora: 01:46 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MibodegaOxxo
{
	partial class Ventas
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRealizarVenta;
		private System.Windows.Forms.Button btnMostrarVentas;
		private System.Windows.Forms.Label btnCerrar;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnMostrarVentas = new System.Windows.Forms.Button();
			this.btnRealizarVenta = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panelContenedor = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
			this.panel1.Controls.Add(this.btnMostrarVentas);
			this.panel1.Controls.Add(this.btnRealizarVenta);
			this.panel1.Controls.Add(this.btnCerrar);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(952, 68);
			this.panel1.TabIndex = 0;
			// 
			// btnMostrarVentas
			// 
			this.btnMostrarVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnMostrarVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnMostrarVentas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMostrarVentas.FlatAppearance.BorderSize = 0;
			this.btnMostrarVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnMostrarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMostrarVentas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMostrarVentas.ForeColor = System.Drawing.Color.White;
			this.btnMostrarVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarVentas.Image")));
			this.btnMostrarVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMostrarVentas.Location = new System.Drawing.Point(486, 28);
			this.btnMostrarVentas.Name = "btnMostrarVentas";
			this.btnMostrarVentas.Size = new System.Drawing.Size(466, 40);
			this.btnMostrarVentas.TabIndex = 3;
			this.btnMostrarVentas.Text = "Mostrar ventas";
			this.btnMostrarVentas.UseVisualStyleBackColor = false;
			this.btnMostrarVentas.Click += new System.EventHandler(this.BtnMostrarVentasClick);
			// 
			// btnRealizarVenta
			// 
			this.btnRealizarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnRealizarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnRealizarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRealizarVenta.FlatAppearance.BorderSize = 0;
			this.btnRealizarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnRealizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRealizarVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRealizarVenta.ForeColor = System.Drawing.Color.White;
			this.btnRealizarVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnRealizarVenta.Image")));
			this.btnRealizarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRealizarVenta.Location = new System.Drawing.Point(0, 28);
			this.btnRealizarVenta.Name = "btnRealizarVenta";
			this.btnRealizarVenta.Size = new System.Drawing.Size(485, 40);
			this.btnRealizarVenta.TabIndex = 2;
			this.btnRealizarVenta.Text = "Realizar venta";
			this.btnRealizarVenta.UseVisualStyleBackColor = false;
			this.btnRealizarVenta.Click += new System.EventHandler(this.BtnRealizarVentaClick);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.Location = new System.Drawing.Point(919, 0);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(33, 30);
			this.btnCerrar.TabIndex = 1;
			this.btnCerrar.Text = "X";
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(380, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "VENTAS";
			// 
			// panelContenedor
			// 
			this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContenedor.Location = new System.Drawing.Point(0, 68);
			this.panelContenedor.Name = "panelContenedor";
			this.panelContenedor.Size = new System.Drawing.Size(952, 478);
			this.panelContenedor.TabIndex = 4;
			// 
			// Ventas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(952, 546);
			this.Controls.Add(this.panelContenedor);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Ventas";
			this.Text = "Ventas";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
