
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
        double[] dataX = new double[] { 1 };
        double[] dataY = new double[] { 1 };
        int X = 0;
        int Y = 0;
        public Form1()
        {
            InitializeComponent();
            
        }
        public void test()
        {
            formsPlot1.plt.PlotScatter(dataX, dataY);
            formsPlot1.Render();
        }

        public void chaud()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            X += 1;
            Y += 5;
            dataX = dataX.Concat(new double[] { X }).ToArray();
            dataY = dataY.Concat(new double[] { Y }).ToArray();
            test();
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
