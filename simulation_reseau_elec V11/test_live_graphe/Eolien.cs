﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public class Eolien : Centrale //classe pour créer/gérer une source d'énergie éolienne (production varie avec la vitesse du vent)
    {
        float winds = 0;
        public double coeff = 0;
        public double price;
        public Eolien(double max_prod, int co2, string name, Market market , Meteo meteo) : base(max_prod, co2, name)
        {
            
            this.winds = meteo.Get_wind();   //récupération de la vitesse du vent depuis la classe météo
            this.price = market.Get_e_price();  //récupération du prix KWh du marché
        }
        public override float Get_vent(Meteo meteo)
        {
            return meteo.Get_wind();
        }
        public override double Get_prod()
        {
           
            coeff = (winds < 50) ? (winds / 100) : 0; //on ne fait pas fonctionner la centrale si le vent est trop fort (+180Km/h ~=50m/s))
            return max_prod * coeff;
        }
        public override double Get_prix()
        {
            return price * this.Get_prod();
        }
        public override double Get_co2()
        {
            return base.Get_co2();
        }
        public override string Get_name()
        {
            return base.Get_name();
        }
    }
    
}
