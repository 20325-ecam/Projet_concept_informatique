using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Solaire : Meteo 
    {
        public Solaire()
        {
            
        }
        public int prod_solaire()
        {
            return 10;
        }
        public double Prix_solaire()
        {
            return 0.1;
        }
        public int Co2_solaire()
        {
            return 0;
        }
    }
}
