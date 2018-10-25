/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 05/10/2018
 * Hora: 01:10 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MibodegaOxxo
{
	partial class Depositos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnMostrarDepositos;
		private System.Windows.Forms.Button btnRealizarDeposito;
		private System.Windows.Forms.Label label2;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Depositos));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnMostrarDepositos = new System.Windows.Forms.Button();
			this.btnRealizarDeposito = new System.Windows.Forms.Button();
			this.panelContenedor = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnMostrarDepositos);
			this.panel1.Controls.Add(this.btnRealizarDeposito);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(952, 74);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(922, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 29);
			this.label2.TabIndex = 6;
			this.label2.Text = "X";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(397, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 29);
			this.label1.TabIndex = 5;
			this.label1.Text = "Depositos";
			// 
			// btnMostrarDepositos
			// 
			this.btnMostrarDepositos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnMostrarDepositos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnMostrarDepositos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMostrarDepositos.FlatAppearance.BorderSize = 0;
			this.btnMostrarDepositos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnMostrarDepositos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMostrarDepositos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMostrarDepositos.ForeColor = System.Drawing.Color.White;
			this.btnMostrarDepositos.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarDepositos.Image")));
			this.btnMostrarDepositos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMostrarDepositos.Location = new System.Drawing.Point(476, 32);
			this.btnMostrarDepositos.Name = "btnMostrarDepositos";
			this.btnMostrarDepositos.Size = new System.Drawing.Size(474, 40);
			this.btnMostrarDepositos.TabIndex = 4;
			this.btnMostrarDepositos.Text = "Mostrar depositos";
			this.btnMostrarDepositos.UseVisualStyleBackColor = false;
			this.btnMostrarDepositos.Click += new System.EventHandler(this.BtnMostrarDepositosClick);
			// 
			// btnRealizarDeposito
			// 
			this.btnRealizarDeposito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnRealizarDeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnRealizarDeposito.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRealizarDeposito.FlatAppearance.BorderSize = 0;
			this.btnRealizarDeposito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnRealizarDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRealizarDeposito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRealizarDeposito.ForeColor = System.Drawing.Color.White;
			this.btnRealizarDeposito.Image = ((System.Drawing.Image)(resources.GetObject("btnRealizarDeposito.Image")));
			this.btnRealizarDeposito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRealizarDeposito.Location = new System.Drawing.Point(0, 32);
			this.btnRealizarDeposito.Name = "btnRealizarDeposito";
			this.btnRealizarDeposito.Size = new System.Drawing.Size(474, 40);
			this.btnRealizarDeposito.TabIndex = 3;
			this.btnRealizarDeposito.Text = "Realizar deposito";
			this.btnRealizarDeposito.UseVisualStyleBackColor = false;
			this.btnRealizarDeposito.Click += new System.EventHandler(this.BtnRealizarDepositoClick);
			// 
			// panelContenedor
			// 
			this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContenedor.Location = new System.Drawing.Point(0, 74);
			this.panelContenedor.Name = "panelContenedor";
			this.panelContenedor.Size = new System.Drawing.Size(952, 472);
			this.panelContenedor.TabIndex = 1;
			// 
			// Depositos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 546);
			this.Controls.Add(this.panelContenedor);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Depositos";
			this.Text = "Depositos";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
