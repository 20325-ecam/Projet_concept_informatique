using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public abstract class Consommateur
    {
        public float max_conso;

        public Consommateur(float max_conso) //(float max_conso, Ligne ligne)
        {
            this.max_conso = max_conso;
        }
        public virtual float Get_conso()
        {
            return 0;
        }
        public virtual double Get_vente(double trou_energie)
        {
            return 0;
        }
    }
}
