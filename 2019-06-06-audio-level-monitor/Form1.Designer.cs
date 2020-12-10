namespace AudioPeak
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
            this.cbDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.scottPlotUC1 = new ScottPlot.ScottPlotUC();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbAutoAxis = new System.Windows.Forms.CheckBox();
            this.scottPlotUC2 = new ScottPlot.ScottPlotUC();
            this.SuspendLayout();
            // 
            // cbDevice
            // 
            this.cbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Location = new System.Drawing.Point(155, 15);
            this.cbDevice.Margin = new System.Windows.Forms.Padding(4);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(227, 24);
            this.cbDevice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Audio input device:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(391, 14);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(499, 14);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 28);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // scottPlotUC1
            // 
            this.scottPlotUC1.AutoScroll = true;
            this.scottPlotUC1.AutoSize = true;
            this.scottPlotUC1.Location = new System.Drawing.Point(16, 49);
            this.scottPlotUC1.Margin = new System.Windows.Forms.Padding(5);
            this.scottPlotUC1.Name = "scottPlotUC1";
            this.scottPlotUC1.Size = new System.Drawing.Size(1035, 490);
            this.scottPlotUC1.TabIndex = 4;
            this.scottPlotUC1.Load += new System.EventHandler(this.scottPlotUC1_Load);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // cbAutoAxis
            // 
            this.cbAutoAxis.AutoSize = true;
            this.cbAutoAxis.Checked = true;
            this.cbAutoAxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoAxis.Location = new System.Drawing.Point(607, 17);
            this.cbAutoAxis.Margin = new System.Windows.Forms.Padding(4);
            this.cbAutoAxis.Name = "cbAutoAxis";
            this.cbAutoAxis.Size = new System.Drawing.Size(88, 21);
            this.cbAutoAxis.TabIndex = 5;
            this.cbAutoAxis.Text = "Auto-axis";
            this.cbAutoAxis.UseVisualStyleBackColor = true;
            // 
            // scottPlotUC2
            // 
            this.scottPlotUC2.Location = new System.Drawing.Point(82, 571);
            this.scottPlotUC2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scottPlotUC2.Name = "scottPlotUC2";
            this.scottPlotUC2.Size = new System.Drawing.Size(950, 503);
            this.scottPlotUC2.TabIndex = 6;
            this.scottPlotUC2.Load += new System.EventHandler(this.scottPlotUC2_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 1100);
            this.Controls.Add(this.scottPlotUC2);
            this.Controls.Add(this.cbAutoAxis);
            this.Controls.Add(this.scottPlotUC1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDevice);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "C# Audio Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private ScottPlot.ScottPlotUC scottPlotUC1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbAutoAxis;
        private ScottPlot.ScottPlotUC scottPlotUC2;
    }
}

