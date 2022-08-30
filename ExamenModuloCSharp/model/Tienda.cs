using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenModuloCSharp.model
{
    internal class Tienda
    {
        private string nombre;
        private string direccion;
        private List<Prenda> prendas;
        private Vendedor vendedor;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public List<Prenda> Prendas { get => prendas; set => prendas = value; }
        public Vendedor Vendedor { get => vendedor; set => vendedor = value; }

        public void agregarPrenda(Prenda prenda)
        {
            this.Prendas.Add(prenda);
        }

        public Tienda() { }

        public Tienda(string nombre)
        {
            Nombre = nombre;
        }

        public Tienda(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;  
        }
    }
}
