using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class Consommateur_random : Consommateur

    {
        public Consommateur_random(int max_conso) : base(max_conso)
        {
        }
        public override int Get_conso()
        {
            return 200;
        }
    }
}
