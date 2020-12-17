using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace simulation_reseau_elec
{
    class Ligne 
    {
        public double Power_limit;
        // public Ligne(consomateur consomateur)
        public Ligne(double Power_limit)
        {
            this.Power_limit = Power_limit;
        }
        public double Ligne_in(double Power_in) //sortie du noeux consomateur/d'un producteur
        {
            if(Power_in <= Power_limit)
            {
                return Power_in;
            }
            else
            {
                return 0;
                
                //MessageBox.Show("surcharge", "erreur", MessageBoxButton.OK);
                //System.Windows.Forms.MessageBox.Show("helloe");
                // error message****************
            }
        }
        
    }
}
