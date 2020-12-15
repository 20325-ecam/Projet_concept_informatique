using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Consommateur_statique : Consommateur  //​​Terminé!!!!!!!!
    {
        public Consommateur_statique(float max_conso) : base(max_conso)
        {
        }
        public override float Get_conso()
        {
            return max_conso;
        }
    }
}
