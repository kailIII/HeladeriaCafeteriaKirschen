namespace Presentacion.Pedido
{
	partial class AltaPedido
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblNumeroPedido = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.nudIDPedido = new System.Windows.Forms.NumericUpDown();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.lblProductos = new System.Windows.Forms.Label();
			this.btnAgregarProductos = new System.Windows.Forms.Button();
			this.cbxDelivery = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudIDPedido)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.lblNumeroPedido, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblFecha, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.nudIDPedido, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.dtpFecha, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.dgvProductos, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.lblProductos, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.btnAgregarProductos, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.cbxDelivery, 0, 4);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 8;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.581298F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.581297F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.581297F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.581297F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.581297F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.581297F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.93092F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.581297F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 343);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lblNumeroPedido
			// 
			this.lblNumeroPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblNumeroPedido.AutoSize = true;
			this.lblNumeroPedido.Location = new System.Drawing.Point(3, 19);
			this.lblNumeroPedido.Name = "lblNumeroPedido";
			this.lblNumeroPedido.Size = new System.Drawing.Size(44, 13);
			this.lblNumeroPedido.TabIndex = 0;
			this.lblNumeroPedido.Text = "Numero";
			// 
			// lblFecha
			// 
			this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblFecha.AutoSize = true;
			this.lblFecha.Location = new System.Drawing.Point(3, 83);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(71, 13);
			this.lblFecha.TabIndex = 1;
			this.lblFecha.Text = "Fecha y Hora";
			// 
			// nudIDPedido
			// 
			this.nudIDPedido.Enabled = false;
			this.nudIDPedido.Location = new System.Drawing.Point(3, 35);
			this.nudIDPedido.Name = "nudIDPedido";
			this.nudIDPedido.Size = new System.Drawing.Size(120, 20);
			this.nudIDPedido.TabIndex = 2;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Enabled = false;
			this.dtpFecha.Location = new System.Drawing.Point(3, 99);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(200, 20);
			this.dtpFecha.TabIndex = 3;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.Location = new System.Drawing.Point(212, 317);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(203, 23);
			this.btnCancelar.TabIndex = 8;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAceptar.Location = new System.Drawing.Point(3, 317);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(203, 23);
			this.btnAceptar.TabIndex = 7;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// dgvProductos
			// 
			this.dgvProductos.AllowUserToAddRows = false;
			this.dgvProductos.AllowUserToDeleteRows = false;
			this.dgvProductos.AllowUserToResizeColumns = false;
			this.dgvProductos.AllowUserToResizeRows = false;
			this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tableLayoutPanel1.SetColumnSpan(this.dgvProductos, 2);
			this.dgvProductos.Enabled = false;
			this.dgvProductos.Location = new System.Drawing.Point(3, 195);
			this.dgvProductos.MultiSelect = false;
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.ReadOnly = true;
			this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProductos.Size = new System.Drawing.Size(412, 106);
			this.dgvProductos.TabIndex = 6;
			// 
			// lblProductos
			// 
			this.lblProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblProductos.AutoSize = true;
			this.lblProductos.Location = new System.Drawing.Point(3, 179);
			this.lblProductos.Name = "lblProductos";
			this.lblProductos.Size = new System.Drawing.Size(55, 13);
			this.lblProductos.TabIndex = 4;
			this.lblProductos.Text = "Productos";
			// 
			// btnAgregarProductos
			// 
			this.btnAgregarProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAgregarProductos.Location = new System.Drawing.Point(280, 166);
			this.btnAgregarProductos.Name = "btnAgregarProductos";
			this.btnAgregarProductos.Size = new System.Drawing.Size(135, 23);
			this.btnAgregarProductos.TabIndex = 5;
			this.btnAgregarProductos.Text = "Agregar Productos";
			this.btnAgregarProductos.UseVisualStyleBackColor = true;
			this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
			// 
			// cbxDelivery
			// 
			this.cbxDelivery.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbxDelivery.AutoSize = true;
			this.cbxDelivery.Location = new System.Drawing.Point(3, 135);
			this.cbxDelivery.Name = "cbxDelivery";
			this.cbxDelivery.Size = new System.Drawing.Size(76, 17);
			this.cbxDelivery.TabIndex = 9;
			this.cbxDelivery.Text = "¿Delivery?";
			this.cbxDelivery.UseVisualStyleBackColor = true;
			// 
			// AltaPedido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(442, 367);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "AltaPedido";
			this.Text = "Nuevo Pedido";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudIDPedido)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblNumeroPedido;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.NumericUpDown nudIDPedido;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Label lblProductos;
		private System.Windows.Forms.Button btnAgregarProductos;
		private System.Windows.Forms.DataGridView dgvProductos;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.CheckBox cbxDelivery;
	}
}
