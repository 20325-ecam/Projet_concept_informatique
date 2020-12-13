using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Eolien : Meteo
    {
        //public decimal Temp;
        public Eolien()
        {
            
            //this.temp = Temp;
        }
        public int prod_eolien()
        {
            decimal test = Vent();
            if (test >= 10)
            {
                return 10;
            }
            else
            {
                return 0;
            }
        }
        public double Prix_eolien()
        {
            return 0.1;
        }
        public int Co2_eolien()
        {
            return 0;
        }
    }
    
}
