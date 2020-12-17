using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Achat : Centrale
    {
        public double price;
        public Achat(double max_prod, double co2, Market market) : base(max_prod, co2)
        {
            this.price = market.Get_a_price();
        }
        public override double Get_achat(double trou_energie)
        {
            
            if(max_prod < trou_energie) //si achat peux pas combler le trou 
            {
                return max_prod;
                Console.WriteLine("manque restant (achat) " + trou_energie);
            }
            else if(max_prod > trou_energie) // achat peux combler les besoins
            {
                return trou_energie;
            }
            else
            {
                return 0;
            }
        }
    }
}
