﻿using System;
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
        Random rand = new Random();

        public void void_ville()
        {
            //int maintenant = now.Hour;
            //int maintenant = now.Minute/3;
            //int maintenant = now.Second /3;
            int maintenant = DateTime.Now.Second / 3;
            //int maintenant = DateTime.Now.Minute / 3; 
            //int maintenant = DateTime.Now.Hour / 3;

            int x, y;
            if ((maintenant >= 0 && maintenant < 7) || (maintenant >= 19 && maintenant < 24)) //nuit
            {
                x = 1; y = 20;
                conso_ville = rand.Next(x, y);
            }
            else if (maintenant >= 7 && maintenant < 19) // jour
            {
                x = 50; y = 100;
                conso_ville = rand.Next(x, y);
            }

        }
    }
}
