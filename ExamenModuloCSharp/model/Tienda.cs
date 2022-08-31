using System;
using System.Collections;
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
        private List<Cotizacion> cotizaciones = new List<Cotizacion>();

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public List<Prenda> Prendas { get => prendas; set => prendas = value; }
        public Vendedor Vendedor { get => vendedor; set => vendedor = value; }
        internal List<Cotizacion> Cotizaciones { get => cotizaciones; set => cotizaciones = value; }

        public void agregarPrenda(Prenda prenda)
        {
            this.prendas.Add((Prenda)prenda);
        }

        public Tienda() { }

        public Tienda(string nombre)
        {
            Nombre = nombre;
            Prendas = new List<Prenda>();
            Direccion = "";
        }

        public Tienda(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
            Prendas = new List<Prenda>();
        }

        public int StockDisponible(string prenda, string calidad, string[] caracteristicas)
        {
            int stock = 0;
            if (prenda == "Camisa")
            {
                foreach (Prenda p in this.Prendas)
                {
                    Type tipo = p.GetType();
                    if (tipo.Name == "Camisa")
                    {
                        Camisa pCamisa = (Camisa)p;
                        if (p.Calidad == calidad && pCamisa.Cuello == caracteristicas[0] && pCamisa.Manga == caracteristicas[1])
                        {
                            stock = p.CantidadStock;
                        }
                    }
                }
            }
            else
            {
                foreach (Prenda p in this.Prendas)
                {
                    Type tipo = p.GetType();
                    if (tipo.Name == "Pantalon")
                    {
                        Pantalon pPantalon = (Pantalon)p;
                        if (p.Calidad == calidad && pPantalon.Tipo == caracteristicas[0])
                        {
                            stock = p.CantidadStock;
                        }
                    }
                }
            }

            return stock;
        }

        public double Cotizar(string prenda, string calidad, string[] caracteristicas, double precio, int cantidad)
        {
            return this.Vendedor.Cotizar(ref cotizaciones , Prendas, prenda, calidad, caracteristicas, precio, cantidad); 
        }
    }
}
