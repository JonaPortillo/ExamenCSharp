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
    }
}
