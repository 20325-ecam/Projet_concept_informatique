﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public class Update //classe qui se charge de la simulation du réseau
    {
        public double prod_tot;
        public double conso_tot = 0;
        public double trou_energie = 0; // si + -> manque E ; si + -> surplus E
        public double abs_trou = 0; //valeur absolue du "trou" énergétique
        public double trou_vente;
        public double trou_achat;
        public string jour_nuit;
        public double total;
        public double surplus;
        public double dissipation;
        public double energie_vendue;
        public double battery_percentage;
        public double bat_discharge;

        public string erreurs;

        public double prix_eolien;
        public double co2_eolien;
        public double prod_eolien;

        public double prix_nucleaire;
        public double co2_nucleaire;
        public double prod_nucleaire;

        public double conso_ville;
        public double conso_entreprise;

        Errors errors;

        Meteo bruxelles;
        Market market; 

        Centrale e1, n1, a1;

        Consommateur ville, entreprise, v1, d1;

        Battery b1;

        Ligne l1, l2, l3, l4, l5, l6, l7, l8;
       

        public Update()
        {
            //*************************CREATION DES OBJETS*************************//
            errors = new Errors();

            bruxelles = new Meteo(30, 20, 60);
            market = new Market(10, 10, 10, 10); //nuc/eol/achat/vente

            //producteurs
            e1 = new Eolien(2000, 1, "e1", market, bruxelles);
            n1 = new Nucleaire(5000, 10, "n1", market);
            a1 = new Achat(2000, 100,"a1", market);

            //consommateurs
            ville = new Consommateur_random(1000, "ville");
            entreprise = new Consommateur_statique(7000, "entreprise");
            v1 = new Vente(400,"v1", market);
            d1 = new Disipateur(200, "d1");

            //batterie
            b1 = new Battery(100000, "b1");

            //lignes électriques
            l1 = new Ligne(1800, "l1"); //eolien vers prod
            l2 = new Ligne(6001, "l2"); //nucleaire vers prod
            l3 = new Ligne(2000, "l3"); //conso vers ville
            l4 = new Ligne(7000, "l4"); //conso vers entreprise
            l5 = new Ligne(100000, "l5"); //conso vers vente
            l6 = new Ligne(10000, "l6"); //achat vers prod
            l7 = new Ligne(8000, "l7"); //conso vers disp
            l8 = new Ligne(50000, "l8"); //prod vers conso

            
        }
        public void get_new_Data()
        {
            //*************************INITIALISATION DES VARIABLES*************************//
            prod_tot = 0;
            trou_achat = 0;
            conso_tot = 0;
            trou_energie = 0;
            abs_trou = 0;
            total = 0;
            dissipation = 0;
            surplus = 0;
            erreurs = "";

            battery_percentage = b1.Get_capacity(); //----------------------------
            
            //*************ASIGNATION DES LIGNES & GESTION ERREURS SURCHARGES COTE PRODUCTION*************//
            double Eo1 = e1.Get_prod();
            Eo1 = l1.Ligne_in(Eo1);
            prod_tot += Eo1;
            if (Eo1 == 0)
            {
                erreurs += DateTime.Now.ToString();
                erreurs += errors.Line_Overload(l1);
                erreurs += "\n";
            }
            prix_eolien = e1.Get_prix();
            co2_eolien = e1.Get_co2();
            prod_eolien = Eo1;

            double Nu1 = n1.Get_prod();
            Nu1 = l2.Ligne_in(Nu1);
            prod_tot += Nu1;
            if (Nu1 == 0)
            {
                erreurs += DateTime.Now.ToString();
                erreurs += errors.Line_Overload(l2);
                erreurs += "\n";
            }
            prix_nucleaire = n1.Get_prix();
            co2_nucleaire = n1.Get_co2();
            prod_nucleaire = Nu1;

            total += prod_tot;

            //*************ASIGNATION DES LIGNES & GESTION ERREURS SURCHARGES COTE CONSOMMATION*************//
            double ville = this.ville.Get_conso();
            ville = l3.Ligne_in(ville);
            if (ville == 0)
            {
                erreurs += DateTime.Now.ToString();
                erreurs += errors.Line_Overload(l3);
                erreurs += "\n";
            }
            conso_tot += ville;
            conso_ville = ville; 

            double entr = entreprise.Get_conso();
            entr = l4.Ligne_in(entr);
            if (entr == 0)
            {
                erreurs += DateTime.Now.ToString();
                erreurs += errors.Line_Overload(l4);
                erreurs += "\n";
            }
            conso_tot += entr;
            conso_entreprise = entr;

            //**********************************GESTION MANQUE & SURPLUS D'ENRGIE******************************//
            trou_energie = conso_tot - prod_tot;
            abs_trou = Math.Abs(trou_energie);

            if (trou_energie > 0) //manque
            {
                trou_achat = abs_trou;
                Console.WriteLine("trou_achat before if " + trou_achat);
                if (battery_percentage>0)
                {
                    bat_discharge = b1.Get_discharge(trou_achat);
                    Console.WriteLine("bat discharge "+bat_discharge);
                    trou_achat -= bat_discharge;
                    Console.WriteLine("trou_achat in if " + trou_achat);
                    //trou_achat = abs_trou;

                }
                Console.WriteLine("trou_achat out if " + trou_achat);
                trou_achat = a1.Get_achat(trou_achat);
                trou_achat = l6.Ligne_in(trou_achat);
                Console.WriteLine("trou_achat end " + trou_achat);
                trou_vente = 0;
               
                
            }
            else if (trou_energie < 0) //surplus
            {
                trou_vente = abs_trou;
                trou_vente = v1.Get_vente(trou_vente, d1);
                trou_vente = l5.Ligne_in(trou_vente);
                trou_achat = 0;
                
                if(v1.Get_surplus() > 0)
                {
                    d1.Get_dissip(v1.Get_surplus()); //on dissipe le surplus de vente
                    dissipation = d1.Get_energieDisipee(); //qte energie dissispee par dissipateur
                    surplus = d1.Get_surplus(); //surplus dissipateur
                    double var_random = b1.Get_charge(surplus); //surplus dissipateur va vers batterie  //un truc qui manque ?
                    surplus -= var_random;



                }
            }
            else //ni manque, ni surplus
            {
                trou_achat = 0;
                trou_vente = 0;
            }
            jour_nuit = this.ville.Get_status();
            total = prod_eolien + prod_nucleaire + trou_achat + bat_discharge ;
            Console.WriteLine("bat " + bat_discharge);
            total = l8.Ligne_in(total);
        }
    }
}