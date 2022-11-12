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
    public partial class frmInformacion : Form
    {
        frmPrincipal formPrincipal;
        frmNewCuenta formCuenta;
        frmIngresarDinero formIngresoDinero;
        frmRetirarDinero formRetirar;

        GestorInformatico GInformatico;

        int documento;

        public frmInformacion(int dni)
        {
            InitializeComponent();
            GInformatico = new GestorInformatico();

            documento = dni;

            formCuenta = new frmNewCuenta(this, documento);
            formIngresoDinero = new frmIngresarDinero(this, Cbu(), documento);
            formRetirar = new frmRetirarDinero(this, Cbu(), SaldoDisponible(), documento);
        }

        public frmInformacion(frmPrincipal principal, int dni)
        {
            InitializeComponent();           
            formPrincipal = principal;
            documento = dni;

            GInformatico = new GestorInformatico();
        }

        private void frmInformacion_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "Informacion de: " + cargarNombre();
            CargarDGV();
            btn_RetirarDinero.Enabled = false;
            btn_ingresarDinero.Enabled = false;
        }

        public string cargarNombre()
        {
            DataTable tabla = GInformatico.MostrarNombre(documento);
            string nombre = "";
            nombre = tabla.Rows[0][1].ToString() + " " + tabla.Rows[0][2].ToString();
            return nombre;
        }

        public void CargarDGV()
        {
            dgvCuentasClientes.Rows.Clear();
            dataGridView1.Rows.Clear();

            DataTable tabla = GInformatico.CargarCuentaClientes(documento);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                string CBU = (tabla.Rows[i][0].ToString());
                string saldo = tabla.Rows[i][1].ToString();
                string tipoCuenta = tabla.Rows[i][2].ToString();
                string UltimoMovimiento = tabla.Rows[i][3].ToString();
                string estado = tabla.Rows[i][4].ToString();

                if (estado == "A")
                    dgvCuentasClientes.Rows.Add(CBU, saldo, tipoCuenta, UltimoMovimiento, estado);
                else if (estado == "B")
                    dataGridView1.Rows.Add(CBU, saldo, tipoCuenta, UltimoMovimiento, estado);
            }
        }

        public int Cbu()
        {
            int cbu = 0;
            cbu = Convert.ToInt32(dgvCuentasClientes.CurrentRow.Cells[0].Value.ToString());
            return cbu;
        }

        public int CbuDesabilitado()
        {
            int cbu = 0;
            cbu = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            return cbu;
        }

        public double SaldoDisponible()
        {
            double saldo = 0;
            saldo = Convert.ToDouble(dgvCuentasClientes.CurrentRow.Cells[1].Value.ToString());
            return saldo;
        }

        private void dgvCuentasClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Cuenta c = new Cuenta();
            c.CBU = Cbu();
            c.Estado = "A";

            btn_ingresarDinero.Enabled = true;
            btn_RetirarDinero.Enabled = true;

            if (dgvCuentasClientes.CurrentCell.ColumnIndex == 5)
            {
                if (MessageBox.Show("¿Estas seguro que quieres desabilitar esta cuenta?", "Desabilitar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (GInformatico.BajaLogica(c.CBU, "B"))
                    {
                        c.Estado = "B";
                        MessageBox.Show("Se desabilito correctamente");
                        dgvCuentasClientes.Rows.Clear();
                        CargarDGV();
                    }
                    else
                    {
                        MessageBox.Show("AH ocurrido un error");
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cuenta c = new Cuenta();
            c.CBU = CbuDesabilitado();
            c.Estado = "B";

            if (dataGridView1.CurrentCell.ColumnIndex == 5)
            {
                if (MessageBox.Show("¿Estas seguro que quieres habilitar esta cuenta?", "Desabilitar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (GInformatico.BajaLogica(c.CBU, "A"))
                    {
                        c.Estado = "A";
                        MessageBox.Show("Se habilito correctamente");
                        dataGridView1.Rows.Clear();
                        CargarDGV();

                    }
                    else
                    {
                        MessageBox.Show("AH ocurrido un error");
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dataGridView1.Visible = true;
                dgvCuentasClientes.Visible = false;
                dataGridView1.Rows.Clear();
                CargarDGV();
                btn_ingresarDinero.Enabled = false;
                btn_RetirarDinero.Enabled = false;
            }
            else
            {
                dataGridView1.Visible = false;
                dgvCuentasClientes.Visible = true;
                dgvCuentasClientes.Rows.Clear();
                CargarDGV();
            }
        }

        private void BTN_NuevaCuenta_Click(object sender, EventArgs e)
        {
            formCuenta = new frmNewCuenta(this, documento);
            formCuenta.Visible = true;
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                formPrincipal.Visible = true;
                this.Close();
            }
        }

        private void btn_RetirarDinero_Click(object sender, EventArgs e)
        {
            formRetirar = new frmRetirarDinero(this, Cbu(), SaldoDisponible(), documento);
            formRetirar.Visible = true;
            this.Hide();
        }

        private void btn_ingresarDinero_Click(object sender, EventArgs e)
        {

            formIngresoDinero = new frmIngresarDinero(this, Cbu(), documento);
            formIngresoDinero.Visible = true;
            this.Hide();
        }
    }
}
