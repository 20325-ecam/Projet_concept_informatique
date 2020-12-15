using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public abstract class Consommateur
    {
        int max_conso;
        public Consommateur(int max_conso)
        {
            this.max_conso = max_conso;
        }
        public virtual int Get_conso()
        {
            //code pour conso
            return 100;
        }
    }
}
