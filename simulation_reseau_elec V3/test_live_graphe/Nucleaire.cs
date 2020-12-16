using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Nucleaire : Centrale
    {
        public Nucleaire(double max_prod, int prix, int co2) : base(max_prod, prix, co2)
        {

        }
        public override double Get_prod()
        {
            //code production nucléaire
            return max_prod;
        }
        public override int Get_prix()
        {
            return base.Get_prix();
        }
        public override int Get_co2()
        {
            return base.Get_co2();
        }
    }
}
