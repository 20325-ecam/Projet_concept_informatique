using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace simulation_reseau_elec
{
    public class Ligne 
    {
        public double power_limit;
        public double power_out;
        public string name;
        public Ligne(double Power_limit, string name)
        {
            this.power_limit = Power_limit;
            this.name = name;

        }
        public double Ligne_in(double power_in) //sortie du noeux consomateur/d'un producteur
        {
            
            if (power_in <= power_limit)
            {
                return power_in;
                
            }
            else
            {
                return 0;
                
            }
        }
        public double Ligne_out()
        {
            if (power_out <= power_limit)
            {
                Console.WriteLine(power_out);
                return power_out;
                
            }
            else
            {
                return 0;
                // error message****************
            }
        }
    }
}
