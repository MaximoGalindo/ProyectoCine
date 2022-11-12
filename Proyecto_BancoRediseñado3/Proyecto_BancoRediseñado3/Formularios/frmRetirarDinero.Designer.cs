
namespace Proyecto_BancoRediseñado3
{
    partial class frmRetirarDinero
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
            this.lblCreandoCuenta = new System.Windows.Forms.Label();
            this.btnCancelarEgreso = new System.Windows.Forms.Button();
            this.btnAceptarEgreso = new System.Windows.Forms.Button();
            this.txtRetirarDInero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCreandoCuenta
            // 
            this.lblCreandoCuenta.AutoSize = true;
            this.lblCreandoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreandoCuenta.Location = new System.Drawing.Point(52, 68);
            this.lblCreandoCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreandoCuenta.Name = "lblCreandoCuenta";
            this.lblCreandoCuenta.Size = new System.Drawing.Size(191, 32);
            this.lblCreandoCuenta.TabIndex = 54;
            this.lblCreandoCuenta.Text = "Retirar Dinero";
            // 
            // btnCancelarEgreso
            // 
            this.btnCancelarEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEgreso.Location = new System.Drawing.Point(203, 248);
            this.btnCancelarEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarEgreso.Name = "btnCancelarEgreso";
            this.btnCancelarEgreso.Size = new System.Drawing.Size(121, 43);
            this.btnCancelarEgreso.TabIndex = 52;
            this.btnCancelarEgreso.Text = "Cancelar";
            this.btnCancelarEgreso.UseVisualStyleBackColor = true;
            this.btnCancelarEgreso.Click += new System.EventHandler(this.btnCancelarEgreso_Click);
            // 
            // btnAceptarEgreso
            // 
            this.btnAceptarEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarEgreso.Location = new System.Drawing.Point(376, 248);
            this.btnAceptarEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptarEgreso.Name = "btnAceptarEgreso";
            this.btnAceptarEgreso.Size = new System.Drawing.Size(124, 43);
            this.btnAceptarEgreso.TabIndex = 51;
            this.btnAceptarEgreso.Text = "Aceptar";
            this.btnAceptarEgreso.UseVisualStyleBackColor = true;
            this.btnAceptarEgreso.Click += new System.EventHandler(this.btnAceptarEgreso_Click);
            // 
            // txtRetirarDInero
            // 
            this.txtRetirarDInero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetirarDInero.Location = new System.Drawing.Point(296, 155);
            this.txtRetirarDInero.Margin = new System.Windows.Forms.Padding(4);
            this.txtRetirarDInero.Name = "txtRetirarDInero";
            this.txtRetirarDInero.Size = new System.Drawing.Size(236, 41);
            this.txtRetirarDInero.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 36);
            this.label4.TabIndex = 53;
            this.label4.Text = "Monto";
            // 
            // frmRetirarDinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 389);
            this.Controls.Add(this.lblCreandoCuenta);
            this.Controls.Add(this.btnCancelarEgreso);
            this.Controls.Add(this.btnAceptarEgreso);
            this.Controls.Add(this.txtRetirarDInero);
            this.Controls.Add(this.label4);
            this.Name = "frmRetirarDinero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retirar Dinero";
            this.Load += new System.EventHandler(this.frmRetirarDinero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreandoCuenta;
        private System.Windows.Forms.Button btnCancelarEgreso;
        private System.Windows.Forms.Button btnAceptarEgreso;
        private System.Windows.Forms.TextBox txtRetirarDInero;
        private System.Windows.Forms.Label label4;
    }
}