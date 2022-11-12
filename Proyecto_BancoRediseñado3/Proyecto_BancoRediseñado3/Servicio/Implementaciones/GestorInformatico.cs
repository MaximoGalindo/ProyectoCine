using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Proyecto_BancoRediseñado3
{
    class GestorInformatico
    {
        public DataTable MostrarNombre(int dni)
        {
            HelperDAO helper = HelperDAO.ObtenerInstancia();
            return helper.ConsultaDBParametros("cargarCliente", "@dni", dni);  
        }

        public DataTable CargarCuentaClientes(int dni)
        {
            HelperDAO helper = HelperDAO.ObtenerInstancia();
            return helper.ConsultaDBParametros("cargarCuentaCliente", "@dni", dni);
        }

        public bool BajaLogica(int cbu,string estado)
        {
            HelperDAO helper = HelperDAO.ObtenerInstancia();
            if (helper.BajaLogica(cbu, estado) > 0)
                return true;
            else
                return false;
        }

    }
}
