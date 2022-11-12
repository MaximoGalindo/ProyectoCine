
namespace Proyecto_BancoRediseñado3
{
    partial class frmNewCliente
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.txtApellidoNuevo = new System.Windows.Forms.TextBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.txtDNINuevo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCreandoCuenta
            // 
            this.lblCreandoCuenta.AutoSize = true;
            this.lblCreandoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreandoCuenta.Location = new System.Drawing.Point(35, 45);
            this.lblCreandoCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreandoCuenta.Name = "lblCreandoCuenta";
            this.lblCreandoCuenta.Size = new System.Drawing.Size(194, 32);
            this.lblCreandoCuenta.TabIndex = 44;
            this.lblCreandoCuenta.Text = "Nuevo Cliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(237, 358);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 43);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCliente.Location = new System.Drawing.Point(414, 358);
            this.btnCrearCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(124, 43);
            this.btnCrearCliente.TabIndex = 39;
            this.btnCrearCliente.Text = "Aceptar";
            this.btnCrearCliente.UseVisualStyleBackColor = true;
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);
            // 
            // txtApellidoNuevo
            // 
            this.txtApellidoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoNuevo.Location = new System.Drawing.Point(326, 242);
            this.txtApellidoNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoNuevo.Name = "txtApellidoNuevo";
            this.txtApellidoNuevo.Size = new System.Drawing.Size(236, 41);
            this.txtApellidoNuevo.TabIndex = 38;
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreNuevo.Location = new System.Drawing.Point(326, 185);
            this.txtNombreNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(236, 41);
            this.txtNombreNuevo.TabIndex = 37;
            // 
            // txtDNINuevo
            // 
            this.txtDNINuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNINuevo.Location = new System.Drawing.Point(326, 127);
            this.txtDNINuevo.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNINuevo.Name = "txtDNINuevo";
            this.txtDNINuevo.Size = new System.Drawing.Size(236, 41);
            this.txtDNINuevo.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 36);
            this.label4.TabIndex = 43;
            this.label4.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 36);
            this.label3.TabIndex = 42;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 36);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nombre";
            // 
            // frmNewCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 463);
            this.Controls.Add(this.lblCreandoCuenta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrearCliente);
            this.Controls.Add(this.txtApellidoNuevo);
            this.Controls.Add(this.txtNombreNuevo);
            this.Controls.Add(this.txtDNINuevo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmNewCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewCliente";
            this.Load += new System.EventHandler(this.frmNewCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreandoCuenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrearCliente;
        private System.Windows.Forms.TextBox txtApellidoNuevo;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.TextBox txtDNINuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}