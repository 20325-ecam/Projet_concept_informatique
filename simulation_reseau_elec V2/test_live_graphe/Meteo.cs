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

        public decimal Soleil = 60;
        public decimal vent = 10;
        public decimal temp = 15;

        public Meteo()
        {

        }
        /*public bool console_meteo()
        {
            Console.WriteLine("Hour: {0}", now.Hour);
            Console.WriteLine(Soleil);
            Console.WriteLine(vent);
            Console.WriteLine(temp);
            return Soleil;
        }*/
        public decimal temperature()
        {
            return temp;
        }
        public decimal Vent()
        {
            return vent;
        }
    }
}
