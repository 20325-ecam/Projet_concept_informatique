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
        public float coeff = 0;
        public Eolien(float max_prod, Meteo meteo) : base(max_prod)
        {
            this.wind = meteo.Get_wind();
        }
        public override float Get_prod()
        {
            //return base.Get_prod();
            Console.WriteLine("vent = " + wind);

            coeff = (wind < 100) ? (wind / 100) : 0;
            //coeff = (wind < 10) ? 1 : 3;

            Console.WriteLine("le coeff est de " + coeff);
            return max_prod * coeff;
        }
    }
    
}
