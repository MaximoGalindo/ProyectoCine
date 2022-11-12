using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BancoRediseñado3
{
    class GestorTransacciones
    {
        public bool RetiroDinero(Cuenta oCuenta)
        {
            HelperDAO helper = HelperDAO.ObtenerInstancia();

            List<Parametros> lParametros = new List<Parametros>();
            lParametros.Add(new Parametros("@cbu", oCuenta.CBU));
            lParametros.Add(new Parametros("@saldo", oCuenta.Saldo));
            lParametros.Add(new Parametros("@ultMov", oCuenta.UltimoMovimiento));

            if (helper.Transaccion("SP_retirarDinero", lParametros) > 0)
                return true;
            else
                return false;
             
        }

        public bool IngresoDinero(Cuenta oCuenta)
        {
            HelperDAO helper = HelperDAO.ObtenerInstancia();

            List<Parametros> lParametros = new List<Parametros>();
            lParametros.Add(new Parametros("@cbu", oCuenta.CBU));
            lParametros.Add(new Parametros("@saldo", oCuenta.Saldo));
            lParametros.Add(new Parametros("@ultMov", oCuenta.UltimoMovimiento));

            if (helper.Transaccion("SP_ingresarDinero", lParametros) > 0)
                return true;
            else
                return false;

        }

    }
}
