
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;
using ScottPlot.WinForms;

namespace WindowsFormsApp_test.presentation
{
    public partial class Form1 : Form
    {
        private readonly Random _random = new Random();
        double[] dataX = new double[] { 0 };
        double[] dataY = new double[] { 0 };
        int X = 0;
        int Y = 0;

        
        public Form1()
        {
            InitializeComponent();
            var plt = new ScottPlot.Plot(2000, 400);
            test2();
        }
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
        public void test()
        {
            
            formsPlot1.plt.PlotScatter(dataX, dataY);
            formsPlot1.Render();
        }

        public void update()
        {
            X += 1;
            Y = RandomNumber(5, 10);
            dataX = dataX.Concat(new double[] { X }).ToArray();
            dataY = dataY.Concat(new double[] { Y }).ToArray();
            
            test();
            
        }
        public void test2()
        {
            

            int pointCount = 51;
            double[] xs = DataGen.Consecutive(pointCount);
            double[] sin = DataGen.Sin(pointCount);
            double[] cos = DataGen.Cos(pointCount);

            formsPlot1.plt.PlotScatter(xs, sin, label: "sin");
            formsPlot1.plt.PlotScatter(xs, cos, label: "cos");
            formsPlot1.plt.Legend();

            formsPlot1.plt.Title("Scatter Plot Quickstart");
            formsPlot1.plt.YLabel("Vertical Units");
            formsPlot1.plt.XLabel("Horizontal Units");

            formsPlot1.plt.SaveFig("Quickstart_Quickstart_Scatter.png");
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            update();
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
