using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Achat : Centrale
    {
        public Achat(float max_prod) : base(max_prod)
        {

        }
        public override double Get_achat(double trou_energie)
        {
            trou_energie -= max_prod;
            if (trou_energie > 0)
            {
                Console.WriteLine("manque restant " + trou_energie);
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
