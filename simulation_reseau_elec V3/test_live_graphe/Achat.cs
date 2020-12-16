using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Achat : Centrale
    {
        public Achat(float max_prod, int prix, int co2) : base(max_prod, prix, co2)
        {

        }
        public override double Get_achat(double trou_energie)
        {
            trou_energie -= max_prod;
            if (trou_energie > 0)
            {
                Console.WriteLine("manque restant (achat) " + trou_energie);
                // gestion erreur ?? ********************************************************
            }
            else
            {
                Console.WriteLine("pas d'achat");
            }
            return trou_energie;
        }
    }
}
