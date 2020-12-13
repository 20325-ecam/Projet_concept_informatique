
namespace simulation_reseau_elec
{
    partial class View_graphe
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.tbLatestValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lTemperature = new System.Windows.Forms.Label();
            this.numericUpDownTemperature = new System.Windows.Forms.NumericUpDown();
            this.lVent = new System.Windows.Forms.Label();
            this.numericUpDownVent = new System.Windows.Forms.NumericUpDown();
            this.cbSoleil = new System.Windows.Forms.CheckBox();
            this.cbAutoAxis = new System.Windows.Forms.CheckBox();
            this.tbLastValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataTimer = new System.Windows.Forms.Timer(this.components);
            this.renderTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVent)).BeginInit();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(15, 98);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(920, 350);
            this.formsPlot1.TabIndex = 0;
            this.formsPlot1.Load += new System.EventHandler(this.formsPlot1_Load);
            // 
            // tbLatestValue
            // 
            this.tbLatestValue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLatestValue.Location = new System.Drawing.Point(72, 48);
            this.tbLatestValue.Name = "tbLatestValue";
            this.tbLatestValue.ReadOnly = true;
            this.tbLatestValue.Size = new System.Drawing.Size(61, 23);
            this.tbLatestValue.TabIndex = 5;
            this.tbLatestValue.Text = "123";
            this.tbLatestValue.TextChanged += new System.EventHandler(this.tbLatestValue_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "readings: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "This example simulates live display of a growing dataset";
            // 
            // lTemperature
            // 
            this.lTemperature.AutoSize = true;
            this.lTemperature.Location = new System.Drawing.Point(859, 49);
            this.lTemperature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTemperature.Name = "lTemperature";
            this.lTemperature.Size = new System.Drawing.Size(67, 13);
            this.lTemperature.TabIndex = 19;
            this.lTemperature.Text = "Temperature";
            // 
            // numericUpDownTemperature
            // 
            this.numericUpDownTemperature.Location = new System.Drawing.Point(764, 48);
            this.numericUpDownTemperature.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownTemperature.Name = "numericUpDownTemperature";
            this.numericUpDownTemperature.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownTemperature.TabIndex = 18;
            this.numericUpDownTemperature.ValueChanged += new System.EventHandler(this.numericUpDownTemperature_ValueChanged);
            // 
            // lVent
            // 
            this.lVent.AutoSize = true;
            this.lVent.Location = new System.Drawing.Point(659, 52);
            this.lVent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lVent.Name = "lVent";
            this.lVent.Size = new System.Drawing.Size(56, 13);
            this.lVent.TabIndex = 17;
            this.lVent.Text = "Vent (m/s)";
            // 
            // numericUpDownVent
            // 
            this.numericUpDownVent.Location = new System.Drawing.Point(564, 48);
            this.numericUpDownVent.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownVent.Maximum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.numericUpDownVent.Name = "numericUpDownVent";
            this.numericUpDownVent.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownVent.TabIndex = 16;
            this.numericUpDownVent.ValueChanged += new System.EventHandler(this.numericUpDownVent_ValueChanged);
            // 
            // cbSoleil
            // 
            this.cbSoleil.AutoSize = true;
            this.cbSoleil.Location = new System.Drawing.Point(512, 49);
            this.cbSoleil.Margin = new System.Windows.Forms.Padding(2);
            this.cbSoleil.Name = "cbSoleil";
            this.cbSoleil.Size = new System.Drawing.Size(51, 17);
            this.cbSoleil.TabIndex = 15;
            this.cbSoleil.Text = "Soleil";
            this.cbSoleil.UseVisualStyleBackColor = true;
            this.cbSoleil.CheckedChanged += new System.EventHandler(this.cbSoleil_CheckedChanged);
            // 
            // cbAutoAxis
            // 
            this.cbAutoAxis.AutoSize = true;
            this.cbAutoAxis.Checked = true;
            this.cbAutoAxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoAxis.Location = new System.Drawing.Point(332, 51);
            this.cbAutoAxis.Name = "cbAutoAxis";
            this.cbAutoAxis.Size = new System.Drawing.Size(146, 17);
            this.cbAutoAxis.TabIndex = 14;
            this.cbAutoAxis.Text = "auto-axis on each update";
            this.cbAutoAxis.UseVisualStyleBackColor = true;
            this.cbAutoAxis.CheckedChanged += new System.EventHandler(this.cbAutoAxis_CheckedChanged);
            // 
            // tbLastValue
            // 
            this.tbLastValue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastValue.Location = new System.Drawing.Point(224, 49);
            this.tbLastValue.Name = "tbLastValue";
            this.tbLastValue.ReadOnly = true;
            this.tbLastValue.Size = new System.Drawing.Size(74, 23);
            this.tbLastValue.TabIndex = 13;
            this.tbLastValue.Text = "+123.4";
            this.tbLastValue.TextChanged += new System.EventHandler(this.tbLastValue_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "latest value:";
            // 
            // dataTimer
            // 
            this.dataTimer.Enabled = true;
            this.dataTimer.Interval = 500;
            this.dataTimer.Tick += new System.EventHandler(this.dataTimer_Tick);
            // 
            // renderTimer
            // 
            this.renderTimer.Enabled = true;
            this.renderTimer.Interval = 500;
            this.renderTimer.Tick += new System.EventHandler(this.renderTimer_Tick);
            // 
            // View_graphe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 475);
            this.Controls.Add(this.lTemperature);
            this.Controls.Add(this.numericUpDownTemperature);
            this.Controls.Add(this.lVent);
            this.Controls.Add(this.numericUpDownVent);
            this.Controls.Add(this.cbSoleil);
            this.Controls.Add(this.cbAutoAxis);
            this.Controls.Add(this.tbLastValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLatestValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formsPlot1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "View_graphe";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.TextBox tbLatestValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lTemperature;
        private System.Windows.Forms.NumericUpDown numericUpDownTemperature;
        private System.Windows.Forms.Label lVent;
        private System.Windows.Forms.NumericUpDown numericUpDownVent;
        private System.Windows.Forms.CheckBox cbSoleil;
        private System.Windows.Forms.CheckBox cbAutoAxis;
        private System.Windows.Forms.TextBox tbLastValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer dataTimer;
        private System.Windows.Forms.Timer renderTimer;
    }
}

