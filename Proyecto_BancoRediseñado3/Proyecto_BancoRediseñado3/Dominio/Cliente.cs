using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BancoRediseñado3
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { set; get; }

        public List<Cuenta> lCuentas = new List<Cuenta>();
            
        public Cliente()
        {
            DNI = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
        }

        public Cliente(string nombre, string apellido, int Dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = Dni;
        }
            
        public void AgregarCuenta(Cuenta c)
        {
            lCuentas.Add(c);
        }

        public void QuitarCuenta(int indice)
        {
            lCuentas.RemoveAt(indice);
        }

        public override string ToString()
        {
            return DNI + " " + Nombre + " " + Apellido;
        }
    }
}
