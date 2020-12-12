using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_live_graphe
{
    class Meteo
    {
        //public View_graphe view_graphe;
        public bool Soleil;
        public decimal vent;
        public int temp;

        public bool console_meteo()
        {
            Console.WriteLine(Soleil);
            Console.WriteLine(vent);
            Console.WriteLine(temp);
            return Soleil;
        }

    }

}
