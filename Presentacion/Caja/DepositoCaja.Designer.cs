namespace Presentacion.Caja
{
    partial class DepositoCaja
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
			this.LblMonto = new System.Windows.Forms.Label();
			this.NumMonto = new System.Windows.Forms.NumericUpDown();
			this.BtnAceptar = new System.Windows.Forms.Button();
			this.LblRazon = new System.Windows.Forms.Label();
			this.TxtRazon = new System.Windows.Forms.TextBox();
			this.BtnCancelar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.NumMonto)).BeginInit();
			this.SuspendLayout();
			// 
			// LblMonto
			// 
			this.LblMonto.AutoSize = true;
			this.LblMonto.Location = new System.Drawing.Point(12, 9);
			this.LblMonto.Name = "LblMonto";
			this.LblMonto.Size = new System.Drawing.Size(37, 13);
			this.LblMonto.TabIndex = 0;
			this.LblMonto.Text = "Monto";
			// 
			// NumMonto
			// 
			this.NumMonto.DecimalPlaces = 2;
			this.NumMonto.Location = new System.Drawing.Point(152, 7);
			this.NumMonto.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.NumMonto.Name = "NumMonto";
			this.NumMonto.Size = new System.Drawing.Size(120, 20);
			this.NumMonto.TabIndex = 2;
			this.NumMonto.ThousandsSeparator = true;
			// 
			// BtnAceptar
			// 
			this.BtnAceptar.Location = new System.Drawing.Point(12, 197);
			this.BtnAceptar.Name = "BtnAceptar";
			this.BtnAceptar.Size = new System.Drawing.Size(260, 23);
			this.BtnAceptar.TabIndex = 3;
			this.BtnAceptar.Text = "Aceptar";
			this.BtnAceptar.UseVisualStyleBackColor = true;
			this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
			// 
			// LblRazon
			// 
			this.LblRazon.AutoSize = true;
			this.LblRazon.Location = new System.Drawing.Point(12, 30);
			this.LblRazon.Name = "LblRazon";
			this.LblRazon.Size = new System.Drawing.Size(38, 13);
			this.LblRazon.TabIndex = 4;
			this.LblRazon.Text = "Razón";
			// 
			// TxtRazon
			// 
			this.TxtRazon.Location = new System.Drawing.Point(12, 46);
			this.TxtRazon.Multiline = true;
			this.TxtRazon.Name = "TxtRazon";
			this.TxtRazon.Size = new System.Drawing.Size(260, 145);
			this.TxtRazon.TabIndex = 5;
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.Location = new System.Drawing.Point(12, 226);
			this.BtnCancelar.Name = "BtnCancelar";
			this.BtnCancelar.Size = new System.Drawing.Size(260, 23);
			this.BtnCancelar.TabIndex = 6;
			this.BtnCancelar.Text = "Cancelar";
			this.BtnCancelar.UseVisualStyleBackColor = true;
			this.BtnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// DepositoCaja
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.BtnCancelar);
			this.Controls.Add(this.TxtRazon);
			this.Controls.Add(this.LblRazon);
			this.Controls.Add(this.BtnAceptar);
			this.Controls.Add(this.NumMonto);
			this.Controls.Add(this.LblMonto);
			this.Name = "DepositoCaja";
			this.Text = "Deposito caja";
			((System.ComponentModel.ISupportInitialize)(this.NumMonto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMonto;
        private System.Windows.Forms.NumericUpDown NumMonto;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblRazon;
        private System.Windows.Forms.TextBox TxtRazon;
        private System.Windows.Forms.Button BtnCancelar;
    }
}