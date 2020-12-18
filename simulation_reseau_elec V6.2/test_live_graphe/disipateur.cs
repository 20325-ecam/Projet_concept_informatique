using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Disipateur : Consommateur
    {//a verifier ********************************
        public Disipateur(float max_conso) : base(max_conso)
        {
        }
        public override float Get_conso()
        {
            int maintenant = DateTime.Now.Second / 3;
            if (maintenant >= 7 && maintenant < 18) //consommation durant la journée
            {
                return max_conso;
            }
            else //consommation durant la nuit
            {
                return max_conso / 5;
            }
        }
        public override string Get_status()
        {
            return base.Get_status();
        }
    }
}
