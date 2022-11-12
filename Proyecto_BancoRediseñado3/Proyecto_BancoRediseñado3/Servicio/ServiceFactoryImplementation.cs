using Proyecto_BancoRediseñado3.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BancoRediseñado3
{
    class ServiceFactoryImplementation : AbstractServiceFactoy
    {
        public override ICuentaService CrearGestorCuenta()
        {
            throw new NotImplementedException();
        }
    }
}
