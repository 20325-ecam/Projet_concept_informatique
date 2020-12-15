using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class Eolien : Centrale
    {
        public Eolien(int max_prod) : base(max_prod)
        {

        }
        public override int Get_prod()
        {
            //return base.Get_prod();
            return 500;
        }
    }

}
