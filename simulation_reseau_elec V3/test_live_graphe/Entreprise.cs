using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Entreprise
    {
        public double conso_entreprise = 60;
        //DateTime now = DateTime.Now;              ->delete
        //readonly Random rand = new Random(0);

        public void void_entreprise()
        {
            conso_entreprise = 60;
        }
        public double get_entreprise()
        {
            return 60;
        }
    }
}
