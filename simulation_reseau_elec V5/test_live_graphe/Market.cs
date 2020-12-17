using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public class Market
    {
        public double n_price;
        public double e_price;
        public double a_price;
        public double v_price;
        public Market(double n, double e, double a, double v)
        {
            this.n_price = n;
            this.e_price = e;
            this.a_price = a;
            this.v_price = v;
        }
        public double Get_n_price()
        {
            return n_price;
        }
        public double Get_e_price()
        {
            return e_price;
        }
        public double Get_a_price()
        {
            return a_price;
        }
        public double Get_v_price()
        {
            return v_price;
        }

    }
    
}
