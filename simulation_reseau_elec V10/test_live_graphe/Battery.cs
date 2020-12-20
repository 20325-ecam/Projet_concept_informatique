using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public class Battery
    {
        public double max_capacity;
        public string name;
        public double capacity = 20;
        public int div = 10;
        public Battery(double max_capacity, string name) 
        {
            this.max_capacity = max_capacity;
            this.name = name;
        }

        public double Get_charge(double value) // batterie charge instantane 
        {
            if (capacity + value <= max_capacity)
            {
                capacity += value;
                return value;
            }
            else
            {
                double remainig = max_capacity - capacity;
                capacity += remainig;
                return remainig;
            }        
            
        }
        public double Get_discharge(double value_asked)
        {
            if (capacity >= value_asked)
            {
                capacity -= value_asked;
                return value_asked;
            }
            else
            {
                double value = capacity ;
                capacity -= value;
                return value;
            }
        }
        public double Get_capacity()
        {
            return (capacity / max_capacity) * 100; ;
        }
    }
}
