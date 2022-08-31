using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenModuloCSharp
{
    internal class Prenda
    {
        // Atributos
        private string calidad;
        private int precioUnitario;
        private int cantidadStock;

        public string Calidad { get => calidad; set => calidad = value; }
        public int PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int CantidadStock { get => cantidadStock; set => cantidadStock = value; }

        // Constructores
        public Prenda() { }

        public Prenda(string calidad, int cantidadStock, int precioUnitario)
        {
            Calidad = calidad;
            PrecioUnitario = precioUnitario;
            CantidadStock = cantidadStock;
        }

        public Prenda(string calidad, int cantidadStock)
        {
            Calidad = calidad;
            CantidadStock = cantidadStock;
        }


    }
}
