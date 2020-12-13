using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulation_reseau_elec
{
    public partial class View_graphe : Form
    {
        Meteo meteo = new Meteo(); 
        Consomateur consomateur = new Consomateur();
        Centrale centrale = new Centrale();
        Eolien Eos1 = new Eolien();
        Eolien Eos2 = new Eolien();
        Eolien Eos3 = new Eolien();
        Eolien Eos4 = new Eolien();
        Gaz Gaz1 = new Gaz();
        Nucleaire Nuc1 = new Nucleaire();
        Solaire sol1 = new Solaire();

        //Simulation simulation = new Simulation();
        public bool Sun;
        public double[] data = new double[1_000_000];
        int nextDataIndex = 1;
        //readonly Random rand = new Random(0);
        Color blueColor = Color.FromArgb(0, 128, 255);
        private bool last = false;
        public View_graphe()
        {
            InitializeComponent();
            Add_central();
            formsPlot1.plt.PlotSignal(data, maxRenderIndex: 100, color: blueColor);
            formsPlot1.plt.YLabel("Value");
            formsPlot1.plt.XLabel("Sample Number");
            Closed += (sender, args) =>
            {
                dataTimer?.Stop();
                renderTimer?.Stop();
            };
            centrale.Production_total();
        }
        private void dataTimer_Tick(object sender, EventArgs e)
        {
            double firstValue = 0;
            double latestValue = 0;
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
            
            //double randomValue = rand.Next(0, 10);
            consomateur.void_consomateur();
            firstValue = consomateur.conso_consomateur;
            //firstValue =  randomValue; //data[nextDataIndex - 1] + randomValue;
            latestValue = firstValue;
            //Console.WriteLine(latestValue);
            data[nextDataIndex] = latestValue;
            tbLastValue.Text = (latestValue > 0) ? "+" + latestValue.ToString() : latestValue.ToString(); // affiche la derniere valeur axe "Y"
            tbLatestValue.Text = nextDataIndex.ToString();           //affiche la valeur actuel axe "X"
            formsPlot1.plt.PlotSignal(data, maxRenderIndex: nextDataIndex, color: blueColor);
            nextDataIndex += 1;

            update();
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
                //Sun = cbSoleil.Checked;
                //meteo.SUN(Sun);
                
                //Console.WriteLine(T);
            }
        }

        private void numericUpDownVent_ValueChanged(object sender, EventArgs e)
        {
            meteo.vent = numericUpDownVent.Value;
            
        }

        private void numericUpDownTemperature_ValueChanged(object sender, EventArgs e)
        {
            meteo.temp = numericUpDownTemperature.Value;
            
        }

        public void update()
        {
            if (consomateur.conso_consomateur >= centrale.sum_total)
            {
                Add_gaz();
            }
            if(consomateur.conso_consomateur < centrale.sum_total && last == false)
            {
                centrale.sub_Gaz(Gaz1);
                last = true;
            }
        }
        public void Add_central()
        {
            if(meteo.vent >= 20)
            {
                centrale.sum_eolien = 0;
            }
            else if(meteo.vent < 20)
            {
                centrale.Add_Eolien(Eos1);
                centrale.Add_Eolien(Eos2);
                centrale.Add_Eolien(Eos3);
                centrale.Add_Eolien(Eos4);
            }
            centrale.Add_Nucleaire(Nuc1);
            centrale.Add_Solaire(sol1);
            centrale.Production_total();
        }
        public void Add_gaz()
        {
            centrale.Add_Gaz(Gaz1);
        }
    }
}
