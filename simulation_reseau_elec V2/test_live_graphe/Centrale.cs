using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Centrale
    {
        public int sum_total;
        public int sum_eolien = 0;
        public int sum_nucleaire = 0;
        public int sum_solaire = 0;
        public int sum_Gaz = 0;

        public Centrale()
        {
            /*int test = (Eos1.prod_eolien() 
                + Eos2.prod_eolien() 
                + Eos3.prod_eolien() 
                + Eos4.prod_eolien());
            Console.WriteLine(test);*/
        }
        // sum
        public void Add_Eolien(Eolien eolien) 
        {
            sum_eolien += eolien.prod_eolien();
        }
        public void Add_Nucleaire(Nucleaire nucleaire)
        {
            sum_nucleaire += nucleaire.prod_nucleaire();
        }
        public void Add_Solaire(Solaire solaire)
        {
            sum_solaire += solaire.prod_solaire();
        }
        public void Add_Gaz(Gaz gaz)
        {
            sum_Gaz += gaz.prod_gaz();
        }
        //sub
        public void sub_Eolien(Eolien eolien)
        {
            sum_eolien -= eolien.prod_eolien();
        }
        public void sub_Nucleaire(Nucleaire nucleaire)
        {
            sum_nucleaire -= nucleaire.prod_nucleaire();
        }
        public void sub_Solaire(Solaire solaire)
        {
            sum_solaire -= solaire.prod_solaire();
        }
        public void sub_Gaz(Gaz gaz)
        {
            sum_Gaz -= gaz.prod_gaz();
        }
        // somme
        public void Production_total()
        {
            sum_total = sum_eolien + sum_Gaz + sum_nucleaire + sum_solaire;
            Console.WriteLine(sum_total);
        }
    }
}
