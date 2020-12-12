using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Meteo
    {
        DateTime now = DateTime.Now;
        //public View_graphe view_graphe;
        public bool Soleil;
        public decimal vent;
        public decimal temp;

        public bool console_meteo()
        {
            Console.WriteLine("Hour: {0}", now.Hour);
            Console.WriteLine(Soleil);
            Console.WriteLine(vent);
            Console.WriteLine(temp);
            return Soleil;
        }

    }

}
