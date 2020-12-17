using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public abstract class Centrale
    {
        public double max_prod;
        public double co2;

        public Centrale(double max_prod, double co2)
        {
            this.max_prod = max_prod;
            this.co2 = co2;
        }
        public virtual double Get_prod()
        {
            //code pour générer p
            return 100;
        }
        public virtual double Get_achat(double trou_energie)
        {
            return 0;
        }
        public virtual double Get_prix()
        {
            return 0;
        }
        public virtual double Get_co2()
        {
            return co2;
        }
    }
}
