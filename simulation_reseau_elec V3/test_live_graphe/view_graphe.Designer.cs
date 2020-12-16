
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
            this.tbAchat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbVente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbJour_nuit = new System.Windows.Forms.TextBox();
            this.tbNucleaire = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEolien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEntreprise = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCO2 = new System.Windows.Forms.TextBox();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbL1_ville = new System.Windows.Forms.TextBox();
            this.tbL2_entreprise = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVent)).BeginInit();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(20, 121);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(5);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(1227, 431);
            this.formsPlot1.TabIndex = 0;
            this.formsPlot1.Load += new System.EventHandler(this.formsPlot1_Load);
            // 
            // tbLatestValue
            // 
            this.tbLatestValue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLatestValue.Location = new System.Drawing.Point(96, 59);
            this.tbLatestValue.Margin = new System.Windows.Forms.Padding(4);
            this.tbLatestValue.Name = "tbLatestValue";
            this.tbLatestValue.ReadOnly = true;
            this.tbLatestValue.Size = new System.Drawing.Size(80, 27);
            this.tbLatestValue.TabIndex = 5;
            this.tbLatestValue.Text = "123";
            this.tbLatestValue.TextChanged += new System.EventHandler(this.tbLatestValue_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "readings: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "This example simulates live display of a growing dataset";
            // 
            // lTemperature
            // 
            this.lTemperature.AutoSize = true;
            this.lTemperature.Location = new System.Drawing.Point(1145, 60);
            this.lTemperature.Name = "lTemperature";
            this.lTemperature.Size = new System.Drawing.Size(90, 17);
            this.lTemperature.TabIndex = 19;
            this.lTemperature.Text = "Temperature";
            // 
            // numericUpDownTemperature
            // 
            this.numericUpDownTemperature.Location = new System.Drawing.Point(1019, 59);
            this.numericUpDownTemperature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownTemperature.Name = "numericUpDownTemperature";
            this.numericUpDownTemperature.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownTemperature.TabIndex = 18;
            this.numericUpDownTemperature.ValueChanged += new System.EventHandler(this.numericUpDownTemperature_ValueChanged);
            // 
            // lVent
            // 
            this.lVent.AutoSize = true;
            this.lVent.Location = new System.Drawing.Point(879, 64);
            this.lVent.Name = "lVent";
            this.lVent.Size = new System.Drawing.Size(73, 17);
            this.lVent.TabIndex = 17;
            this.lVent.Text = "Vent (m/s)";
            // 
            // numericUpDownVent
            // 
            this.numericUpDownVent.Location = new System.Drawing.Point(752, 59);
            this.numericUpDownVent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownVent.Maximum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.numericUpDownVent.Name = "numericUpDownVent";
            this.numericUpDownVent.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownVent.TabIndex = 16;
            this.numericUpDownVent.ValueChanged += new System.EventHandler(this.numericUpDownVent_ValueChanged);
            // 
            // cbSoleil
            // 
            this.cbSoleil.AutoSize = true;
            this.cbSoleil.Location = new System.Drawing.Point(683, 60);
            this.cbSoleil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSoleil.Name = "cbSoleil";
            this.cbSoleil.Size = new System.Drawing.Size(64, 21);
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
            this.cbAutoAxis.Location = new System.Drawing.Point(443, 63);
            this.cbAutoAxis.Margin = new System.Windows.Forms.Padding(4);
            this.cbAutoAxis.Name = "cbAutoAxis";
            this.cbAutoAxis.Size = new System.Drawing.Size(190, 21);
            this.cbAutoAxis.TabIndex = 14;
            this.cbAutoAxis.Text = "auto-axis on each update";
            this.cbAutoAxis.UseVisualStyleBackColor = true;
            this.cbAutoAxis.CheckedChanged += new System.EventHandler(this.cbAutoAxis_CheckedChanged);
            // 
            // tbLastValue
            // 
            this.tbLastValue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastValue.Location = new System.Drawing.Point(299, 60);
            this.tbLastValue.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastValue.Name = "tbLastValue";
            this.tbLastValue.ReadOnly = true;
            this.tbLastValue.Size = new System.Drawing.Size(97, 27);
            this.tbLastValue.TabIndex = 13;
            this.tbLastValue.Text = "+123.4";
            this.tbLastValue.TextChanged += new System.EventHandler(this.tbLastValue_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
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
            // tbAchat
            // 
            this.tbAchat.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAchat.Location = new System.Drawing.Point(73, 637);
            this.tbAchat.Margin = new System.Windows.Forms.Padding(4);
            this.tbAchat.Name = "tbAchat";
            this.tbAchat.ReadOnly = true;
            this.tbAchat.Size = new System.Drawing.Size(80, 27);
            this.tbAchat.TabIndex = 20;
            this.tbAchat.Text = "0";
            this.tbAchat.TextChanged += new System.EventHandler(this.tbAchat_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 637);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Achat: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 696);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Vente: ";
            // 
            // tbVente
            // 
            this.tbVente.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVente.Location = new System.Drawing.Point(73, 696);
            this.tbVente.Margin = new System.Windows.Forms.Padding(4);
            this.tbVente.Name = "tbVente";
            this.tbVente.ReadOnly = true;
            this.tbVente.Size = new System.Drawing.Size(80, 27);
            this.tbVente.TabIndex = 22;
            this.tbVente.Text = "0";
            this.tbVente.TextChanged += new System.EventHandler(this.tbVente_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 637);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Jour-Nuit:";
            // 
            // tbJour_nuit
            // 
            this.tbJour_nuit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJour_nuit.Location = new System.Drawing.Point(334, 632);
            this.tbJour_nuit.Margin = new System.Windows.Forms.Padding(4);
            this.tbJour_nuit.Name = "tbJour_nuit";
            this.tbJour_nuit.ReadOnly = true;
            this.tbJour_nuit.Size = new System.Drawing.Size(80, 27);
            this.tbJour_nuit.TabIndex = 24;
            this.tbJour_nuit.Text = "0";
            this.tbJour_nuit.TextChanged += new System.EventHandler(this.tbJour_nuit_TextChanged);
            // 
            // tbNucleaire
            // 
            this.tbNucleaire.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNucleaire.Location = new System.Drawing.Point(553, 696);
            this.tbNucleaire.Margin = new System.Windows.Forms.Padding(4);
            this.tbNucleaire.Name = "tbNucleaire";
            this.tbNucleaire.ReadOnly = true;
            this.tbNucleaire.Size = new System.Drawing.Size(80, 27);
            this.tbNucleaire.TabIndex = 28;
            this.tbNucleaire.Text = "0";
            this.tbNucleaire.TextChanged += new System.EventHandler(this.tbNucleaire_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(493, 637);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Eolien: ";
            // 
            // tbEolien
            // 
            this.tbEolien.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEolien.Location = new System.Drawing.Point(553, 637);
            this.tbEolien.Margin = new System.Windows.Forms.Padding(4);
            this.tbEolien.Name = "tbEolien";
            this.tbEolien.ReadOnly = true;
            this.tbEolien.Size = new System.Drawing.Size(80, 27);
            this.tbEolien.TabIndex = 26;
            this.tbEolien.Text = "0";
            this.tbEolien.TextChanged += new System.EventHandler(this.tbEolien_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 701);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Nucleaire: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(689, 701);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Entreprise:";
            // 
            // tbEntreprise
            // 
            this.tbEntreprise.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEntreprise.Location = new System.Drawing.Point(766, 696);
            this.tbEntreprise.Margin = new System.Windows.Forms.Padding(4);
            this.tbEntreprise.Name = "tbEntreprise";
            this.tbEntreprise.ReadOnly = true;
            this.tbEntreprise.Size = new System.Drawing.Size(80, 27);
            this.tbEntreprise.TabIndex = 32;
            this.tbEntreprise.Text = "0";
            this.tbEntreprise.TextChanged += new System.EventHandler(this.tbEntreprise_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(703, 637);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Ville: ";
            // 
            // tbVille
            // 
            this.tbVille.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVille.Location = new System.Drawing.Point(766, 637);
            this.tbVille.Margin = new System.Windows.Forms.Padding(4);
            this.tbVille.Name = "tbVille";
            this.tbVille.ReadOnly = true;
            this.tbVille.Size = new System.Drawing.Size(80, 27);
            this.tbVille.TabIndex = 30;
            this.tbVille.Text = "0";
            this.tbVille.TextChanged += new System.EventHandler(this.tbVille_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-4, 835);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "CO2:";
            // 
            // tbCO2
            // 
            this.tbCO2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCO2.Location = new System.Drawing.Point(73, 830);
            this.tbCO2.Margin = new System.Windows.Forms.Padding(4);
            this.tbCO2.Name = "tbCO2";
            this.tbCO2.ReadOnly = true;
            this.tbCO2.Size = new System.Drawing.Size(80, 27);
            this.tbCO2.TabIndex = 36;
            this.tbCO2.Text = "0";
            this.tbCO2.TextChanged += new System.EventHandler(this.tbCO2_TextChanged);
            // 
            // tbPrix
            // 
            this.tbPrix.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrix.Location = new System.Drawing.Point(73, 771);
            this.tbPrix.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.ReadOnly = true;
            this.tbPrix.Size = new System.Drawing.Size(80, 27);
            this.tbPrix.TabIndex = 34;
            this.tbPrix.Text = "0";
            this.tbPrix.TextChanged += new System.EventHandler(this.tbPrix_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 776);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 17);
            this.label12.TabIndex = 38;
            this.label12.Text = "Prix:";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(1390, 65);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(495, 507);
            this.rtbMessage.TabIndex = 39;
            this.rtbMessage.Text = "";
            this.rtbMessage.TextChanged += new System.EventHandler(this.rtbMessage_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(965, 706);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 17);
            this.label13.TabIndex = 43;
            this.label13.Text = "L2-entreprise:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(996, 637);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 17);
            this.label14.TabIndex = 41;
            this.label14.Text = "L1-ville:";
            // 
            // tbL1_ville
            // 
            this.tbL1_ville.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbL1_ville.Location = new System.Drawing.Point(1070, 632);
            this.tbL1_ville.Margin = new System.Windows.Forms.Padding(4);
            this.tbL1_ville.Name = "tbL1_ville";
            this.tbL1_ville.ReadOnly = true;
            this.tbL1_ville.Size = new System.Drawing.Size(80, 27);
            this.tbL1_ville.TabIndex = 44;
            this.tbL1_ville.Text = "0";
            this.tbL1_ville.TextChanged += new System.EventHandler(this.tbL1_ville_TextChanged);
            // 
            // tbL2_entreprise
            // 
            this.tbL2_entreprise.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbL2_entreprise.Location = new System.Drawing.Point(1070, 701);
            this.tbL2_entreprise.Margin = new System.Windows.Forms.Padding(4);
            this.tbL2_entreprise.Name = "tbL2_entreprise";
            this.tbL2_entreprise.ReadOnly = true;
            this.tbL2_entreprise.Size = new System.Drawing.Size(80, 27);
            this.tbL2_entreprise.TabIndex = 45;
            this.tbL2_entreprise.Text = "0";
            // 
            // View_graphe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2153, 1201);
            this.Controls.Add(this.tbL2_entreprise);
            this.Controls.Add(this.tbL1_ville);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbCO2);
            this.Controls.Add(this.tbPrix);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbEntreprise);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNucleaire);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbEolien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbJour_nuit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbVente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAchat);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox tbAchat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbVente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbJour_nuit;
        private System.Windows.Forms.TextBox tbNucleaire;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEolien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEntreprise;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCO2;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbL1_ville;
        private System.Windows.Forms.TextBox tbL2_entreprise;
    }
}

