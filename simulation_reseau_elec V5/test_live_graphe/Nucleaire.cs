using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Nucleaire : Centrale
    {
        public double price;
        public Nucleaire(double max_prod, double co2, Market market) : base(max_prod, co2)
        {
            this.price = market.Get_n_price();
        }
        public override double Get_prod()
        {
            //code production nucléaire
            return max_prod;
        }
        public override double Get_prix()
        {
            return price * this.Get_prod();
            //return base.Get_prix();
        }
        public override double Get_co2()
        {
            return base.Get_co2();
        }
    }
}
