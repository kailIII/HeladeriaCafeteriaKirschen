namespace Presentacion.Usuario
{
	partial class ListaUsuarios
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
			this.dgvUsuarios = new System.Windows.Forms.DataGridView();
			this.lblBuscar = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnNuevoUsuario = new System.Windows.Forms.Button();
			this.btnCambiarRol = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvUsuarios
			// 
			this.dgvUsuarios.AllowUserToAddRows = false;
			this.dgvUsuarios.AllowUserToDeleteRows = false;
			this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tableLayoutPanel1.SetColumnSpan(this.dgvUsuarios, 3);
			this.dgvUsuarios.Location = new System.Drawing.Point(3, 32);
			this.dgvUsuarios.Name = "dgvUsuarios";
			this.dgvUsuarios.ReadOnly = true;
			this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUsuarios.Size = new System.Drawing.Size(475, 176);
			this.dgvUsuarios.TabIndex = 0;
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
			this.txtBuscar.Size = new System.Drawing.Size(282, 20);
			this.txtBuscar.TabIndex = 2;
			this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLimpiar.Location = new System.Drawing.Point(387, 4);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(91, 20);
			this.btnLimpiar.TabIndex = 3;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.CargarUsuarios);
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
			this.tableLayoutPanel1.Controls.Add(this.dgvUsuarios, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(481, 246);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Controls.Add(this.btnBorrar, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnNuevoUsuario, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnCambiarRol, 2, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 214);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(475, 29);
			this.tableLayoutPanel2.TabIndex = 5;
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
			// btnNuevoUsuario
			// 
			this.btnNuevoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNuevoUsuario.Location = new System.Drawing.Point(3, 3);
			this.btnNuevoUsuario.Name = "btnNuevoUsuario";
			this.btnNuevoUsuario.Size = new System.Drawing.Size(152, 23);
			this.btnNuevoUsuario.TabIndex = 5;
			this.btnNuevoUsuario.Text = "Nuevo Usuario";
			this.btnNuevoUsuario.UseVisualStyleBackColor = true;
			this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
			// 
			// btnCambiarRol
			// 
			this.btnCambiarRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCambiarRol.Location = new System.Drawing.Point(319, 3);
			this.btnCambiarRol.Name = "btnCambiarRol";
			this.btnCambiarRol.Size = new System.Drawing.Size(153, 23);
			this.btnCambiarRol.TabIndex = 6;
			this.btnCambiarRol.Text = "Cambiar Rol Seleccionados";
			this.btnCambiarRol.UseVisualStyleBackColor = true;
			this.btnCambiarRol.Click += new System.EventHandler(this.btnCambiarRol_Click);
			// 
			// ListaUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 271);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MinimumSize = new System.Drawing.Size(316, 272);
			this.Name = "ListaUsuarios";
			this.Text = "Lista de Usuarios";
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvUsuarios;
		private System.Windows.Forms.Label lblBuscar;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button btnNuevoUsuario;
		private System.Windows.Forms.Button btnCambiarRol;
	}
}