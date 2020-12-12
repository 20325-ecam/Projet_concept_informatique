namespace ScottPlot.Demo.WinForms.WinFormsDemos
{
    partial class LiveDataIncoming
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
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLatestValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastValue = new System.Windows.Forms.TextBox();
            this.dataTimer = new System.Windows.Forms.Timer(this.components);
            this.renderTimer = new System.Windows.Forms.Timer(this.components);
            this.cbAutoAxis = new System.Windows.Forms.CheckBox();
            this.cbSoleil = new System.Windows.Forms.CheckBox();
            this.numericUpDownVent = new System.Windows.Forms.NumericUpDown();
            this.lVent = new System.Windows.Forms.Label();
            this.numericUpDownTemperature = new System.Windows.Forms.NumericUpDown();
            this.lTemperature = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formsPlot1.Location = new System.Drawing.Point(16, 71);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(5);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(1702, 468);
            this.formsPlot1.TabIndex = 0;
            this.formsPlot1.Load += new System.EventHandler(this.formsPlot1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "This example simulates live display of a growing dataset";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "readings: ";
            // 
            // tbLatestValue
            // 
            this.tbLatestValue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLatestValue.Location = new System.Drawing.Point(91, 36);
            this.tbLatestValue.Margin = new System.Windows.Forms.Padding(4);
            this.tbLatestValue.Name = "tbLatestValue";
            this.tbLatestValue.ReadOnly = true;
            this.tbLatestValue.Size = new System.Drawing.Size(80, 27);
            this.tbLatestValue.TabIndex = 3;
            this.tbLatestValue.Text = "123";
            this.tbLatestValue.TextChanged += new System.EventHandler(this.tbLatestValue_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "latest value:";
            // 
            // tbLastValue
            // 
            this.tbLastValue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastValue.Location = new System.Drawing.Point(311, 36);
            this.tbLastValue.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastValue.Name = "tbLastValue";
            this.tbLastValue.ReadOnly = true;
            this.tbLastValue.Size = new System.Drawing.Size(97, 27);
            this.tbLastValue.TabIndex = 5;
            this.tbLastValue.Text = "+123.4";
            // 
            // dataTimer
            // 
            this.dataTimer.Enabled = true;
            this.dataTimer.Interval = 1;
            this.dataTimer.Tick += new System.EventHandler(this.dataTimer_Tick);
            // 
            // renderTimer
            // 
            this.renderTimer.Enabled = true;
            this.renderTimer.Interval = 20;
            this.renderTimer.Tick += new System.EventHandler(this.renderTimer_Tick);
            // 
            // cbAutoAxis
            // 
            this.cbAutoAxis.AutoSize = true;
            this.cbAutoAxis.Checked = true;
            this.cbAutoAxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoAxis.Location = new System.Drawing.Point(456, 39);
            this.cbAutoAxis.Margin = new System.Windows.Forms.Padding(4);
            this.cbAutoAxis.Name = "cbAutoAxis";
            this.cbAutoAxis.Size = new System.Drawing.Size(190, 21);
            this.cbAutoAxis.TabIndex = 6;
            this.cbAutoAxis.Text = "auto-axis on each update";
            this.cbAutoAxis.UseVisualStyleBackColor = true;
            this.cbAutoAxis.CheckedChanged += new System.EventHandler(this.cbAutoAxis_CheckedChanged);
            // 
            // cbSoleil
            // 
            this.cbSoleil.AutoSize = true;
            this.cbSoleil.Location = new System.Drawing.Point(695, 36);
            this.cbSoleil.Name = "cbSoleil";
            this.cbSoleil.Size = new System.Drawing.Size(64, 21);
            this.cbSoleil.TabIndex = 7;
            this.cbSoleil.Text = "Soleil";
            this.cbSoleil.UseVisualStyleBackColor = true;
            this.cbSoleil.CheckedChanged += new System.EventHandler(this.cbSoleil_CheckedChanged);
            // 
            // numericUpDownVent
            // 
            this.numericUpDownVent.Location = new System.Drawing.Point(765, 35);
            this.numericUpDownVent.Name = "numericUpDownVent";
            this.numericUpDownVent.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownVent.TabIndex = 8;
            this.numericUpDownVent.ValueChanged += new System.EventHandler(this.numericUpDownVent_ValueChanged);
            // 
            // lVent
            // 
            this.lVent.AutoSize = true;
            this.lVent.Location = new System.Drawing.Point(892, 40);
            this.lVent.Name = "lVent";
            this.lVent.Size = new System.Drawing.Size(73, 17);
            this.lVent.TabIndex = 9;
            this.lVent.Text = "Vent (m/s)";
            // 
            // numericUpDownTemperature
            // 
            this.numericUpDownTemperature.Location = new System.Drawing.Point(1031, 40);
            this.numericUpDownTemperature.Name = "numericUpDownTemperature";
            this.numericUpDownTemperature.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownTemperature.TabIndex = 10;
            this.numericUpDownTemperature.ValueChanged += new System.EventHandler(this.numericUpDownTemperature_ValueChanged);
            // 
            // lTemperature
            // 
            this.lTemperature.AutoSize = true;
            this.lTemperature.Location = new System.Drawing.Point(1158, 46);
            this.lTemperature.Name = "lTemperature";
            this.lTemperature.Size = new System.Drawing.Size(90, 17);
            this.lTemperature.TabIndex = 11;
            this.lTemperature.Text = "Temperature";
            this.lTemperature.Click += new System.EventHandler(this.lTemperature_Click);
            // 
            // LiveDataIncoming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 554);
            this.Controls.Add(this.lTemperature);
            this.Controls.Add(this.numericUpDownTemperature);
            this.Controls.Add(this.lVent);
            this.Controls.Add(this.numericUpDownVent);
            this.Controls.Add(this.cbSoleil);
            this.Controls.Add(this.cbAutoAxis);
            this.Controls.Add(this.tbLastValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLatestValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formsPlot1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LiveDataIncoming";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Live Data (growing)";
            this.Load += new System.EventHandler(this.LiveDataIncoming_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormsPlot formsPlot1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLatestValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastValue;
        private System.Windows.Forms.Timer dataTimer;
        private System.Windows.Forms.Timer renderTimer;
        private System.Windows.Forms.CheckBox cbAutoAxis;
        private System.Windows.Forms.CheckBox cbSoleil;
        private System.Windows.Forms.NumericUpDown numericUpDownVent;
        private System.Windows.Forms.Label lVent;
        private System.Windows.Forms.NumericUpDown numericUpDownTemperature;
        private System.Windows.Forms.Label lTemperature;
    }
}