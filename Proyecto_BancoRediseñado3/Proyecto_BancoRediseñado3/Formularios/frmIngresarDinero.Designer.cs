
namespace Proyecto_BancoRediseñado3
{
    partial class frmIngresarDinero
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
            this.btnCancelarIngreso = new System.Windows.Forms.Button();
            this.btnAceptarIngreso = new System.Windows.Forms.Button();
            this.txtIngresoDinero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCreandoCuenta
            // 
            this.lblCreandoCuenta.AutoSize = true;
            this.lblCreandoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreandoCuenta.Location = new System.Drawing.Point(54, 49);
            this.lblCreandoCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreandoCuenta.Name = "lblCreandoCuenta";
            this.lblCreandoCuenta.Size = new System.Drawing.Size(209, 32);
            this.lblCreandoCuenta.TabIndex = 49;
            this.lblCreandoCuenta.Text = "Ingresar Dinero";
            // 
            // btnCancelarIngreso
            // 
            this.btnCancelarIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarIngreso.Location = new System.Drawing.Point(215, 224);
            this.btnCancelarIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarIngreso.Name = "btnCancelarIngreso";
            this.btnCancelarIngreso.Size = new System.Drawing.Size(121, 43);
            this.btnCancelarIngreso.TabIndex = 47;
            this.btnCancelarIngreso.Text = "Cancelar";
            this.btnCancelarIngreso.UseVisualStyleBackColor = true;
            this.btnCancelarIngreso.Click += new System.EventHandler(this.btnCancelarIngreso_Click);
            // 
            // btnAceptarIngreso
            // 
            this.btnAceptarIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarIngreso.Location = new System.Drawing.Point(388, 224);
            this.btnAceptarIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptarIngreso.Name = "btnAceptarIngreso";
            this.btnAceptarIngreso.Size = new System.Drawing.Size(124, 43);
            this.btnAceptarIngreso.TabIndex = 46;
            this.btnAceptarIngreso.Text = "Aceptar";
            this.btnAceptarIngreso.UseVisualStyleBackColor = true;
            this.btnAceptarIngreso.Click += new System.EventHandler(this.btnAceptarIngreso_Click);
            // 
            // txtIngresoDinero
            // 
            this.txtIngresoDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresoDinero.Location = new System.Drawing.Point(308, 131);
            this.txtIngresoDinero.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngresoDinero.Name = "txtIngresoDinero";
            this.txtIngresoDinero.Size = new System.Drawing.Size(236, 41);
            this.txtIngresoDinero.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 36);
            this.label4.TabIndex = 48;
            this.label4.Text = "Monto";
            // 
            // frmIngresarDinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 357);
            this.Controls.Add(this.lblCreandoCuenta);
            this.Controls.Add(this.btnCancelarIngreso);
            this.Controls.Add(this.btnAceptarIngreso);
            this.Controls.Add(this.txtIngresoDinero);
            this.Controls.Add(this.label4);
            this.Name = "frmIngresarDinero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Dinero";
            this.Load += new System.EventHandler(this.frmIngresarDinero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreandoCuenta;
        private System.Windows.Forms.Button btnCancelarIngreso;
        private System.Windows.Forms.Button btnAceptarIngreso;
        private System.Windows.Forms.TextBox txtIngresoDinero;
        private System.Windows.Forms.Label label4;
    }
}