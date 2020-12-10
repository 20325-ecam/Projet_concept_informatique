
namespace WindowsFormsApp_test.presentation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.formsPlot3 = new ScottPlot.FormsPlot();
            this.SuspendLayout();
            // 
            // formsPlot3
            // 
            this.formsPlot3.Location = new System.Drawing.Point(77, 0);
            this.formsPlot3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.formsPlot3.Name = "formsPlot3";
            this.formsPlot3.Size = new System.Drawing.Size(588, 427);
            this.formsPlot3.TabIndex = 0;
            this.formsPlot3.Load += new System.EventHandler(this.formsPlot3_Load);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(769, 637);
            this.Controls.Add(this.formsPlot3);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private ScottPlot.FormsPlot formsPlot2;
        private ScottPlot.FormsPlot formsPlot3;
    }
}