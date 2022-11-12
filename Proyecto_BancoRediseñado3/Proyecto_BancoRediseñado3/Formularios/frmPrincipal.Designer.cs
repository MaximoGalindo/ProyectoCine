
namespace Proyecto_BancoRediseñado3
{
    partial class frmPrincipal
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.btnInicarSesion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(580, 386);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(121, 40);
            this.btn_Salir.TabIndex = 28;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // txtDoc
            // 
            this.txtDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoc.Location = new System.Drawing.Point(216, 126);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(237, 30);
            this.txtDoc.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Registrar nuevo cliente";
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCliente.Location = new System.Drawing.Point(183, 303);
            this.btnRegistrarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(302, 50);
            this.btnRegistrarCliente.TabIndex = 24;
            this.btnRegistrarCliente.Text = "Registrar nuevo Cliente";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // btnInicarSesion
            // 
            this.btnInicarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicarSesion.Location = new System.Drawing.Point(266, 172);
            this.btnInicarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnInicarSesion.Name = "btnInicarSesion";
            this.btnInicarSesion.Size = new System.Drawing.Size(121, 40);
            this.btnInicarSesion.TabIndex = 23;
            this.btnInicarSesion.Text = "Aceptar";
            this.btnInicarSesion.UseVisualStyleBackColor = true;
            this.btnInicarSesion.Click += new System.EventHandler(this.btnInicarSesion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "INICIAR SESION";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 36);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Checked = true;
            this.verToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informeToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.verToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(54, 32);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // informeToolStripMenuItem
            // 
            this.informeToolStripMenuItem.Name = "informeToolStripMenuItem";
            this.informeToolStripMenuItem.Size = new System.Drawing.Size(167, 32);
            this.informeToolStripMenuItem.Text = "Informe";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(167, 32);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 473);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Controls.Add(this.btnInicarSesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.Button btnInicarSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
    }
}

