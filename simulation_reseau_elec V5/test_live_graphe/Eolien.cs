using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Eolien : Centrale
    {
        float wind = 0;
        public double coeff = 0;
        public double price;
        public Eolien(double max_prod, int co2, Market market , Meteo meteo) : base(max_prod, co2)
        {
            this.wind = meteo.Get_wind();
            this.price = market.Get_e_price();
        }
        public override double Get_prod()
        {
            //return base.Get_prod();
            Console.WriteLine("vent = " + wind);

            coeff = (wind < 100) ? (wind / 100) : 0;
            //coeff = (wind < 10) ? 1 : 3;

            Console.WriteLine("le coeff est de " + coeff);
            return max_prod * coeff;
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
