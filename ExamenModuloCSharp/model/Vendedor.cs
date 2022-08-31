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

        public double Cotizar(ref List<Cotizacion> cotizaciones, List<Prenda> prendas, string prenda, string calidad, string[] caracteristicas, double precio, int cantidad)
        {
            double total = precio * cantidad;
            Prenda prendaCot = new Prenda();// Prenda auxiliar para incluir en la cotizacion

            // Actualización del stock
            #region ACTUALIZAR STOCK
            if (prenda == "Camisa")
            {
                foreach (Prenda p in prendas)
                {
                    Type tipo = p.GetType();
                    if (tipo.Name == "Camisa")
                    {
                        Camisa pCamisa = (Camisa)p;
                        if (p.Calidad == calidad && pCamisa.Cuello == caracteristicas[0] && pCamisa.Manga == caracteristicas[1])
                        {
                            pCamisa.CantidadStock -= cantidad;
                            prendaCot = pCamisa;
                        }
                    }
                }
            }
            else
            {
                foreach (Prenda p in prendas)
                {
                    Type tipo = p.GetType();
                    if (tipo.Name == "Pantalon")
                    {
                        Pantalon pPantalon = (Pantalon)p;
                        if (p.Calidad == calidad && pPantalon.Tipo == caracteristicas[0])
                        {
                            pPantalon.CantidadStock -= cantidad;
                            prendaCot = pPantalon;
                        }
                    }
                }
            }
            #endregion

            // Validaciones según características de las prendas

            if (prenda == "Camisa")
            {
                total -= caracteristicas[1] == "corta" ? (total * 0.1) : 0;
                total += caracteristicas[0] == "mao" ? (total * 0.03) : 0;
            }
            else
            {
                total -= (caracteristicas[0] == "chupin" ? (total * 0.12) : 0);
            }

            total += (calidad == "premium" ? (total * 0.3) : 0);

            Cotizacion cot = new Cotizacion(this.CodigoVendedor, cantidad, total, prendaCot);
            cotizaciones.Add(cot);
            return total;
        }
    }
}
