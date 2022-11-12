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
    public partial class frmPrincipal : Form
    {
        frmInformacion formInformacion;
        frmNewCliente formCliente;

        GestorCliente GCliente;

        List<Cliente> lClientes = new List<Cliente>();

        public frmPrincipal()
        {
            InitializeComponent();
            formCliente = new frmNewCliente(this);
            GCliente = new GestorCliente();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        private bool existe()
        {
            int Documento = Convert.ToInt32(txtDoc.Text);
            for (int i = 0; i < lClientes.Count; i++)
            {
                if (lClientes[i].DNI == Documento)
                {
                    return true;
                }
            }
            return false;
        }

        public void CargarLista()
        {
            DataTable tabla = GCliente.CargarCliente();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Cliente c = new Cliente();
                c.DNI = Convert.ToInt32(tabla.Rows[i][0]);
                c.Nombre = tabla.Rows[i][1].ToString();
                c.Apellido = tabla.Rows[i][2].ToString();

                lClientes.Add(c);
            }
        }


        private void btnInicarSesion_Click(object sender, EventArgs e)
        {
            if (existe())
            {
                formInformacion = new frmInformacion(this, Convert.ToInt32(txtDoc.Text));
                txtDoc.Text = "";
                formInformacion.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("El cliente no esta registrado");
            }
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            formCliente.Visible = true;
            this.Hide();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
