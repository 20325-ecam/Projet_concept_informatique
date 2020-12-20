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
        //public double power_in;
        public double power_out;
        // public Ligne(consomateur consomateur)
        public Ligne(double Power_limit)
        {
            this.power_limit = Power_limit;
            //power_in = centrale.Get_prod();
            //power_out = consomateur.Get_conso();
        }
        public double Ligne_in(double power_in) //sortie du noeux consomateur/d'un producteur
        {
            if (power_in <= power_limit)
            {
                //Console.WriteLine(power_in);
                return power_in;
            }
            else
            {
                return 0;
                // error message****************
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
