using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public abstract class Consommateur  //​​Terminé!!!!!!!!
    {
        public float max_conso;
        
        public Consommateur(float max_conso)
        {
            this.max_conso = max_conso;
        }
        public virtual float Get_conso()
        {
            return 0;
        }
        public virtual double Get_vente(double trou_energie)
        {
            return 0;
        }
    }
}
