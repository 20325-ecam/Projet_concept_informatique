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

        public double[] data = new double[1_000_000]; // buffer max du graphe
        Color blueColor = Color.FromArgb(0, 128, 255);
        Color redColor = Color.FromArgb(255, 0, 0);
        int nextDataIndex = 1;
        Update up;

        public View_graphe()
        {
            InitializeComponent();
            up = new Update(); 
            update();
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
            firstValue = up.conso_tot;
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

        public void update()
        {
            up.get_new_Data();
            rtbMessage.Text = "";
            rtbMessage.AppendText("Eolien: "
                + up.prix_eolien.ToString() + "€"   //prix_e1
                + up.co2_eolien.ToString() + "g"    //co2_e1
                + up.prod_eolien.ToString() + "W"   //prod-e1
                + "\n");
            rtbMessage.AppendText("Nucleaire: "
                + up.prix_nucleaire.ToString() + "€"   //prix_n1
                + up.co2_nucleaire.ToString() + "g"    //co2_n1
                + up.prod_nucleaire.ToString() + "W"   //prod-n1
                + "\n");
            rtbMessage.AppendText("Ville: "
                + up.conso_ville.ToString() + "W"   //conso_ville
                + "\n");
            rtbMessage.AppendText("Entreprise: "
                + up.conso_entreprise.ToString() + "W"   //conso_ville
                + "\n");
            rtbMessage.AppendText("Achat: "
                + up.trou_achat.ToString() + "W"   
                + "\n");
            rtbMessage.AppendText("Vente: "
                + up.trou_vente.ToString() + "W"   
                + "\n");
            tbJour_nuit.Text = up.jour_nuit;
            rtbMessage.AppendText("Total: "
                + up.total.ToString() + "W"
                + "\n");
            //val abs trou
            //achat
            //vente
            //jour nuit
            //tbCO2.Text = CO2.ToString();
            //tbPrix.Text = prix.ToString();*/
            //tbEolien.Text = Eo1.ToString();
            //rtbMessage.AppendText("Eolien: " + Math.Round(Eo1).ToString() + " W \n");
            /*tbNucleaire.Text = Nu1.ToString();
            rtbMessage.AppendText("Nucleaire: " + Math.Round(Nu1).ToString() + " W \n");*/
            /*tbVille.Text = ville.ToString();
            tbL1_ville.Text = ville.ToString();*/
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
