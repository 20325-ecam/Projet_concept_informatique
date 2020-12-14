using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Consomateur
    {
        public double conso_consomateur;
        Ville ville = new Ville();
        Entreprise entreprise = new Entreprise();


        public void void_consomateur()
        {
            ville.void_ville();
            entreprise.void_entreprise();
            conso_consomateur = ville.conso_ville + entreprise.conso_entreprise;
        }
    }
}
