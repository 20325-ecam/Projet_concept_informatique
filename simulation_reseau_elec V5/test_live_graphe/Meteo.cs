using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Meteo
    {
        public float wind;
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
            return wind;
        }
        public float Get_temp()
        {
            return temp;
        }
        public float Get_sun()
        {
            return sun;
        }
    }
}
