/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 05/10/2018
 * Hora: 04:07 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MibodegaOxxo
{
	partial class MostrarVentas
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCerrarVentana;
		private System.Windows.Forms.Button btnMostrarVentas;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvMostrarVentas;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarVentas));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnCerrarVentana = new System.Windows.Forms.Button();
			this.btnMostrarVentas = new System.Windows.Forms.Button();
			this.dgvMostrarVentas = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvMostrarVentas)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(702, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(250, 478);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(217, 2);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 28);
			this.label2.TabIndex = 6;
			this.label2.Text = "X";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(2, 209);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(244, 248);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 33);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(247, 156);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.btnCerrarVentana);
			this.panel2.Controls.Add(this.btnMostrarVentas);
			this.panel2.Controls.Add(this.dgvMostrarVentas);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(702, 478);
			this.panel2.TabIndex = 1;
			// 
			// btnCerrarVentana
			// 
			this.btnCerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerrarVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnCerrarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrarVentana.FlatAppearance.BorderSize = 0;
			this.btnCerrarVentana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnCerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCerrarVentana.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrarVentana.ForeColor = System.Drawing.Color.White;
			this.btnCerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarVentana.Image")));
			this.btnCerrarVentana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCerrarVentana.Location = new System.Drawing.Point(362, 417);
			this.btnCerrarVentana.Name = "btnCerrarVentana";
			this.btnCerrarVentana.Size = new System.Drawing.Size(293, 40);
			this.btnCerrarVentana.TabIndex = 5;
			this.btnCerrarVentana.Text = "Cerrar ventana";
			this.btnCerrarVentana.UseVisualStyleBackColor = false;
			this.btnCerrarVentana.Click += new System.EventHandler(this.BtnCerrarVentanaClick);
			// 
			// btnMostrarVentas
			// 
			this.btnMostrarVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnMostrarVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnMostrarVentas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMostrarVentas.FlatAppearance.BorderSize = 0;
			this.btnMostrarVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnMostrarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMostrarVentas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMostrarVentas.ForeColor = System.Drawing.Color.White;
			this.btnMostrarVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarVentas.Image")));
			this.btnMostrarVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMostrarVentas.Location = new System.Drawing.Point(24, 417);
			this.btnMostrarVentas.Name = "btnMostrarVentas";
			this.btnMostrarVentas.Size = new System.Drawing.Size(293, 40);
			this.btnMostrarVentas.TabIndex = 4;
			this.btnMostrarVentas.Text = "Mostrar ventas";
			this.btnMostrarVentas.UseVisualStyleBackColor = false;
			this.btnMostrarVentas.Click += new System.EventHandler(this.BtnMostrarVentasClick);
			// 
			// dgvMostrarVentas
			// 
			this.dgvMostrarVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvMostrarVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvMostrarVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvMostrarVentas.BackgroundColor = System.Drawing.Color.White;
			this.dgvMostrarVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvMostrarVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMostrarVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvMostrarVentas.ColumnHeadersHeight = 30;
			this.dgvMostrarVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvMostrarVentas.EnableHeadersVisualStyles = false;
			this.dgvMostrarVentas.GridColor = System.Drawing.Color.Black;
			this.dgvMostrarVentas.Location = new System.Drawing.Point(12, 62);
			this.dgvMostrarVentas.Name = "dgvMostrarVentas";
			this.dgvMostrarVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMostrarVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.dgvMostrarVentas.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvMostrarVentas.Size = new System.Drawing.Size(684, 324);
			this.dgvMostrarVentas.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(684, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "En esta ventana podra ver todas las ventas que se han hecho y que se han registra" +
	"do dentro del sistema.";
			// 
			// MostrarVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 478);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MostrarVentas";
			this.Text = "MostrarVentas";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvMostrarVentas)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
