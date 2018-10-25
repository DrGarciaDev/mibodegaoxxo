/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 05/10/2018
 * Hora: 09:46 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MibodegaOxxo
{
	partial class RealizarDepositos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DateTimePicker dtpFechaDeposito;
		private System.Windows.Forms.Label labelNombreUsuario;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMonto;
		private System.Windows.Forms.TextBox txtNumeroCuenta;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxElegirBanco;
		private System.Windows.Forms.Button btnRealizarDeposito;
		private System.Windows.Forms.Label label7;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarDepositos));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnRealizarDeposito = new System.Windows.Forms.Button();
			this.dtpFechaDeposito = new System.Windows.Forms.DateTimePicker();
			this.labelNombreUsuario = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMonto = new System.Windows.Forms.TextBox();
			this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxElegirBanco = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(702, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(250, 472);
			this.panel1.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(220, 4);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(30, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "X";
			this.label7.Click += new System.EventHandler(this.Label7Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(3, 200);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(244, 239);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(244, 164);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.btnRealizarDeposito);
			this.panel2.Controls.Add(this.dtpFechaDeposito);
			this.panel2.Controls.Add(this.labelNombreUsuario);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txtMonto);
			this.panel2.Controls.Add(this.txtNumeroCuenta);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.cbxElegirBanco);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(702, 472);
			this.panel2.TabIndex = 1;
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
			this.btnRealizarDeposito.Location = new System.Drawing.Point(131, 329);
			this.btnRealizarDeposito.Name = "btnRealizarDeposito";
			this.btnRealizarDeposito.Size = new System.Drawing.Size(474, 46);
			this.btnRealizarDeposito.TabIndex = 10;
			this.btnRealizarDeposito.Text = "Realizar deposito";
			this.btnRealizarDeposito.UseVisualStyleBackColor = false;
			// 
			// dtpFechaDeposito
			// 
			this.dtpFechaDeposito.Enabled = false;
			this.dtpFechaDeposito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaDeposito.Location = new System.Drawing.Point(12, 75);
			this.dtpFechaDeposito.Name = "dtpFechaDeposito";
			this.dtpFechaDeposito.Size = new System.Drawing.Size(425, 27);
			this.dtpFechaDeposito.TabIndex = 9;
			// 
			// labelNombreUsuario
			// 
			this.labelNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombreUsuario.Location = new System.Drawing.Point(469, 79);
			this.labelNombreUsuario.Name = "labelNombreUsuario";
			this.labelNombreUsuario.Size = new System.Drawing.Size(88, 23);
			this.labelNombreUsuario.TabIndex = 8;
			this.labelNombreUsuario.Text = "Nombre";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(469, 49);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "Usuario:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(165, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Fecha del deposito";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(469, 200);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(165, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Monto a depositar";
			// 
			// txtMonto
			// 
			this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMonto.Location = new System.Drawing.Point(469, 226);
			this.txtMonto.Name = "txtMonto";
			this.txtMonto.Size = new System.Drawing.Size(227, 27);
			this.txtMonto.TabIndex = 4;
			// 
			// txtNumeroCuenta
			// 
			this.txtNumeroCuenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumeroCuenta.Location = new System.Drawing.Point(12, 226);
			this.txtNumeroCuenta.Name = "txtNumeroCuenta";
			this.txtNumeroCuenta.Size = new System.Drawing.Size(425, 27);
			this.txtNumeroCuenta.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(165, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Numero de cuenta";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 123);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Elegir banco";
			// 
			// cbxElegirBanco
			// 
			this.cbxElegirBanco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxElegirBanco.FormattingEnabled = true;
			this.cbxElegirBanco.Items.AddRange(new object[] {
			"Bancomer",
			"Banamex",
			"Banorte",
			"HSBC",
			"Santander",
			"Scotiabank"});
			this.cbxElegirBanco.Location = new System.Drawing.Point(12, 149);
			this.cbxElegirBanco.Name = "cbxElegirBanco";
			this.cbxElegirBanco.Size = new System.Drawing.Size(425, 29);
			this.cbxElegirBanco.TabIndex = 0;
			this.cbxElegirBanco.Text = "Seleccione un banco";
			// 
			// RealizarDepositos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 472);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RealizarDepositos";
			this.Text = "RealizarDepositos";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
