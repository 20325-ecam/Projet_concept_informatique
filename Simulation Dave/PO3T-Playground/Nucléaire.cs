using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class Nucléaire : Centrale
    {
        public Nucléaire(float max_prod) : base(max_prod)
        {

        }
        public override float Get_prod()
        {
            //code production nucléaire
            return max_prod;
        }
    }

}
