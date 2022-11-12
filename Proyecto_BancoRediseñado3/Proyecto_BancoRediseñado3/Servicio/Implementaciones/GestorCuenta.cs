using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto_BancoRediseñado3.Servicio.Interface;
using Proyecto_BancoRediseñado3.DataAcces.Implementaciones;
using Proyecto_BancoRediseñado3.DataAcces.Interfaces;

namespace Proyecto_BancoRediseñado3
{
    class GestorCuenta
    {
        Cliente cliente = new Cliente();

        public DataTable ConsultarDB()
        {
            return HelperDAO.ObtenerInstancia().ConsultarDB("SP_TipoCuenta");
        }

        public bool CrearCuenta(double saldo, int tipoCuenta, DateTime ultMov, int dni, string estado)
        {
            HelperDAO helper = HelperDAO.ObtenerInstancia();

            Cuenta cuenta = new Cuenta(saldo, tipoCuenta, ultMov, dni, estado);
            cliente.AgregarCuenta(cuenta);

            List<Parametros> lParametros = new List<Parametros>();
            lParametros.Add(new Parametros("@saldo", saldo));
            lParametros.Add(new Parametros("@tipoCuenta", tipoCuenta));
            lParametros.Add(new Parametros("@ultMov", ultMov));
            lParametros.Add(new Parametros("@dni", dni));
            lParametros.Add(new Parametros("@estado", estado));

            if (helper.Transaccion("SP_insertCuenta", lParametros) > 0)
                return true;
            else
                return false;
        }
    }
}
