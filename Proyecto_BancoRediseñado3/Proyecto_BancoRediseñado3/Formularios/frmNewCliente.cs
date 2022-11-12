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
    public partial class frmNewCliente : Form
    {
        frmPrincipal formPrincipal;

        GestorCliente GCliente;

        public List<Cliente> lClientes = new List<Cliente>();

        public frmNewCliente(frmPrincipal principal)
        {
            InitializeComponent();
            GCliente = new GestorCliente();
            formPrincipal = principal;

        }

        private void frmNewCliente_Load(object sender, EventArgs e)
        {
            CargarLista();
            formPrincipal.CargarLista();    
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

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Cliente c = new Cliente();
                c.DNI = Convert.ToInt32(txtDNINuevo.Text);
                c.Nombre = txtNombreNuevo.Text;
                c.Apellido = txtApellidoNuevo.Text;

                if (!existe(c))
                {
                    if (GCliente.CrearCliente(c))
                    {
                        MessageBox.Show("Cliente registrado");
                        formPrincipal.CargarLista();
                        CargarLista();
                        formPrincipal.Visible = true;
                        this.Close();
                    }                     
                }
                else
                    MessageBox.Show("Este cliente ya esta registrado");
            }
        }

        private bool existe(Cliente c)
        {
            for (int i = 0; i < lClientes.Count; i++)
            {
                if (lClientes[i].DNI == c.DNI)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidarDatos()
        {
            if (txtDNINuevo.Text == "")
            {
                MessageBox.Show("Debe ingresar un Documento");
                return false;
            }
            try
            {
                int.Parse(txtDNINuevo.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un dato numerico");
                return false;
            }

            if (txtNombreNuevo.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
                return false;
            }

            if (txtApellidoNuevo.Text == "")
            {
                MessageBox.Show("Debe ingresar un apellido");
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formPrincipal.Visible = true;
            this.Close();
        }
    }
}
