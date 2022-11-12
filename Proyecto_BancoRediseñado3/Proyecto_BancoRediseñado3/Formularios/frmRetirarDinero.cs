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
    public partial class frmRetirarDinero : Form
    {
        frmInformacion formInformacion;

        GestorTransacciones GTransacciones;

        int Cbu;
        double Saldo;
        int documento;

        public frmRetirarDinero(frmInformacion Informacion,int cbu, double saldo,int dni)
        {
            InitializeComponent();
            formInformacion = Informacion;
            GTransacciones = new GestorTransacciones();
            Cbu = cbu;
            Saldo = saldo;
            documento = dni;
        }

        private void frmRetirarDinero_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptarEgreso_Click(object sender, EventArgs e)
        {
            Cuenta c = new Cuenta();
            c.CBU = Cbu;
            c.Saldo = Convert.ToDouble(txtRetirarDInero.Text);
            c.UltimoMovimiento = DateTime.Now;

            if (c.Saldo <= Saldo)
            {
                if (GTransacciones.RetiroDinero(c))
                {
                    MessageBox.Show("Se retiro correctamente");
                    formInformacion.CargarDGV();
                    formInformacion.Visible = true;
                    this.Close();
                }
                else
                    MessageBox.Show("Ocurrio un error al Retirar Dinero");
            }
            else
                MessageBox.Show("El dinero en la cuenta no es suficiente");               
        }

        private void btnCancelarEgreso_Click(object sender, EventArgs e)
        {
            formInformacion.Visible = true;
            this.Close();
        }
    }
}
