using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Ville
    {
        public double conso_ville;
        //dave DateTime now = DateTime.Now;
        readonly Random rand = new Random(0);

        public void void_ville()
        {
            //int maintenant = now.Hour;
            //int maintenant = now.Minute/3;
            //int maintenant = now.Second /3;
            int maintenant = DateTime.Now.Second / 3;
            //int maintenant = DateTime.Now.Minute / 3; 
            //int maintenant = DateTime.Now.Hour / 3;

            int x;
            int y;
            if (maintenant >= 0 && maintenant < 7) //tous le monde dors
            {
                x = 1;
                y = 5;
                conso_ville = rand.Next(x, y);
            }
            else if (maintenant >= 7 && maintenant < 9) // les gens ce reveille 
            {
                x = 25;
                y = 30;
                conso_ville = rand.Next(x, y);
            }
            else if (maintenant >= 9 && maintenant < 11) // les gens parte au boulot 
            {
                x = 10;
                y = 15;
                conso_ville = rand.Next(x, y);
            }
            else if (maintenant >= 11 && maintenant < 13) // pause de midi 
            {
                x = 25;
                y = 30;
                conso_ville = rand.Next(x, y);
            }
            else if (maintenant >= 13 && maintenant < 17) // les gens travaille
            {
                x = 15;
                y = 20;
                conso_ville = rand.Next(x, y);
            }
            else if (maintenant >= 17 && maintenant < 20) // les gens rentre et se font a manger
            {
                x = 25;
                y = 30;
                conso_ville = rand.Next(x, y);
            }
            else if (maintenant >= 20 && maintenant < 24) // les gens s'occupe puis vont dormir
            {
                x = 1;
                y = 5;
                conso_ville = rand.Next(x, y);
            }
        }
    }
}
