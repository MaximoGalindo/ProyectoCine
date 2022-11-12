using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Proyecto_BancoRediseñado3
{
    class GestorCliente
    {       
        public DataTable CargarCliente()
        {
            HelperDAO helper = HelperDAO.ObtenerInstancia();
            return helper.ConsultarDB("SP_lstClientes");
        }

        public bool CrearCliente(Cliente oCliente)
        {
            HelperDAO helper = HelperDAO.ObtenerInstancia();

            List<Parametros> lParametros = new List<Parametros>();
            lParametros.Add(new Parametros("@dni", oCliente.DNI));
            lParametros.Add(new Parametros("@nombre", oCliente.Nombre));
            lParametros.Add(new Parametros("@apellido", oCliente.Apellido));

            if (helper.Transaccion("SP_insertCliente", lParametros) > 0)
                return true;
            else
                return false;
        }

    }
}
