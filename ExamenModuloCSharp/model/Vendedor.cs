using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenModuloCSharp
{
    internal class Vendedor
    {
        // Atributos
        private string nombre;
        private string apellido;
        private string codigoVendedor;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string CodigoVendedor { get => codigoVendedor; set => codigoVendedor = value; }

        // Constructores
        public Vendedor() { }

        public Vendedor(string nombre, string apellido, string codigoVendedor)
        {
            Nombre = nombre;
            Apellido = apellido;
            CodigoVendedor = codigoVendedor;
        }
    }
}
