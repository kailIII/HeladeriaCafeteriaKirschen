namespace Presentacion
{
	partial class MenuPrincipal
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
			this.components = new System.ComponentModel.Container();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoPedido = new System.Windows.Forms.ToolStripMenuItem();
			this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnNuevoProducto = new System.Windows.Forms.ToolStripMenuItem();
			this.btnProductos = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiUsuario = new System.Windows.Forms.ToolStripMenuItem();
			this.btnLogIn = new System.Windows.Forms.ToolStripMenuItem();
			this.btnLogOut = new System.Windows.Forms.ToolStripMenuItem();
			this.btnCambiarContrasenia = new System.Windows.Forms.ToolStripMenuItem();
			this.btnNuevoUsuario = new System.Windows.Forms.ToolStripMenuItem();
			this.btnUsuarios = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiCaja = new System.Windows.Forms.ToolStripMenuItem();
			this.depositoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.extraccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.limiteDeAlertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PnlCaja = new System.Windows.Forms.Panel();
			this.PnlAlerta = new System.Windows.Forms.Panel();
			this.PctAlertaCaja = new System.Windows.Forms.PictureBox();
			this.LblAlerta = new System.Windows.Forms.Label();
			this.TxtEstadoDeCaja = new System.Windows.Forms.TextBox();
			this.LblEstadoDeCaja = new System.Windows.Forms.Label();
			this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.PnlCaja.SuspendLayout();
			this.PnlAlerta.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PctAlertaCaja)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.Color.White;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidoToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.tsmiUsuario,
            this.tsmiCaja});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(632, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "MenuStrip";
			// 
			// pedidoToolStripMenuItem
			// 
			this.pedidoToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.pedidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPedido,
            this.pedidosToolStripMenuItem});
			this.pedidoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
			this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.pedidoToolStripMenuItem.Text = "Pedido";
			// 
			// nuevoPedido
			// 
			this.nuevoPedido.Name = "nuevoPedido";
			this.nuevoPedido.Size = new System.Drawing.Size(152, 22);
			this.nuevoPedido.Text = "Nuevo...";
			this.nuevoPedido.Click += new System.EventHandler(this.nuevoPedido_Click);
			// 
			// productoToolStripMenuItem
			// 
			this.productoToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevoProducto,
            this.btnProductos});
			this.productoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
			this.productoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
			this.productoToolStripMenuItem.Text = "Producto";
			// 
			// btnNuevoProducto
			// 
			this.btnNuevoProducto.BackColor = System.Drawing.Color.White;
			this.btnNuevoProducto.ForeColor = System.Drawing.Color.Black;
			this.btnNuevoProducto.Name = "btnNuevoProducto";
			this.btnNuevoProducto.Size = new System.Drawing.Size(137, 22);
			this.btnNuevoProducto.Text = "Nuevo...";
			this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
			// 
			// btnProductos
			// 
			this.btnProductos.BackColor = System.Drawing.Color.White;
			this.btnProductos.ForeColor = System.Drawing.Color.Black;
			this.btnProductos.Name = "btnProductos";
			this.btnProductos.Size = new System.Drawing.Size(137, 22);
			this.btnProductos.Text = "Productos...";
			this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
			// 
			// tsmiUsuario
			// 
			this.tsmiUsuario.BackColor = System.Drawing.Color.White;
			this.tsmiUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogIn,
            this.btnLogOut,
            this.btnCambiarContrasenia,
            this.btnNuevoUsuario,
            this.btnUsuarios});
			this.tsmiUsuario.ForeColor = System.Drawing.Color.Black;
			this.tsmiUsuario.Name = "tsmiUsuario";
			this.tsmiUsuario.Size = new System.Drawing.Size(59, 20);
			this.tsmiUsuario.Text = "Usuario";
			// 
			// btnLogIn
			// 
			this.btnLogIn.BackColor = System.Drawing.Color.White;
			this.btnLogIn.ForeColor = System.Drawing.Color.Black;
			this.btnLogIn.Name = "btnLogIn";
			this.btnLogIn.Size = new System.Drawing.Size(180, 22);
			this.btnLogIn.Text = "Log In";
			this.btnLogIn.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
			// 
			// btnLogOut
			// 
			this.btnLogOut.BackColor = System.Drawing.Color.White;
			this.btnLogOut.ForeColor = System.Drawing.Color.Black;
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(180, 22);
			this.btnLogOut.Text = "Log Out";
			this.btnLogOut.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
			// 
			// btnCambiarContrasenia
			// 
			this.btnCambiarContrasenia.BackColor = System.Drawing.Color.White;
			this.btnCambiarContrasenia.ForeColor = System.Drawing.Color.Black;
			this.btnCambiarContrasenia.Name = "btnCambiarContrasenia";
			this.btnCambiarContrasenia.Size = new System.Drawing.Size(180, 22);
			this.btnCambiarContrasenia.Text = "Cambiar contraseña";
			this.btnCambiarContrasenia.Click += new System.EventHandler(this.cambiarContraseniaToolStripMenuItem_Click);
			// 
			// btnNuevoUsuario
			// 
			this.btnNuevoUsuario.BackColor = System.Drawing.Color.White;
			this.btnNuevoUsuario.ForeColor = System.Drawing.Color.Black;
			this.btnNuevoUsuario.Name = "btnNuevoUsuario";
			this.btnNuevoUsuario.Size = new System.Drawing.Size(180, 22);
			this.btnNuevoUsuario.Text = "Nuevo...";
			this.btnNuevoUsuario.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
			// 
			// btnUsuarios
			// 
			this.btnUsuarios.BackColor = System.Drawing.Color.White;
			this.btnUsuarios.ForeColor = System.Drawing.Color.Black;
			this.btnUsuarios.Name = "btnUsuarios";
			this.btnUsuarios.Size = new System.Drawing.Size(180, 22);
			this.btnUsuarios.Text = "Usuarios...";
			this.btnUsuarios.Click += new System.EventHandler(this.btnListaUsuarios_Click);
			// 
			// tsmiCaja
			// 
			this.tsmiCaja.BackColor = System.Drawing.Color.White;
			this.tsmiCaja.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositoToolStripMenuItem,
            this.extraccionToolStripMenuItem,
            this.movimientosToolStripMenuItem,
            this.limiteDeAlertaToolStripMenuItem});
			this.tsmiCaja.ForeColor = System.Drawing.Color.Black;
			this.tsmiCaja.Name = "tsmiCaja";
			this.tsmiCaja.Size = new System.Drawing.Size(42, 20);
			this.tsmiCaja.Text = "Caja";
			// 
			// depositoToolStripMenuItem
			// 
			this.depositoToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.depositoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.depositoToolStripMenuItem.Name = "depositoToolStripMenuItem";
			this.depositoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.depositoToolStripMenuItem.Text = "Depósito";
			this.depositoToolStripMenuItem.Click += new System.EventHandler(this.depositoToolStripMenuItem_Click);
			// 
			// extraccionToolStripMenuItem
			// 
			this.extraccionToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.extraccionToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.extraccionToolStripMenuItem.Name = "extraccionToolStripMenuItem";
			this.extraccionToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.extraccionToolStripMenuItem.Text = "Extracción";
			this.extraccionToolStripMenuItem.Click += new System.EventHandler(this.extraccionToolStripMenuItem_Click);
			// 
			// movimientosToolStripMenuItem
			// 
			this.movimientosToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.movimientosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
			this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.movimientosToolStripMenuItem.Text = "Movimientos";
			this.movimientosToolStripMenuItem.Click += new System.EventHandler(this.movimientosToolStripMenuItem_Click);
			// 
			// limiteDeAlertaToolStripMenuItem
			// 
			this.limiteDeAlertaToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.limiteDeAlertaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.limiteDeAlertaToolStripMenuItem.Name = "limiteDeAlertaToolStripMenuItem";
			this.limiteDeAlertaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.limiteDeAlertaToolStripMenuItem.Text = "Límite de Alerta...";
			this.limiteDeAlertaToolStripMenuItem.Click += new System.EventHandler(this.limiteDeAlertaToolStripMenuItem_Click);
			// 
			// cajaToolStripMenuItem
			// 
			this.cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
			this.cajaToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			this.cajaToolStripMenuItem.Text = "Caja";
			// 
			// PnlCaja
			// 
			this.PnlCaja.Controls.Add(this.PnlAlerta);
			this.PnlCaja.Controls.Add(this.TxtEstadoDeCaja);
			this.PnlCaja.Controls.Add(this.LblEstadoDeCaja);
			this.PnlCaja.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PnlCaja.Location = new System.Drawing.Point(0, 413);
			this.PnlCaja.Name = "PnlCaja";
			this.PnlCaja.Size = new System.Drawing.Size(632, 40);
			this.PnlCaja.TabIndex = 4;
			// 
			// PnlAlerta
			// 
			this.PnlAlerta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PnlAlerta.Controls.Add(this.PctAlertaCaja);
			this.PnlAlerta.Controls.Add(this.LblAlerta);
			this.PnlAlerta.Location = new System.Drawing.Point(429, 1);
			this.PnlAlerta.Name = "PnlAlerta";
			this.PnlAlerta.Size = new System.Drawing.Size(200, 36);
			this.PnlAlerta.TabIndex = 6;
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
			this.LblAlerta.ForeColor = System.Drawing.Color.Black;
			this.LblAlerta.Location = new System.Drawing.Point(41, 3);
			this.LblAlerta.Name = "LblAlerta";
			this.LblAlerta.Size = new System.Drawing.Size(142, 32);
			this.LblAlerta.TabIndex = 6;
			this.LblAlerta.Text = "Debe realizar una extracción";
			this.LblAlerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TxtEstadoDeCaja
			// 
			this.TxtEstadoDeCaja.BackColor = System.Drawing.Color.White;
			this.TxtEstadoDeCaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TxtEstadoDeCaja.Enabled = false;
			this.TxtEstadoDeCaja.ForeColor = System.Drawing.Color.Black;
			this.TxtEstadoDeCaja.Location = new System.Drawing.Point(87, 11);
			this.TxtEstadoDeCaja.Name = "TxtEstadoDeCaja";
			this.TxtEstadoDeCaja.ReadOnly = true;
			this.TxtEstadoDeCaja.Size = new System.Drawing.Size(100, 20);
			this.TxtEstadoDeCaja.TabIndex = 6;
			this.TxtEstadoDeCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// LblEstadoDeCaja
			// 
			this.LblEstadoDeCaja.ForeColor = System.Drawing.Color.Black;
			this.LblEstadoDeCaja.Location = new System.Drawing.Point(3, 3);
			this.LblEstadoDeCaja.Name = "LblEstadoDeCaja";
			this.LblEstadoDeCaja.Size = new System.Drawing.Size(78, 36);
			this.LblEstadoDeCaja.TabIndex = 5;
			this.LblEstadoDeCaja.Text = "Estado de caja";
			this.LblEstadoDeCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pedidosToolStripMenuItem
			// 
			this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
			this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.pedidosToolStripMenuItem.Text = "Pedidos...";
			this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
			// 
			// MenuPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.Add(this.PnlCaja);
			this.Controls.Add(this.menuStrip);
			this.ForeColor = System.Drawing.Color.Black;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MenuPrincipal";
			this.Text = "Heladería-Cafetería Kirschen";
			this.TransparencyKey = System.Drawing.Color.White;
			this.Activated += new System.EventHandler(this.MenuPrincipal_Activated);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
			this.Load += new System.EventHandler(this.MenuPrincipal_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.PnlCaja.ResumeLayout(false);
			this.PnlCaja.PerformLayout();
			this.PnlAlerta.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PctAlertaCaja)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion


		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiUsuario;
		private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiCaja;
		private System.Windows.Forms.ToolStripMenuItem depositoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem extraccionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem btnLogIn;
		private System.Windows.Forms.ToolStripMenuItem btnLogOut;
		private System.Windows.Forms.ToolStripMenuItem btnNuevoUsuario;
		private System.Windows.Forms.ToolStripMenuItem btnUsuarios;
		private System.Windows.Forms.ToolStripMenuItem btnCambiarContrasenia;
		private System.Windows.Forms.Panel PnlCaja;
		private System.Windows.Forms.PictureBox PctAlertaCaja;
		private System.Windows.Forms.Label LblAlerta;
		private System.Windows.Forms.TextBox TxtEstadoDeCaja;
		private System.Windows.Forms.Label LblEstadoDeCaja;
		private System.Windows.Forms.Panel PnlAlerta;
		private System.Windows.Forms.ToolStripMenuItem limiteDeAlertaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem btnNuevoProducto;
		private System.Windows.Forms.ToolStripMenuItem btnProductos;
		private System.Windows.Forms.ToolStripMenuItem nuevoPedido;
		private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
	}
}



