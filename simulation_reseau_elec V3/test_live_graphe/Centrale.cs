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
        public int prix;
        public int co2;

        public Centrale(float max_prod, int prix, int co2)
        {
            this.max_prod = max_prod;
            this.prix = prix;
            this.co2 = co2;
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
        public virtual int Get_prix()
        {
            return prix;
        }
        public virtual int Get_co2()
        {
            return co2;
        }
    }
}
