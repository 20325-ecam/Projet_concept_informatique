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
        public virtual string Get_status()
        {
            int maintenant = DateTime.Now.Second / 3;
            if ((maintenant >= 0 && maintenant < 7) || (maintenant >= 19 && maintenant < 24))
            {
                return "Nuit";
            }
            else if (maintenant >= 7 && maintenant < 19)
            {
                return "Jour";
            }
            else
            {
                return "1";
            }
        }
    }
}
