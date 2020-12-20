using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public class Disipateur : Consommateur
    {//a verifier ********************************
        public double energie_dissipee;
        public double surplus;
        public Disipateur(float max_conso, string name) : base(max_conso, name)
        {
        }
        public override double Get_dissip(double surplus)
        {
            if(surplus <= max_conso) // si dispateur peu tous gere
            {
                Console.WriteLine("disp_if" + surplus);
                this.energie_dissipee = surplus;
                return surplus; //inutile
            }
            else // si dispateur ne peut^pas tous disiper 
            {
                Console.WriteLine("disp_else" + max_conso);
                this.energie_dissipee = max_conso;
                this.surplus = surplus - max_conso;
                return max_conso; //inutile
            }
        }
        public override string Get_status()
        {
            return base.Get_status();
        }
        public override double Get_surplus()
        {
            return this.surplus;
        }
        public override double Get_energieDisipee()
        {
            return this.energie_dissipee;
        }
        public override string Get_name()
        {
            return base.Get_name();
        }
    }
}
