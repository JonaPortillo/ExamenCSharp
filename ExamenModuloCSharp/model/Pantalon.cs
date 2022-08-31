using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenModuloCSharp
{
    internal class Pantalon : Prenda
    {
        // Atributos
        private string tipo;

        public string Tipo { get => tipo; set => tipo = value; }

        // Constructores
        public Pantalon() : base() { }

        public Pantalon(string tipo) : base() {
            Tipo = tipo;
        }

        public Pantalon(string tipo, string calidad, int cantidadStock) : base(calidad, cantidadStock)
        {
            Tipo = tipo;
        }
    }
}
