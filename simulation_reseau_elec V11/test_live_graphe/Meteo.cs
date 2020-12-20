using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public class Meteo //classe qui gère divers paramètres météorologiques
    {
        static readonly Random rand = new Random();
        private float wind;
        public float temp;
        public float sun;

        public Meteo(float wind, float temp, float sun)
        {
            this.wind = wind;
            this.temp = temp;
            this.sun = sun;
        }

        public float Get_wind()
        {
            int min = 5;
            int max = 10;
            int r = rand.Next(min , max);
            Console.WriteLine("random " + (int)wind*((float)r/10));
            float val = wind * ((float)r / 10);
            return val;
        }
        public float Get_temp()
        {
            return temp;
        }
        public float Get_sun()
        {
            return sun;
        }
        public float Get_vent()
        {
            return wind;
        }
    }
}
