namespace Presentacion.Pedido
{
	partial class ListaPedidos
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
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.lblDesde = new System.Windows.Forms.Label();
			this.lblHasta = new System.Windows.Forms.Label();
			this.dtpDesde = new System.Windows.Forms.DateTimePicker();
			this.dtpHasta = new System.Windows.Forms.DateTimePicker();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.Controls.Add(this.lblDesde, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.lblHasta, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.dtpDesde, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.dtpHasta, 3, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 13);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(482, 27);
			this.tableLayoutPanel2.TabIndex = 6;
			// 
			// lblDesde
			// 
			this.lblDesde.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDesde.AutoSize = true;
			this.lblDesde.Location = new System.Drawing.Point(3, 7);
			this.lblDesde.Name = "lblDesde";
			this.lblDesde.Size = new System.Drawing.Size(41, 13);
			this.lblDesde.TabIndex = 0;
			this.lblDesde.Text = "Desde:";
			// 
			// lblHasta
			// 
			this.lblHasta.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblHasta.AutoSize = true;
			this.lblHasta.Location = new System.Drawing.Point(243, 7);
			this.lblHasta.Name = "lblHasta";
			this.lblHasta.Size = new System.Drawing.Size(38, 13);
			this.lblHasta.TabIndex = 1;
			this.lblHasta.Text = "Hasta:";
			// 
			// dtpDesde
			// 
			this.dtpDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpDesde.Location = new System.Drawing.Point(51, 3);
			this.dtpDesde.Name = "dtpDesde";
			this.dtpDesde.Size = new System.Drawing.Size(186, 20);
			this.dtpDesde.TabIndex = 2;
			this.dtpDesde.ValueChanged += new System.EventHandler(this.CargarEntidades);
			// 
			// dtpHasta
			// 
			this.dtpHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpHasta.Location = new System.Drawing.Point(291, 3);
			this.dtpHasta.Name = "dtpHasta";
			this.dtpHasta.Size = new System.Drawing.Size(188, 20);
			this.dtpHasta.TabIndex = 3;
			this.dtpHasta.ValueChanged += new System.EventHandler(this.CargarEntidades);
			// 
			// ListaPedidos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 301);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Name = "ListaPedidos";
			this.Text = "ListaPedidos";
			this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label lblDesde;
		private System.Windows.Forms.Label lblHasta;
		private System.Windows.Forms.DateTimePicker dtpDesde;
		private System.Windows.Forms.DateTimePicker dtpHasta;
	}
}