using ExamenModuloCSharp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenModuloCSharp.controller
{
    static class TiendaController
    {
        public static Tienda CrearTienda(string nombre, string direccion)
        {
            Tienda tienda = new Tienda(nombre, direccion);
            return tienda;
        }

        public static Vendedor CrearVendedor(string nombre, string apellido, string codigoVendedor)
        {
            Vendedor vendedor = new Vendedor(nombre, apellido, codigoVendedor);
            return vendedor;
        }

        public static Tienda AsignarVendedorATienda(Vendedor vendedor, Tienda tienda)
        {
            tienda.Vendedor = vendedor;
            return tienda;
        }

        public static void CargaDeStock(ref Tienda tienda)
        {
            Camisa camisa1 = new Camisa("mao", "corta", "premium", 100);
            Camisa camisa2 = new Camisa("mao", "corta", "standar", 100);
            Camisa camisa3 = new Camisa("comun", "corta", "premium", 150);
            Camisa camisa4 = new Camisa("comun", "corta", "standar", 150);
            Camisa camisa5 = new Camisa("mao", "larga", "premium", 75);
            Camisa camisa6 = new Camisa("mao", "larga", "standar", 75);
            Camisa camisa7 = new Camisa("comun", "larga", "premium", 175);
            Camisa camisa8 = new Camisa("comun", "larga", "standar", 175);
            tienda.agregarPrenda(camisa8);
            tienda.agregarPrenda(camisa7);  
            tienda.agregarPrenda(camisa6);
            tienda.agregarPrenda(camisa5);
            tienda.agregarPrenda(camisa4);
            tienda.agregarPrenda(camisa3);
            tienda.agregarPrenda(camisa2);
            tienda.agregarPrenda(camisa1);
            Pantalon pantalon1 = new Pantalon("chupin","standar",750);
            Pantalon pantalon2 = new Pantalon("chupin", "premium", 750);
            Pantalon pantalon3 = new Pantalon("comun", "standar", 250);
            Pantalon pantalon4 = new Pantalon("comun", "premium", 250);
            tienda.agregarPrenda(pantalon4);
            tienda.agregarPrenda(pantalon3);
            tienda.agregarPrenda(pantalon2);
            tienda.agregarPrenda(pantalon1);
        }

        public static int ActualizarStockVista(Tienda tienda, string prenda, string calidad, string[] caracteristicas)
        {
            int stock;
            
            stock = tienda.StockDisponible(prenda,calidad, caracteristicas);
            
            return stock;
        }

        public static double Cotizar(ref Tienda tienda, string prenda, string calidad, string[] caracteristicas, double precio, int cantidad)
        {
            double total = tienda.Cotizar(prenda,calidad,caracteristicas,precio,cantidad);
            return total;
        }
    }
}
