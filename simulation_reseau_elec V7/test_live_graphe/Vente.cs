using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public class Vente : Consommateur //classe qui permet de vensre le surplus de production énergétique
    {
        public double price;
        public Vente(int max_conso, string name, Market market) : base(max_conso, name)
        {
            this.price = market.Get_v_price();  //récupération du prix KWh du marché
        }
        public override double Get_vente(double trou_energie, Consommateur disipateur)
        {
            
            if ((trou_energie - max_conso) > 0) //vente pas assez importante 
            {
                // appel methode disipateur ********************************************************
                trou_energie -= max_conso;
                disipateur.Get_dissip(trou_energie);
                return trou_energie;
            }
            else  //vente a ecoule tous le surplus
            {
                return trou_energie;
            }
        }
        public override string Get_name()
        {
            return base.Get_name();
        }
    }
}
