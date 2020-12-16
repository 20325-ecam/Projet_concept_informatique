using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Nucleaire : Centrale
    {
        public Nucleaire(float max_prod) : base(max_prod)
        {

        }
        public override float Get_prod()
        {
            //code production nucléaire
            return max_prod;
        }
    }
}
