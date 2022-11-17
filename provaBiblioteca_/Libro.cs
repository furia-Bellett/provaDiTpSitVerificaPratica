using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provaBiblioteca_
{
    internal class Libro
    {

        internal string Autore { get; set; }
        internal string Titolo { get; set; }
        internal string AnnoDiPubblicazione { get; set; }
        internal string Editore { get; set; }
        internal double NumeroDiPagine { get; set; }       


        public string toString()
        {

            string datiSulLibro = Autore + " " + Titolo + " " + Convert.ToString(AnnoDiPubblicazione) + " " + Editore + " " + Convert.ToString(NumeroDiPagine);


            return datiSulLibro;
        }


        public double readingTime()
        {
            int tempoDiLettura = 1;
            if (NumeroDiPagine < 100)
            {
                return tempoDiLettura;


            }
            else if (NumeroDiPagine > 100 && NumeroDiPagine < 200)
            {
                return (tempoDiLettura + 1);
            }
            else
            {
                return (tempoDiLettura + 1);
            }
        }



    }
}
