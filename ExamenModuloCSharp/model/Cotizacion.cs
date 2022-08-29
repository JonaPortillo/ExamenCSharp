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
        private int codigoVendedor;
        private Prenda prenda;
        private int cantidadUnidadesCotizadas;
        private int resultado;

        public int NumeroIdentificacion { get => numeroIdentificacion; set => numeroIdentificacion = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public int CodigoVendedor { get => codigoVendedor; set => codigoVendedor = value; }
        public int CantidadUnidadesCotizadas { get => cantidadUnidadesCotizadas; set => cantidadUnidadesCotizadas = value; }
        public int Resultado { get => resultado; set => resultado = value; }
        internal Prenda Prenda { get => prenda; set => prenda = value; }
    }
}
