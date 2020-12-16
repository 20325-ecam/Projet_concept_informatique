using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace simulation_reseau_elec
{
    public partial class View_graphe : Form
    {
        public double prod_tot = 0;
        public double conso_tot = 0;
        public double trou_energie = 0; // si + -> manque E ; si + -> surplus E
        public double abs_trou = 0;
        public bool Sun;
        public double[] data = new double[1_000_000]; // buffer max du graphe
        int nextDataIndex = 1;
        Color blueColor = Color.FromArgb(0, 128, 255);
        Color redColor = Color.FromArgb(255, 0, 0);
        Meteo Bruxelles = new Meteo(30, 20, 60);
        //Centrale e1 = new Eolien(6000, 10,1, Bruxelles);        //declare dans update()
        Centrale n1 = new Nucleaire(2000, 100, 0);
        Centrale a1 = new Achat(2000, 100, 0);
        Consommateur vil = new Consommateur_random(1000);
        Consommateur entreprise = new Consommateur_statique(8000);
        Consommateur v1 = new Vente(5000);
        Ligne l1 = new Ligne(2000); //eolien vers prod
        Ligne l2 = new Ligne(2000); //nucleaire vers prod
        Ligne l3 = new Ligne(8000); //conso vers ville
        Ligne l4 = new Ligne(8000); //conso vers entreprise
        Ligne l5 = new Ligne(10000); //conso vers vente
        Ligne l6 = new Ligne(10000); //achat vers prod
        Ligne l7 = new Ligne(8000); //conso vers disp
        Ligne l8 = new Ligne(11000); //prod vers conso

        //private bool last = false;


        public View_graphe()
        {
            InitializeComponent();
            //Centrale e1 = new Eolien(6000, 10, 1, Bruxelles);
            update();
            //Add_central();
            formsPlot1.plt.PlotSignal(data, maxRenderIndex: 100, color: blueColor);
            formsPlot1.plt.YLabel("Value");
            formsPlot1.plt.XLabel("Sample Number");
            Closed += (sender, args) =>
            {
                dataTimer?.Stop();
                renderTimer?.Stop();
            };
            //centrale.Production_total();
        }
        private void dataTimer_Tick(object sender, EventArgs e)
        {
            double firstValue = 0;
            double latestValue = 0;
            update();
            if (nextDataIndex >= data.Length)
            {
                //throw new OverflowException("data array isn't long enough to accomodate new data");
                // in this situation the solution would be:
                //   1. clear the plot
                //   2. create a new larger array
                //   3. copy the old data into the start of the larger array
                //   4. plot the new (larger) array
                //   5. continue to update the new array
            }
            firstValue = conso_tot;
            latestValue = firstValue;
            data[nextDataIndex] = latestValue;
            tbLastValue.Text = (latestValue > 0) ? "+" + latestValue.ToString() : latestValue.ToString(); // affiche la derniere valeur axe "Y"
            tbLatestValue.Text = nextDataIndex.ToString();           //affiche la valeur actuel axe "X"
            formsPlot1.plt.PlotSignal(data, maxRenderIndex: nextDataIndex, color: blueColor);
            nextDataIndex += 1;
        }
        private void renderTimer_Tick(object sender, EventArgs e)
        {
            if (cbAutoAxis.Checked)
                formsPlot1.plt.AxisAuto();
            formsPlot1.Render();
        }
        private void cbAutoAxis_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoAxis.Checked == false)
            {
                //formsPlot1.plt.AxisAuto(verticalMargin: .5);
            }
        }
        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }
        private void tbLatestValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLastValue_TextChanged(object sender, EventArgs e)
        {

        }

        public void cbSoleil_CheckedChanged(object sender, EventArgs e)
        {
            //meteo.Soleil = cbSoleil.Checked;
            if (cbSoleil.Checked == false)
            {
                //System.Windows.MessageBox.Show("helloe");
                //Sun = cbSoleil.Checked;
                //meteo.SUN(Sun);

                //Console.WriteLine(T);
            }
        }

        private void numericUpDownVent_ValueChanged(object sender, EventArgs e)
        {
            //meteo.vent = numericUpDownVent.Value;
            
        }

        private void numericUpDownTemperature_ValueChanged(object sender, EventArgs e)
        {
            //meteo.temp = numericUpDownTemperature.Value;
            
        }

        public void update()
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
            rtbMessage.Text = "";
            //rtbErrors.Text = "";
            Centrale e1 = new Eolien(6000, 10, 1,  Bruxelles);

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
            rtbMessage.AppendText("CO2: " + CO2.ToString() + "g \n");
            rtbMessage.AppendText("Prix: " + prix.ToString() + "€ \n");
            tbCO2.Text = CO2.ToString();
            tbPrix.Text = prix.ToString();
            
            double Eo1 = e1.Get_prod();
            Eo1 = l1.Ligne_in(Eo1);
            prod_tot += Eo1;
            if(Eo1 == 0)
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
        public void e_surcharge(string zone)
        {
            rtbErrors.AppendText(DateTime.Now + " Ligne " + zone + " surcharge" + "\n");
        }
        private void tbAchat_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbVente_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbJour_nuit_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEolien_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNucleaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbVille_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEntreprise_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPrix_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCO2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbMessage_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void tbL1_ville_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbErrors_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
