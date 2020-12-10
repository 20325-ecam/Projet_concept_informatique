using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_test.presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private void formsPlot3_Load(object sender, EventArgs e)
        {
            double[] dataX = new double[] { 1, 2, 3, 4, 5 };
            double[] dataY = new double[] { 1, 4, 9, 16, 25 };
            var plt = new ScottPlot.Plot(400, 300);
            plt.PlotScatter(dataX, dataY);
            plt.SaveFig("quickstart.png");
        }
    }
}
