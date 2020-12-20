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
using System.IO;

namespace simulation_reseau_elec
{
    
    public partial class View_graphe : Form
    {
        public double[] data1; 
        public double[] data2; 
        Color blueColor = Color.FromArgb(0, 128, 255);
        Color redColor = Color.FromArgb(255, 0, 0);
        int nextDataIndex = 1;
        int pcmValues = 240; //buffer max du graphique 

        Update up;

        public View_graphe()
        {
            InitializeComponent();
            up = new Update(); 
            update();
            
            data1 = new double[pcmValues];
            data2 = new double[pcmValues];
            formsPlot1.plt.PlotSignal(data2, sampleRate: pcmValues*100, color: redColor, label: "demande consommateur");
            formsPlot1.plt.PlotSignal(data1, sampleRate: pcmValues*100, color: blueColor, label: "production et achat");
            
            formsPlot1.plt.YLabel("Value");
            formsPlot1.plt.XLabel("Sample Number");
            formsPlot1.plt.Legend();
            Closed += (sender, args) =>
            {
                dataTimer?.Stop();
                renderTimer?.Stop();
            };
            formsPlot1.plt.Clear();
        }
        private void dataTimer_Tick(object sender, EventArgs e) //méthode appelée chaque seconde
        {
            double latestValue = 0;
            update();
            if (nextDataIndex >= data1.Length) 
            {
                formsPlot1.plt.SaveFig("../../image/Plot_Signal_consomateur " + DateTime.Now.ToString("dd MMMM yyyy HH-mm-ss") + ".png");
                nextDataIndex = 0;
            }
            latestValue = up.total - up.trou_vente; //up.conso_tot;
            data1[nextDataIndex] = latestValue;
            data2[nextDataIndex] = up.conso_ville + up.conso_entreprise;
            tbLastValue.Text = (latestValue > 0) ? "+" + latestValue.ToString() : latestValue.ToString(); // affiche la derniere valeur axe "Y"
            tbLatestValue.Text = nextDataIndex.ToString();  //affiche la valeur actuel axe "X"
            formsPlot1.plt.PlotSignal(data2, maxRenderIndex: nextDataIndex, color: redColor);
            formsPlot1.plt.PlotSignal(data1, maxRenderIndex: nextDataIndex, color: blueColor);
            nextDataIndex += 1;
        }
        private void renderTimer_Tick(object sender, EventArgs e)
        {
            if (cbAutoAxis.Checked)
            {
                formsPlot1.plt.AxisAuto();
            }
            formsPlot1.Render();
        }
        private void cbAutoAxis_CheckedChanged(object sender, EventArgs e)
        {
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
            up.get_new_Data();  //simulation du réseau
            rtbMessage.Text = "";
            rtbErrors.Text = "";

            rtbMessage.AppendText("Eolien: "
                + up.prix_eolien.ToString() + " € "   //prix_e1
                + up.co2_eolien.ToString() + " g "    //co2_e1
                + up.prod_eolien.ToString() + " W "   //prod-e1
                + "\n");

            rtbMessage.AppendText("Nucleaire: "
                + up.prix_nucleaire.ToString() + " € "   //prix_n1
                + up.co2_nucleaire.ToString() + " g "    //co2_n1
                + up.prod_nucleaire.ToString() + " W "   //prod-n1
                + "\n");

            rtbMessage.AppendText("Ville: "
                + up.conso_ville.ToString() + " W"   //conso_ville
                + "\n");

            rtbMessage.AppendText("Entreprise: "
                + up.conso_entreprise.ToString() + " W"   //conso_ville
                + "\n");

            rtbMessage.AppendText("Achat: "
                + up.trou_achat.ToString() + " W"   
                + "\n");

            rtbMessage.AppendText("Vente: "
                + up.trou_vente.ToString() + " W"   
                + "\n");

            tbJour_nuit.Text = up.jour_nuit;

            rtbMessage.AppendText("Total: "
                + up.total.ToString() + " W"
                + "\n");

            rtbMessage.AppendText("Disipateur: "
                + up.dissipation.ToString() + " W"
                + "\n");

            rtbMessage.AppendText("Surplus: "
                + up.surplus.ToString() + " W"
                + "\n");

            rtbErrors.Text = (
                up.erreurs.ToString()
               + "\n");

            rtbMessage.AppendText("Batt: "
                + up.battery_percentage.ToString() + " %"
                + "\n");

            tbVent.Text = up.vent.ToString();
        }
        public void e_surcharge(string zone)
        {
            rtbErrors.AppendText(DateTime.Now + " Ligne " + zone + " surcharge" + "\n");
        }

        private void tbJour_nuit_TextChanged(object sender, EventArgs e)
        {
        }

        private void rtbMessage_TextChanged(object sender, EventArgs e)
        {
        }

        private void rtbErrors_TextChanged(object sender, EventArgs e)
        {
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            formsPlot1.plt.SaveFig("../../image/Plot_Signal_consomateur " + DateTime.Now.ToString("dd MMMM yyyy HH-mm-ss") + ".png");
        }

        public void cbEolien_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEolien.Checked)
            {
                up.status = true;
            }
            else
            {
                up.status = false;
                up.prod_eolien = 0;
            }
        }

        private void tbVent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
