namespace Presentacion.Caja
{
    partial class ListaMovimientosRango
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
			this.BtnAceptar = new System.Windows.Forms.Button();
			this.LblDesde = new System.Windows.Forms.Label();
			this.DateTimeDesde = new System.Windows.Forms.DateTimePicker();
			this.DateTimeHasta = new System.Windows.Forms.DateTimePicker();
			this.LblHasta = new System.Windows.Forms.Label();
			this.BtnCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BtnAceptar
			// 
			this.BtnAceptar.Location = new System.Drawing.Point(15, 64);
			this.BtnAceptar.Name = "BtnAceptar";
			this.BtnAceptar.Size = new System.Drawing.Size(257, 23);
			this.BtnAceptar.TabIndex = 0;
			this.BtnAceptar.Text = "Aceptar";
			this.BtnAceptar.UseVisualStyleBackColor = true;
			this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
			// 
			// LblDesde
			// 
			this.LblDesde.AutoSize = true;
			this.LblDesde.Location = new System.Drawing.Point(12, 18);
			this.LblDesde.Name = "LblDesde";
			this.LblDesde.Size = new System.Drawing.Size(38, 13);
			this.LblDesde.TabIndex = 1;
			this.LblDesde.Text = "Desde";
			// 
			// DateTimeDesde
			// 
			this.DateTimeDesde.Location = new System.Drawing.Point(72, 12);
			this.DateTimeDesde.Name = "DateTimeDesde";
			this.DateTimeDesde.Size = new System.Drawing.Size(200, 20);
			this.DateTimeDesde.TabIndex = 3;
			// 
			// DateTimeHasta
			// 
			this.DateTimeHasta.Location = new System.Drawing.Point(72, 38);
			this.DateTimeHasta.Name = "DateTimeHasta";
			this.DateTimeHasta.Size = new System.Drawing.Size(200, 20);
			this.DateTimeHasta.TabIndex = 5;
			// 
			// LblHasta
			// 
			this.LblHasta.AutoSize = true;
			this.LblHasta.Location = new System.Drawing.Point(12, 44);
			this.LblHasta.Name = "LblHasta";
			this.LblHasta.Size = new System.Drawing.Size(35, 13);
			this.LblHasta.TabIndex = 4;
			this.LblHasta.Text = "Hasta";
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.Location = new System.Drawing.Point(15, 93);
			this.BtnCancelar.Name = "BtnCancelar";
			this.BtnCancelar.Size = new System.Drawing.Size(257, 23);
			this.BtnCancelar.TabIndex = 6;
			this.BtnCancelar.Text = "Cancelar";
			this.BtnCancelar.UseVisualStyleBackColor = true;
			this.BtnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// ListaMovimientosRango
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.BtnCancelar);
			this.Controls.Add(this.DateTimeHasta);
			this.Controls.Add(this.LblHasta);
			this.Controls.Add(this.DateTimeDesde);
			this.Controls.Add(this.LblDesde);
			this.Controls.Add(this.BtnAceptar);
			this.Name = "ListaMovimientosRango";
			this.Text = "Movimientos de caja";
			this.Load += new System.EventHandler(this.ListaMovimientosRango_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblDesde;
        private System.Windows.Forms.DateTimePicker DateTimeDesde;
        private System.Windows.Forms.DateTimePicker DateTimeHasta;
        private System.Windows.Forms.Label LblHasta;
        private System.Windows.Forms.Button BtnCancelar;
    }
}