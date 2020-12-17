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
        //private bool last = false;
        int nextDataIndex = 1;
        Marcher m1;

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
            rtbMessage.Text = "";
            rtbMessage.AppendText("CO2: " +   CO2.ToString() + "g \n");
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
