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
    public partial class frmNewCuenta : Form
    {
        frmInformacion formInformacion;
    
        //Estado estado;
        GestorCuenta GCuenta;

        int doc;

        public frmNewCuenta(frmInformacion Informacion,int dni)
        {
            InitializeComponent();
            formInformacion = Informacion;
            doc = dni;
            GCuenta = new GestorCuenta();
        }

        private void frmNewCuenta_Load(object sender, EventArgs e)
        {
            CargarCBO();
        }

        private void CargarCBO()
        {
            DataTable tabla = GCuenta.ConsultarDB() ;
            cboTipoCuenta.DataSource = tabla;
            cboTipoCuenta.DisplayMember = tabla.Columns[1].ColumnName;
            cboTipoCuenta.ValueMember = tabla.Columns[0].ColumnName;
            cboTipoCuenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoCuenta.SelectedIndex = -1;
        }

        private void btnGuardarCuenta_Click(object sender, EventArgs e)
        {
            Cuenta c = new Cuenta();

            int dni = doc;
            DateTime ultMov = dtpUltMov.Value;
            int tipoCuenta = Convert.ToInt32(cboTipoCuenta.SelectedValue);
            int saldo = Convert.ToInt32(txtSaldo.Text);
            string estado = "A";

            if (GCuenta.CrearCuenta(saldo, tipoCuenta, ultMov, dni, estado))
            {
                MessageBox.Show("Se registro correctamente la cuenta");
                formInformacion.Visible = true;
                formInformacion.CargarDGV();
                this.Close();
            }
            else
                MessageBox.Show("La cuenta no ah podido ser creada");

        }

     
    }
}
