using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Hund
    {
        int gewicht;
         int alter;
    }

    class KleinerHund : Hund
    {
        int groesse;
        public KleinerHund(int alt)
        {
            alt = alter;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KleinerHund auau = new KleinerHund(10);

        }
    }
}
