namespace Presentacion.Caja
{
	partial class ConfigurarLimiteCaja
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
			this.lblDescripcion = new System.Windows.Forms.Label();
			this.lblLimite = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.nudLimite = new System.Windows.Forms.NumericUpDown();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudLimite)).BeginInit();
			this.SuspendLayout();
			// 
			// lblDescripcion
			// 
			this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDescripcion.Location = new System.Drawing.Point(13, 33);
			this.lblDescripcion.Name = "lblDescripcion";
			this.lblDescripcion.Size = new System.Drawing.Size(233, 54);
			this.lblDescripcion.TabIndex = 0;
			this.lblDescripcion.Text = "La alerta se emitirá cuando el dinero en caja supere el límite ingresado.";
			this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblLimite
			// 
			this.lblLimite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLimite.AutoSize = true;
			this.lblLimite.Location = new System.Drawing.Point(13, 13);
			this.lblLimite.Name = "lblLimite";
			this.lblLimite.Size = new System.Drawing.Size(48, 13);
			this.lblLimite.TabIndex = 1;
			this.lblLimite.Text = "Límite: $";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 91);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(233, 31);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAceptar.Location = new System.Drawing.Point(3, 4);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(110, 23);
			this.btnAceptar.TabIndex = 0;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.Location = new System.Drawing.Point(119, 4);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(111, 23);
			this.btnCancelar.TabIndex = 1;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// nudLimite
			// 
			this.nudLimite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudLimite.DecimalPlaces = 2;
			this.nudLimite.Location = new System.Drawing.Point(67, 10);
			this.nudLimite.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
			this.nudLimite.Name = "nudLimite";
			this.nudLimite.Size = new System.Drawing.Size(176, 20);
			this.nudLimite.TabIndex = 4;
			// 
			// ConfigurarLimiteCaja
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(258, 134);
			this.Controls.Add(this.nudLimite);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.lblLimite);
			this.Controls.Add(this.lblDescripcion);
			this.Name = "ConfigurarLimiteCaja";
			this.Text = "Configurar Límite de Caja";
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudLimite)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDescripcion;
		private System.Windows.Forms.Label lblLimite;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.NumericUpDown nudLimite;
	}
}