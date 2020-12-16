using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Vente : Consommateur
    {
        public Vente(int max_conso) : base(max_conso)
        {

        }
        public override double Get_vente(double trou_energie)
        {
            trou_energie -= max_conso;
            if (trou_energie > 0)
            {
                Console.WriteLine("surplus restant " + trou_energie);
                // appel methode disipateur ********************************************************
            }
            else
            {
                Console.WriteLine("pas de vente");
            }
            return trou_energie;
        }

    }
}
