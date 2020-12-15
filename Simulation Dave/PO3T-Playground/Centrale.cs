using System;
using System.Collections.Generic;
using System.Text;

namespace test
{

    public abstract class Centrale
    {
        public float max_prod;
        public Centrale(float max_prod)
        {
            this.max_prod = max_prod;
        }
        public virtual float Get_prod()
        {
            //code pour générer p
            return 100;
        }
    }
}
