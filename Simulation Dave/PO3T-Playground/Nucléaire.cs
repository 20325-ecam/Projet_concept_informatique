using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class Nucléaire : Centrale
    {
        public Nucléaire(int max_prod) : base(max_prod)
        {

        }
        public override int Get_prod()
        {
            return 1000;
            //code production nucléaire
        }
    }

}
