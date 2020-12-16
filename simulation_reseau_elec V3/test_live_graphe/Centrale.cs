using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public abstract class Centrale
    {
        public float max_prod;
        public Centrale(float max_prod)
        {
            this.max_prod = max_prod;
        }
        public virtual float Get_prod()
        {
            //code pour générer p
            return 100;
        }
        public virtual double Get_achat(double trou_energie)
        {
            return 0;
        }
    }
}
