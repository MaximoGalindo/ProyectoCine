using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BancoRediseñado3
{
    class Parametros
    {
        public Parametros(string nombre, Object valor)
        {
            Nombre = nombre;
            Valor = valor;
        }
        public string Nombre { get; set; }
        public Object Valor { get; set; }
    }
}
