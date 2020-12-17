using System;
using System.Collections.Generic;
using System.Text;

namespace simulation_reseau_elec
{
    class Consommateur_statique : Consommateur  //​​Terminé!!!!!!!!
    {
        public Consommateur_statique(float max_conso) : base(max_conso)
        {
        }
        public override float Get_conso()
        {
            int maintenant = DateTime.Now.Second / 3;
            //return max_conso;
            if ((maintenant >= 0 && maintenant < 7) || (maintenant >= 19 && maintenant < 24))
            {
                return max_conso/5;
            }
            else if (maintenant >= 7 && maintenant < 19)
            {
                return max_conso;
            }
            else
            {
                return 1;
            }
        }
        public override string Get_status()
        {
            return base.Get_status();
        }
    }
}
