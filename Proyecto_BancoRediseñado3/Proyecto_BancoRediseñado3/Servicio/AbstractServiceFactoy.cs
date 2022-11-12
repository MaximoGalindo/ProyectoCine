using Proyecto_BancoRediseñado3.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BancoRediseñado3
{
    abstract class AbstractServiceFactoy
    {
        public abstract ICuentaService CrearGestorCuenta();
    }
}
