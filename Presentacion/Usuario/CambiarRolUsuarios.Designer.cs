namespace Presentacion.Usuario
{
	partial class CambiarRolUsuarios
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
			this.tabla = new System.Windows.Forms.TableLayoutPanel();
			this.lblUsuarios = new System.Windows.Forms.Label();
			this.lblRol = new System.Windows.Forms.Label();
			this.txtUsuarios = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.cboRol = new System.Windows.Forms.ComboBox();
			this.tabla.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabla
			// 
			this.tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabla.ColumnCount = 1;
			this.tabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tabla.Controls.Add(this.lblUsuarios, 0, 0);
			this.tabla.Controls.Add(this.lblRol, 0, 2);
			this.tabla.Controls.Add(this.txtUsuarios, 0, 1);
			this.tabla.Controls.Add(this.tableLayoutPanel2, 0, 4);
			this.tabla.Controls.Add(this.cboRol, 0, 3);
			this.tabla.Location = new System.Drawing.Point(12, 12);
			this.tabla.Name = "tabla";
			this.tabla.RowCount = 5;
			this.tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tabla.Size = new System.Drawing.Size(306, 139);
			this.tabla.TabIndex = 1;
			// 
			// lblUsuarios
			// 
			this.lblUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblUsuarios.AutoSize = true;
			this.lblUsuarios.Location = new System.Drawing.Point(3, 4);
			this.lblUsuarios.Name = "lblUsuarios";
			this.lblUsuarios.Size = new System.Drawing.Size(48, 13);
			this.lblUsuarios.TabIndex = 0;
			this.lblUsuarios.Text = "Usuarios";
			// 
			// lblRol
			// 
			this.lblRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblRol.AutoSize = true;
			this.lblRol.Location = new System.Drawing.Point(3, 55);
			this.lblRol.Name = "lblRol";
			this.lblRol.Size = new System.Drawing.Size(23, 13);
			this.lblRol.TabIndex = 1;
			this.lblRol.Text = "Rol";
			// 
			// txtUsuarios
			// 
			this.txtUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUsuarios.Enabled = false;
			this.txtUsuarios.Location = new System.Drawing.Point(3, 20);
			this.txtUsuarios.Name = "txtUsuarios";
			this.txtUsuarios.Size = new System.Drawing.Size(300, 20);
			this.txtUsuarios.TabIndex = 2;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.btnCancelar, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnAceptar, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 105);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(300, 31);
			this.tableLayoutPanel2.TabIndex = 4;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.Location = new System.Drawing.Point(153, 3);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(144, 25);
			this.btnCancelar.TabIndex = 1;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAceptar.Location = new System.Drawing.Point(3, 3);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(144, 25);
			this.btnAceptar.TabIndex = 0;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// cboRol
			// 
			this.cboRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cboRol.FormattingEnabled = true;
			this.cboRol.Location = new System.Drawing.Point(3, 71);
			this.cboRol.Name = "cboRol";
			this.cboRol.Size = new System.Drawing.Size(300, 21);
			this.cboRol.TabIndex = 5;
			// 
			// CambiarRolUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 163);
			this.Controls.Add(this.tabla);
			this.Name = "CambiarRolUsuarios";
			this.Text = "Cambiar Rol de Usuarios";
			this.tabla.ResumeLayout(false);
			this.tabla.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		protected System.Windows.Forms.TableLayoutPanel tabla;
		public System.Windows.Forms.Label lblUsuarios;
		public System.Windows.Forms.Label lblRol;
		public System.Windows.Forms.TextBox txtUsuarios;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		public System.Windows.Forms.Button btnCancelar;
		public System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.ComboBox cboRol;
	}
}