using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public abstract class Consommateur  //classe mère pour toute source consommatrice d'énergie
    {
        public float max_conso;
        public string name;

        public Consommateur(float max_conso, string name) //(float max_conso, Ligne ligne)
        {
            this.max_conso = max_conso; //consommation maximale autorisée 
            this.name = name;
        }
        public virtual float Get_conso()
        {
            return 0;
        }
        public virtual double Get_vente(double trou_energie)
        {
            return 0;
        }
        public virtual string Get_status() //indique si la consommation est en mode jour/nuit
        {
            int maintenant = DateTime.Now.Second / 3;

            if (maintenant >= 7 && maintenant < 18)
            {
                return "Jour";
            }
            else
            {
                return "Nuit";
            }
        }
        public virtual string Get_name()
        {
            return this.name;
        }
    }
}
