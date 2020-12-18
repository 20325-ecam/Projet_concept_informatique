using System;
using System.Collections.Generic;
using System.Text;

namespace simulation_reseau_elec
{
    public class Consommateur_random : Consommateur //​​classe pour créer un consommateur non constant

    {
         static readonly Random rand = new Random();
        public Consommateur_random(float max_conso) : base(max_conso)
        {
        }

        public override float Get_conso()
        {
            int maintenant = DateTime.Now.Second / 3;
            int x, y;
            float r;
            if (maintenant>=7 && maintenant<18)  //consommation durant la journée
            {
                x = 21; y = 100;
                r = rand.Next(x, y);    //coefficient aléatoire
                r = (r / 100) * max_conso;
                return r;
            }
            else  //consommation durant la nuit
            {
                x = 1; y = 20;
                r = rand.Next(x, y);    //coefficient aléatoire
                r = (r / 100) * max_conso;
                return r;
            }
        }
        public override string Get_status()
        {
            return base.Get_status();
        }
    }
}
