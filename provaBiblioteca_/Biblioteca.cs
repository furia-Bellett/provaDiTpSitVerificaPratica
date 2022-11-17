using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provaBiblioteca_
{
    internal class Biblioteca
    {

        internal string Nome { get; set; }
        internal string Indirizzo { get; set; }
        List<string> OrariGiornaglieri { get; set; }



        public List<Biblioteca> BibliotecaList = new();

        



    }
}
