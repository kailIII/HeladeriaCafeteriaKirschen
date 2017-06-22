namespace Presentacion
{
	partial class MenuPrincipal
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.TabCaja = new System.Windows.Forms.TabPage();
			this.BtnMovimientosDeCaja = new System.Windows.Forms.Button();
			this.BtnExtraccion = new System.Windows.Forms.Button();
			this.BtnDepositoCaja = new System.Windows.Forms.Button();
			this.TabPedido = new System.Windows.Forms.TabPage();
			this.TabUsuario = new System.Windows.Forms.TabPage();
			this.btnNuevoUsuario = new System.Windows.Forms.Button();
			this.btnLogOut = new System.Windows.Forms.Button();
			this.btnLogIn = new System.Windows.Forms.Button();
			this.lblNombreUsuario = new System.Windows.Forms.Label();
			this.TabProducto = new System.Windows.Forms.TabPage();
			this.LblEstadoDeCaja = new System.Windows.Forms.Label();
			this.TxtEstadoDeCaja = new System.Windows.Forms.TextBox();
			this.PctAlertaCaja = new System.Windows.Forms.PictureBox();
			this.LblAlerta = new System.Windows.Forms.Label();
			this.PnlAlerta = new System.Windows.Forms.Panel();
			this.btnUsuarios = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.TabCaja.SuspendLayout();
			this.TabUsuario.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PctAlertaCaja)).BeginInit();
			this.PnlAlerta.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.TabCaja);
			this.tabControl1.Controls.Add(this.TabPedido);
			this.tabControl1.Controls.Add(this.TabUsuario);
			this.tabControl1.Controls.Add(this.TabProducto);
			this.tabControl1.Location = new System.Drawing.Point(12, 84);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(269, 172);
			this.tabControl1.TabIndex = 0;
			// 
			// TabCaja
			// 
			this.TabCaja.Controls.Add(this.BtnMovimientosDeCaja);
			this.TabCaja.Controls.Add(this.BtnExtraccion);
			this.TabCaja.Controls.Add(this.BtnDepositoCaja);
			this.TabCaja.Location = new System.Drawing.Point(4, 22);
			this.TabCaja.Name = "TabCaja";
			this.TabCaja.Padding = new System.Windows.Forms.Padding(3);
			this.TabCaja.Size = new System.Drawing.Size(261, 146);
			this.TabCaja.TabIndex = 0;
			this.TabCaja.Text = "Caja";
			this.TabCaja.UseVisualStyleBackColor = true;
			// 
			// BtnMovimientosDeCaja
			// 
			this.BtnMovimientosDeCaja.Location = new System.Drawing.Point(6, 64);
			this.BtnMovimientosDeCaja.Name = "BtnMovimientosDeCaja";
			this.BtnMovimientosDeCaja.Size = new System.Drawing.Size(240, 23);
			this.BtnMovimientosDeCaja.TabIndex = 2;
			this.BtnMovimientosDeCaja.Text = "Movimientos";
			this.BtnMovimientosDeCaja.UseVisualStyleBackColor = true;
			this.BtnMovimientosDeCaja.Click += new System.EventHandler(this.BtnMovimientosDeCaja_Click);
			// 
			// BtnExtraccion
			// 
			this.BtnExtraccion.Location = new System.Drawing.Point(6, 35);
			this.BtnExtraccion.Name = "BtnExtraccion";
			this.BtnExtraccion.Size = new System.Drawing.Size(240, 23);
			this.BtnExtraccion.TabIndex = 1;
			this.BtnExtraccion.Text = "Extracción";
			this.BtnExtraccion.UseVisualStyleBackColor = true;
			this.BtnExtraccion.Click += new System.EventHandler(this.BtnExtraccion_Click);
			// 
			// BtnDepositoCaja
			// 
			this.BtnDepositoCaja.Location = new System.Drawing.Point(6, 6);
			this.BtnDepositoCaja.Name = "BtnDepositoCaja";
			this.BtnDepositoCaja.Size = new System.Drawing.Size(240, 23);
			this.BtnDepositoCaja.TabIndex = 0;
			this.BtnDepositoCaja.Text = "Deposito";
			this.BtnDepositoCaja.UseVisualStyleBackColor = true;
			this.BtnDepositoCaja.Click += new System.EventHandler(this.BtnDepositoCaja_Click);
			// 
			// TabPedido
			// 
			this.TabPedido.Location = new System.Drawing.Point(4, 22);
			this.TabPedido.Name = "TabPedido";
			this.TabPedido.Padding = new System.Windows.Forms.Padding(3);
			this.TabPedido.Size = new System.Drawing.Size(261, 146);
			this.TabPedido.TabIndex = 1;
			this.TabPedido.Text = "Pedido";
			this.TabPedido.UseVisualStyleBackColor = true;
			// 
			// TabUsuario
			// 
			this.TabUsuario.Controls.Add(this.btnUsuarios);
			this.TabUsuario.Controls.Add(this.btnNuevoUsuario);
			this.TabUsuario.Controls.Add(this.btnLogOut);
			this.TabUsuario.Controls.Add(this.btnLogIn);
			this.TabUsuario.Controls.Add(this.lblNombreUsuario);
			this.TabUsuario.Location = new System.Drawing.Point(4, 22);
			this.TabUsuario.Name = "TabUsuario";
			this.TabUsuario.Size = new System.Drawing.Size(261, 146);
			this.TabUsuario.TabIndex = 2;
			this.TabUsuario.Text = "Usuario";
			this.TabUsuario.UseVisualStyleBackColor = true;
			// 
			// btnNuevoUsuario
			// 
			this.btnNuevoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNuevoUsuario.Location = new System.Drawing.Point(4, 86);
			this.btnNuevoUsuario.Name = "btnNuevoUsuario";
			this.btnNuevoUsuario.Size = new System.Drawing.Size(254, 23);
			this.btnNuevoUsuario.TabIndex = 8;
			this.btnNuevoUsuario.Text = "Nuevo Usuario";
			this.btnNuevoUsuario.UseVisualStyleBackColor = true;
			this.btnNuevoUsuario.Visible = false;
			this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
			// 
			// btnLogOut
			// 
			this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLogOut.Enabled = false;
			this.btnLogOut.Location = new System.Drawing.Point(4, 56);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(254, 23);
			this.btnLogOut.TabIndex = 7;
			this.btnLogOut.Text = "Log Out";
			this.btnLogOut.UseVisualStyleBackColor = true;
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			// 
			// btnLogIn
			// 
			this.btnLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLogIn.Location = new System.Drawing.Point(4, 26);
			this.btnLogIn.Name = "btnLogIn";
			this.btnLogIn.Size = new System.Drawing.Size(254, 23);
			this.btnLogIn.TabIndex = 6;
			this.btnLogIn.Text = "Log In";
			this.btnLogIn.UseVisualStyleBackColor = true;
			this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
			// 
			// lblNombreUsuario
			// 
			this.lblNombreUsuario.AutoSize = true;
			this.lblNombreUsuario.Location = new System.Drawing.Point(3, 9);
			this.lblNombreUsuario.Name = "lblNombreUsuario";
			this.lblNombreUsuario.Size = new System.Drawing.Size(35, 13);
			this.lblNombreUsuario.TabIndex = 5;
			this.lblNombreUsuario.Text = "label1";
			this.lblNombreUsuario.Visible = false;
			// 
			// TabProducto
			// 
			this.TabProducto.Location = new System.Drawing.Point(4, 22);
			this.TabProducto.Name = "TabProducto";
			this.TabProducto.Size = new System.Drawing.Size(261, 146);
			this.TabProducto.TabIndex = 3;
			this.TabProducto.Text = "Producto";
			this.TabProducto.UseVisualStyleBackColor = true;
			// 
			// LblEstadoDeCaja
			// 
			this.LblEstadoDeCaja.AutoSize = true;
			this.LblEstadoDeCaja.Location = new System.Drawing.Point(12, 15);
			this.LblEstadoDeCaja.Name = "LblEstadoDeCaja";
			this.LblEstadoDeCaja.Size = new System.Drawing.Size(78, 13);
			this.LblEstadoDeCaja.TabIndex = 3;
			this.LblEstadoDeCaja.Text = "Estado de caja";
			// 
			// TxtEstadoDeCaja
			// 
			this.TxtEstadoDeCaja.Location = new System.Drawing.Point(172, 12);
			this.TxtEstadoDeCaja.Name = "TxtEstadoDeCaja";
			this.TxtEstadoDeCaja.ReadOnly = true;
			this.TxtEstadoDeCaja.Size = new System.Drawing.Size(100, 20);
			this.TxtEstadoDeCaja.TabIndex = 4;
			this.TxtEstadoDeCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// PctAlertaCaja
			// 
			this.PctAlertaCaja.Location = new System.Drawing.Point(3, 3);
			this.PctAlertaCaja.Name = "PctAlertaCaja";
			this.PctAlertaCaja.Size = new System.Drawing.Size(32, 32);
			this.PctAlertaCaja.TabIndex = 5;
			this.PctAlertaCaja.TabStop = false;
			// 
			// LblAlerta
			// 
			this.LblAlerta.AutoSize = true;
			this.LblAlerta.Location = new System.Drawing.Point(41, 3);
			this.LblAlerta.Name = "LblAlerta";
			this.LblAlerta.Size = new System.Drawing.Size(142, 13);
			this.LblAlerta.TabIndex = 6;
			this.LblAlerta.Text = "Debe realizar una extracción";
			// 
			// PnlAlerta
			// 
			this.PnlAlerta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PnlAlerta.Controls.Add(this.PctAlertaCaja);
			this.PnlAlerta.Controls.Add(this.LblAlerta);
			this.PnlAlerta.Location = new System.Drawing.Point(12, 38);
			this.PnlAlerta.Name = "PnlAlerta";
			this.PnlAlerta.Size = new System.Drawing.Size(269, 40);
			this.PnlAlerta.TabIndex = 3;
			// 
			// btnUsuarios
			// 
			this.btnUsuarios.Location = new System.Drawing.Point(4, 116);
			this.btnUsuarios.Name = "btnUsuarios";
			this.btnUsuarios.Size = new System.Drawing.Size(252, 23);
			this.btnUsuarios.TabIndex = 9;
			this.btnUsuarios.Text = "Usuarios...";
			this.btnUsuarios.UseVisualStyleBackColor = true;
			this.btnUsuarios.Visible = false;
			this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
			// 
			// MenuPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 268);
			this.Controls.Add(this.PnlAlerta);
			this.Controls.Add(this.TxtEstadoDeCaja);
			this.Controls.Add(this.LblEstadoDeCaja);
			this.Controls.Add(this.tabControl1);
			this.Name = "MenuPrincipal";
			this.Text = "Heladería-Cafetería Kirschen";
			this.Activated += new System.EventHandler(this.MenuPrincipal_Activated);
			this.Load += new System.EventHandler(this.MenuPrincipal_Load);
			this.tabControl1.ResumeLayout(false);
			this.TabCaja.ResumeLayout(false);
			this.TabUsuario.ResumeLayout(false);
			this.TabUsuario.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PctAlertaCaja)).EndInit();
			this.PnlAlerta.ResumeLayout(false);
			this.PnlAlerta.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabCaja;
        private System.Windows.Forms.Button BtnMovimientosDeCaja;
        private System.Windows.Forms.Button BtnExtraccion;
        private System.Windows.Forms.Button BtnDepositoCaja;
        private System.Windows.Forms.TabPage TabPedido;
        private System.Windows.Forms.TabPage TabUsuario;
        private System.Windows.Forms.TabPage TabProducto;
        private System.Windows.Forms.Label LblEstadoDeCaja;
        private System.Windows.Forms.TextBox TxtEstadoDeCaja;
        private System.Windows.Forms.PictureBox PctAlertaCaja;
        private System.Windows.Forms.Label LblAlerta;
        private System.Windows.Forms.Panel PnlAlerta;
		private System.Windows.Forms.Label lblNombreUsuario;
		private System.Windows.Forms.Button btnLogIn;
		private System.Windows.Forms.Button btnLogOut;
		private System.Windows.Forms.Button btnNuevoUsuario;
		private System.Windows.Forms.Button btnUsuarios;
	}
}

