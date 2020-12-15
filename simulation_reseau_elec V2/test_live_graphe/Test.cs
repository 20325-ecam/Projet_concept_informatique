using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Test
    {
        Random rat = new Random();
        public Test(float rad)
        {
            int x = 10;
            int y = 1;
            float Z = rat.Next(y, x);
            Z = (Z / 100) * rad;
            Console.WriteLine(Z);
        }
    }
}
