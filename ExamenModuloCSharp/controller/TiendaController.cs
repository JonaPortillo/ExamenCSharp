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

        public static void AsignarVendedorATienda(Vendedor vendedor, Tienda tienda)
        {
            tienda.Vendedor = vendedor;
        }
    }
}
