using System;
using System.Collections.Generic;
using System.Text;

namespace test
{

    public abstract class Centrale
    {
        int max_prod;
        public Centrale(int max_prod)
        {
            this.max_prod = max_prod;
        }
        public virtual int Get_prod()
        {
            //code pour générer p
            return 100;
        }
    }
}
