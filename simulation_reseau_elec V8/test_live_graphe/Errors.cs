using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public abstract class Errors
    {
        public Errors()
        {
        }
        public virtual string Show_error(Centrale centrale)
        {
            return "nothing";
        }
    }
}
