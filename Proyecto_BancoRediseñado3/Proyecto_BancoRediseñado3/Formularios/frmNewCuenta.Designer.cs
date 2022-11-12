
namespace Proyecto_BancoRediseñado3
{
    partial class frmNewCuenta
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardarCuenta = new System.Windows.Forms.Button();
            this.dtpUltMov = new System.Windows.Forms.DateTimePicker();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoCuenta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCreandoCuenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(639, 360);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 37);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCuenta
            // 
            this.btnGuardarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCuenta.Location = new System.Drawing.Point(224, 294);
            this.btnGuardarCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarCuenta.Name = "btnGuardarCuenta";
            this.btnGuardarCuenta.Size = new System.Drawing.Size(169, 41);
            this.btnGuardarCuenta.TabIndex = 28;
            this.btnGuardarCuenta.Text = "Crear Cuenta";
            this.btnGuardarCuenta.UseVisualStyleBackColor = true;
            this.btnGuardarCuenta.Click += new System.EventHandler(this.btnGuardarCuenta_Click);
            // 
            // dtpUltMov
            // 
            this.dtpUltMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUltMov.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUltMov.Location = new System.Drawing.Point(339, 166);
            this.dtpUltMov.Margin = new System.Windows.Forms.Padding(4);
            this.dtpUltMov.Name = "dtpUltMov";
            this.dtpUltMov.Size = new System.Drawing.Size(207, 34);
            this.dtpUltMov.TabIndex = 26;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(339, 221);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(207, 34);
            this.txtSaldo.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Saldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Ultimo Movimiento:";
            // 
            // cboTipoCuenta
            // 
            this.cboTipoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoCuenta.FormattingEnabled = true;
            this.cboTipoCuenta.Location = new System.Drawing.Point(339, 99);
            this.cboTipoCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Size = new System.Drawing.Size(246, 37);
            this.cboTipoCuenta.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tipo de cuenta:";
            // 
            // lblCreandoCuenta
            // 
            this.lblCreandoCuenta.AutoSize = true;
            this.lblCreandoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreandoCuenta.Location = new System.Drawing.Point(46, 32);
            this.lblCreandoCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreandoCuenta.Name = "lblCreandoCuenta";
            this.lblCreandoCuenta.Size = new System.Drawing.Size(196, 32);
            this.lblCreandoCuenta.TabIndex = 30;
            this.lblCreandoCuenta.Text = "Nueva Cuenta";
            // 
            // frmNewCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 421);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardarCuenta);
            this.Controls.Add(this.dtpUltMov);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTipoCuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCreandoCuenta);
            this.Name = "frmNewCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Cuenta";
            this.Load += new System.EventHandler(this.frmNewCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardarCuenta;
        private System.Windows.Forms.DateTimePicker dtpUltMov;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipoCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreandoCuenta;
    }
}