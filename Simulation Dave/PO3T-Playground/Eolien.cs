using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class Eolien : Centrale
    {
        public Eolien(float max_prod) : base(max_prod)
        {

        }
        public override float Get_prod()
        {
            //return base.Get_prod();
            return max_prod;
        }
    }

}
