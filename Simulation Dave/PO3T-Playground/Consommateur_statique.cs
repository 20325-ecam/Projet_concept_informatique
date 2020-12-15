using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Consommateur_statique : Consommateur
    {
        public Consommateur_statique(int max_conso) : base(max_conso)
        {
        }
        public override int Get_conso()
        {
            return 300;
        }
    }
}
