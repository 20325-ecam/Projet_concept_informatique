using System;
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

        public string erreurs;

        public double prix_eolien;
        public double co2_eolien;
        public double prod_eolien;

        public double prix_nucleaire;
        public double co2_nucleaire;
        public double prod_nucleaire;

        public double conso_ville;
        public double conso_entreprise;

        Errors erreur_type1;

        Meteo bruxelles;
        Market market; 

        Centrale e1, n1, a1;

        public Consommateur ville, entreprise, v1, d1;

        Ligne l1, l2, l3, l4, l5, l6, l7, l8;

        List<Centrale> centrales;

        List<Consommateur> consommateurs;

        public Update()
        {
            erreur_type1 = new Error_1();

            bruxelles = new Meteo(30, 20, 60);
            market = new Market(10, 10, 10, 10); //nuc/eol/achat/vente

            //producteurs
            e1 = new Eolien(60000, 1, "e1", market, bruxelles);
            n1 = new Nucleaire(20000, 10, "n1", market);
            a1 = new Achat(2000, 100,"a1", market);

            //consommateurs
            ville = new Consommateur_random(1000, "ville");
            entreprise = new Consommateur_statique(8000, "entreprise");
            v1 = new Vente(5000,"v1", market);
            d1 = new Disipateur(10000, "d1"); //// a verifier !!!!!!!!!!!!!!!!!!!!!!!!!

            //lignes électriques
            l1 = new Ligne(20000); //eolien vers prod
            l2 = new Ligne(20000); //nucleaire vers prod
            l3 = new Ligne(80000); //conso vers ville
            l4 = new Ligne(80000); //conso vers entreprise
            l5 = new Ligne(100000); //conso vers vente
            l6 = new Ligne(10000); //achat vers prod
            l7 = new Ligne(8000); //conso vers disp
            l8 = new Ligne(50000); //prod vers conso
            
            centrales = new List<Centrale>();
            centrales.Add(e1);
            centrales.Add(n1);

            consommateurs = new List<Consommateur>();
            consommateurs.Add(ville);
            consommateurs.Add(entreprise);
        }
        public void get_new_Data()
        {
            prod_tot = 0;
            trou_achat = 0;
            conso_tot = 0;
            trou_energie = 0;
            abs_trou = 0;
            total = 0;
            ////////////
            erreurs = "";
            ////////////
            

            /*foreach (var centrale in centrales)
            {
                //prod_tot += centrale.Get_prod();
                CO2 += centrale.Get_co2();
                prix += centrale.Get_prix();
            }*/

            double Eo1 = e1.Get_prod();
            Eo1 = l1.Ligne_in(Eo1);
            prod_tot += Eo1;
            if (Eo1 == 0)
            {
                //e_surcharge(nameof(l1));
            }
            prix_eolien = e1.Get_prix();
            co2_eolien = e1.Get_co2();
            prod_eolien = Eo1;

            double Nu1 = n1.Get_prod();
            Nu1 = l2.Ligne_in(Nu1);
            prod_tot += Nu1;
            if (Nu1 == 0)
            {
                //e_surcharge(nameof(l2));
            }
            prix_nucleaire = n1.Get_prix();
            co2_nucleaire = n1.Get_co2();
            prod_nucleaire = Nu1;

            total += prod_tot;

            //*************************************************************************************************
            double ville = this.ville.Get_conso();
            ville = l3.Ligne_in(ville);
            conso_tot += ville;
            //if (ville == 0) { e_surcharge(nameof(ville)); }
            conso_ville = ville; 

            double entr = entreprise.Get_conso();
            entr = l4.Ligne_in(entr);
            conso_tot += entr;
            //if (entr == 0) { e_surcharge(nameof(entr)); }
            //tbEntreprise.Text = entr.ToString();
            conso_entreprise = entr;

            //*************************************************************************************************
            //Gestion manque & surplus E
            trou_energie = conso_tot - prod_tot;
            Console.WriteLine("trou " + trou_energie);
            abs_trou = Math.Abs(trou_energie);
            if (trou_energie > 0)
            {
                //rtbMessage.AppendText("il manque " + Math.Round(abs_trou).ToString() + " W \n");
                trou_achat = abs_trou;
                trou_achat = l6.Ligne_in(trou_achat);
                trou_vente = 0;
                trou_achat = a1.Get_achat(trou_achat);
                total += trou_achat;
                
            }
            else if (trou_energie < 0)
            {
                //rtbMessage.AppendText("il y a en trop " + Math.Round(abs_trou).ToString() + " W \n");
                trou_vente = abs_trou;
                trou_vente = l5.Ligne_in(trou_vente);
                trou_achat = 0;
                dissipation = d1.Get_energieDisipee();
                surplus = d1.Get_surplus();
                Console.WriteLine("vente " + trou_vente);
                v1.Get_vente(trou_vente, d1);

                erreurs += DateTime.Now.ToString();
                erreurs += erreur_type1.Show_error(e1); //DOOM
                erreurs += "\n";
                Console.WriteLine(erreurs);


            }
            else
            {
                trou_achat = 0;
                trou_vente = 0;

            }
            jour_nuit = this.ville.Get_status();
            total = prod_eolien + prod_nucleaire + trou_achat;
            total = l8.Ligne_in(total);
        }
    }
}
