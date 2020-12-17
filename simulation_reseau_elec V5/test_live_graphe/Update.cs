using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Update
    {
        public double prod_tot = 0;
        public double conso_tot = 0;
        public double trou_energie = 0; // si + -> manque E ; si + -> surplus E
        public double abs_trou = 0;
        public bool Sun;

        Meteo Bruxelles = new Meteo(30, 20, 60);
        Market market = new Market(10, 10, 10, 10); //nuc/eol/achat/vente
        Centrale e1, n1, a1;

        Consommateur vil, entreprise, v1;
        Ligne l1, l2, l3, l4, l5, l6, l7, l8;

        
        public Update()
        {
            e1 = new Eolien(6000, 0, market, Bruxelles);        //declare dans update()
            n1 = new Nucleaire(2000, 10, market);
            a1 = new Achat(2000, 100, market);

            vil = new Consommateur_random(1000);
            entreprise = new Consommateur_statique(8000);
            v1 = new Vente(5000, market);

            l1 = new Ligne(2000); //eolien vers prod
            l2 = new Ligne(2000); //nucleaire vers prod
            l3 = new Ligne(8000); //conso vers ville
            l4 = new Ligne(8000); //conso vers entreprise
            l5 = new Ligne(10000); //conso vers vente
            l6 = new Ligne(10000); //achat vers prod
            l7 = new Ligne(8000); //conso vers disp
            l8 = new Ligne(11000); //prod vers conso
        }
        public void get_marcher()
        {
            //création des consommateurs et producteurs
            prod_tot = 0;
            conso_tot = 0;
            trou_energie = 0; // si + -> manque E ; si + -> surplus E
            abs_trou = 0;
            double trou_achat = 0;
            double trou_vente;
            double total = 0;
            int prix = 0;
            int CO2 = 0;

            //rtbErrors.Text = "";
            Centrale e1 = new Eolien(6000, 10, 1, Bruxelles);

            //ensemble des producteurs
            List<Centrale> centrales = new List<Centrale>();
            centrales.Add(e1);
            centrales.Add(n1);
            foreach (var centrale in centrales)
            {
                //prod_tot += centrale.Get_prod();
                CO2 += centrale.Get_co2();
                prix += centrale.Get_prix();
            }


            rtbMessage.AppendText("Prix: " + prix.ToString() + "€ \n");
            tbCO2.Text = CO2.ToString();
            tbPrix.Text = prix.ToString();

            double Eo1 = e1.Get_prod();
            Eo1 = l1.Ligne_in(Eo1);
            prod_tot += Eo1;
            if (Eo1 == 0)
            {
                e_surcharge(nameof(l1));
            }
            tbEolien.Text = Eo1.ToString();
            rtbMessage.AppendText("Eolien: " + Math.Round(Eo1).ToString() + " W \n");

            double Nu1 = n1.Get_prod();
            Nu1 = l2.Ligne_in(Nu1);
            prod_tot += Nu1;
            if (Nu1 == 0)
            {
                e_surcharge(nameof(l2));
            }
            tbNucleaire.Text = Nu1.ToString();
            rtbMessage.AppendText("Nucleaire: " + Math.Round(Nu1).ToString() + " W \n");
            total += prod_tot;
            //Console.WriteLine("prod est de " + prod_tot + " W");
            //*************************************************************************************************
            //ensemble des consommateurs
            List<Consommateur> consommateurs = new List<Consommateur>();
            consommateurs.Add(vil);
            consommateurs.Add(entreprise);

            double ville = vil.Get_conso();
            ville = l3.Ligne_in(ville);
            conso_tot += ville;
            if (ville == 0) { e_surcharge(nameof(ville)); }
            tbVille.Text = ville.ToString();
            tbL1_ville.Text = ville.ToString();

            double entr = entreprise.Get_conso();
            entr = l4.Ligne_in(entr);
            conso_tot += entr;
            if (entr == 0) { e_surcharge(nameof(entr)); }
            tbEntreprise.Text = entr.ToString();

            //Gestion manque & surplus E
            trou_energie = conso_tot - prod_tot;
            abs_trou = Math.Abs(trou_energie);
            //Console.WriteLine("trou est de " + trou_energie + " W");
            if (trou_energie > 0)
            {
                rtbMessage.AppendText("il manque " + Math.Round(abs_trou).ToString() + " W \n");
                //rtbMessage.Text += "il manque " + abs_trou.ToString() + " W";
                //Console.WriteLine("il manque " + abs_trou + " W");
                trou_achat = abs_trou;
                trou_achat = l6.Ligne_in(trou_achat);
                trou_vente = 0;
                trou_achat = a1.Get_achat(trou_achat);
                total += trou_achat;
                tbAchat.Text = trou_achat.ToString();
                tbVente.Text = trou_vente.ToString();
            }
            else if (trou_energie < 0)
            {
                rtbMessage.AppendText("il y a en trop " + Math.Round(abs_trou).ToString() + " W \n");
                //rtbMessage.Text += "il y a en trop " + abs_trou.ToString() + " W";
                //Console.WriteLine("il y a en trop " + abs_trou + " W");
                trou_vente = abs_trou;
                trou_vente = l5.Ligne_in(trou_vente);
                trou_achat = 0;
                v1.Get_vente(trou_vente);
                tbAchat.Text = trou_achat.ToString();
                tbVente.Text = trou_vente.ToString();
            }
            tbJour_nuit.Text = vil.Get_status();
            total = l8.Ligne_in(total);
            //total = prod_tot + trou_achat;
            rtbMessage.AppendText(total.ToString());
            rtbMessage.AppendText("\n");
            rtbMessage.Text += " *******************";
            //Console.WriteLine("************************");
        }
    }
}
