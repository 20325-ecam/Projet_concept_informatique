using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Batterie : Consommateur
    {
        public Batterie(float max_conso, string name) : base(max_conso, name)
        {
        }

        public double Get_Centrale()
        {
            return 150;
        }
    }
}
