namespace Presentacion.CoreClasses
{
	partial class ListaEntidades
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
			this.lblBuscar = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.dgvEntidades = new System.Windows.Forms.DataGridView();
			this.buttonsTable = new System.Windows.Forms.TableLayoutPanel();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnAccion3 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEntidades)).BeginInit();
			this.buttonsTable.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.lblBuscar, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtBuscar, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnLimpiar, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.dgvEntidades, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.buttonsTable, 0, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 247);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// lblBuscar
			// 
			this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblBuscar.AutoSize = true;
			this.lblBuscar.Location = new System.Drawing.Point(3, 8);
			this.lblBuscar.Name = "lblBuscar";
			this.lblBuscar.Size = new System.Drawing.Size(90, 13);
			this.lblBuscar.TabIndex = 1;
			this.lblBuscar.Text = "Buscar:";
			this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtBuscar
			// 
			this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBuscar.Location = new System.Drawing.Point(99, 4);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(283, 20);
			this.txtBuscar.TabIndex = 2;
			this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLimpiar.Location = new System.Drawing.Point(388, 4);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(91, 20);
			this.btnLimpiar.TabIndex = 3;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.CargarEntidades);
			// 
			// dgvEntidades
			// 
			this.dgvEntidades.AllowUserToAddRows = false;
			this.dgvEntidades.AllowUserToDeleteRows = false;
			this.dgvEntidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvEntidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tableLayoutPanel1.SetColumnSpan(this.dgvEntidades, 3);
			this.dgvEntidades.Location = new System.Drawing.Point(3, 32);
			this.dgvEntidades.Name = "dgvEntidades";
			this.dgvEntidades.ReadOnly = true;
			this.dgvEntidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEntidades.Size = new System.Drawing.Size(476, 176);
			this.dgvEntidades.TabIndex = 0;
			// 
			// buttonsTable
			// 
			this.buttonsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonsTable.ColumnCount = 3;
			this.tableLayoutPanel1.SetColumnSpan(this.buttonsTable, 3);
			this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.buttonsTable.Controls.Add(this.btnBorrar, 1, 0);
			this.buttonsTable.Controls.Add(this.btnNuevo, 0, 0);
			this.buttonsTable.Controls.Add(this.btnAccion3, 2, 0);
			this.buttonsTable.Location = new System.Drawing.Point(3, 214);
			this.buttonsTable.Name = "buttonsTable";
			this.buttonsTable.RowCount = 1;
			this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.buttonsTable.Size = new System.Drawing.Size(476, 29);
			this.buttonsTable.TabIndex = 5;
			// 
			// btnBorrar
			// 
			this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBorrar.Location = new System.Drawing.Point(161, 3);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(152, 23);
			this.btnBorrar.TabIndex = 4;
			this.btnBorrar.Text = "Borrar Seleccionados";
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNuevo.Location = new System.Drawing.Point(3, 3);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(152, 23);
			this.btnNuevo.TabIndex = 5;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnAccion3
			// 
			this.btnAccion3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAccion3.Location = new System.Drawing.Point(319, 3);
			this.btnAccion3.Name = "btnAccion3";
			this.btnAccion3.Size = new System.Drawing.Size(154, 23);
			this.btnAccion3.TabIndex = 6;
			this.btnAccion3.Text = "button1";
			this.btnAccion3.UseVisualStyleBackColor = true;
			// 
			// ListaEntidades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 271);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ListaEntidades";
			this.Text = "ListaEntidades";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEntidades)).EndInit();
			this.buttonsTable.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblBuscar;
		protected System.Windows.Forms.Button btnLimpiar;
		protected System.Windows.Forms.TextBox txtBuscar;
		protected System.Windows.Forms.DataGridView dgvEntidades;
		protected System.Windows.Forms.Button btnBorrar;
		protected System.Windows.Forms.Button btnNuevo;
		protected System.Windows.Forms.TableLayoutPanel buttonsTable;
		protected System.Windows.Forms.Button btnAccion3;
	}
}