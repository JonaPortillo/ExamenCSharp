using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenModuloCSharp
{
    internal class Camisa : Prenda
    {
        // Atributos
        private string manga;
        private string cuello;

        public string Manga { get => manga; set => manga = value; }
        public string Cuello { get => cuello; set => cuello = value; }

        // Constructores
        public Camisa() : base()
        {

        }

        public Camisa(string cuello, string manga) : base()
        {
            Cuello = cuello;
            Manga  = manga; 
        }

        public Camisa(string cuello, string manga, string calidad, int cantidadStock) : base(calidad, cantidadStock)
        {
            Cuello = cuello;
            Manga = manga;
        }
    }
}
