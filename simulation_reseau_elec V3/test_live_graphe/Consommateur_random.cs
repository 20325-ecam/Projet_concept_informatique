using System;
using System.Collections.Generic;
using System.Text;

namespace simulation_reseau_elec
{
    public class Consommateur_random : Consommateur //​​Terminé!!!!!!!!

    {
         static readonly Random rand = new Random();
        public Consommateur_random(float max_conso) : base(max_conso)
        {
        }

        public override float Get_conso()
        {
            //return base.Get_conso();
            //code pour conso

            int maintenant = DateTime.Now.Second / 3;
            int x, y;
            float r;
            if ((maintenant >= 0 && maintenant < 7) || (maintenant >= 19 && maintenant < 24))
            {
                x = 1; y = 20;
                r = rand.Next(x, y);
                //Console.WriteLine(r + " est le random");
                r = (r / 100) * max_conso;
                Console.WriteLine("conso nuit");
                //Console.WriteLine(r + " est la conso random");
                return r ;
            }
            else if (maintenant>=7 && maintenant<19)
            {
                x = 21; y = 100;
                r = rand.Next(x, y);
                //Console.WriteLine(r + " est le random");
                r = (r / 100) * max_conso;
                Console.WriteLine("conso jour");
                //Console.WriteLine(r + " est la conso random");
                return r;
            }
            else
            {
                return 1;
            }
        }
    }
}
