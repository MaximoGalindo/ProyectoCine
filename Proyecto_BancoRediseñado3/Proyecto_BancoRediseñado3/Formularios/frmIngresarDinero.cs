    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_BancoRediseñado3
{
    public partial class frmIngresarDinero : Form
    {
        frmInformacion formInformacion;

        GestorTransacciones GTransacciones;

        int Cbu;
        int documento;

        public frmIngresarDinero(frmInformacion informacion,int cbu,int dni)
        {
            InitializeComponent();
            formInformacion = informacion;
            Cbu = cbu;
            documento = dni;
            GTransacciones = new GestorTransacciones();
        }

        private void frmIngresarDinero_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptarIngreso_Click(object sender, EventArgs e)
        {
            Cuenta c = new Cuenta();
            c.CBU = Cbu;
            c.Saldo = Convert.ToDouble(txtIngresoDinero.Text);
            c.UltimoMovimiento = DateTime.Now;

            if (GTransacciones.IngresoDinero(c))
            {
                MessageBox.Show("Se ingreso correctamente");
                formInformacion.CargarDGV();
                formInformacion.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el ingreso del dinero");
            }
        }

        private void btnCancelarIngreso_Click(object sender, EventArgs e)
        {
            formInformacion.Visible = true;
            this.Close();
        }
    }
}
