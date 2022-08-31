using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenModuloCSharp
{
    internal class Cotizacion
    {
        // Atributos
        private int numeroIdentificacion;
        private DateTime fechaHora;
        private string codigoVendedor;
        private Prenda prenda;
        private int cantidadUnidadesCotizadas;
        private double resultado;
        static int identificacion = 0;

        public int NumeroIdentificacion { get => numeroIdentificacion; set => numeroIdentificacion = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public string CodigoVendedor { get => codigoVendedor; set => codigoVendedor = value; }
        public int CantidadUnidadesCotizadas { get => cantidadUnidadesCotizadas; set => cantidadUnidadesCotizadas = value; }
        public double Resultado { get => resultado; set => resultado = value; }
        internal Prenda Prenda { get => prenda; set => prenda = value; }

        //Controladores
        public Cotizacion(string codVen, int cantidad,double total, Prenda prenda)
        {
            NumeroIdentificacion = identificacion;
            identificacion++;
            FechaHora = DateTime.Now;
            CodigoVendedor = codVen;
            CantidadUnidadesCotizadas = cantidad;
            Resultado = total;
            Prenda = prenda;
        }
    }
}
