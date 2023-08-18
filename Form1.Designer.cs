namespace Parkhaus360
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelReset = new Panel();
            btnReset = new Button();
            panelErstellung = new Panel();
            label3 = new Label();
            nudPZweirad = new NumericUpDown();
            label1 = new Label();
            nudPAuto = new NumericUpDown();
            label2 = new Label();
            nudEtagen = new NumericUpDown();
            button1 = new Button();
            panel6 = new Panel();
            lblParkplatz = new Label();
            label18 = new Label();
            lblParkdeck = new Label();
            label16 = new Label();
            btnKennzeichensuche = new Button();
            label13 = new Label();
            label12 = new Label();
            tbSuche = new TextBox();
            rtbAusgabe = new RichTextBox();
            panel3 = new Panel();
            label7 = new Label();
            label8 = new Label();
            btnMotoRaus = new Button();
            btnAutoRaus = new Button();
            nudMotorradraus = new NumericUpDown();
            nudAutoraus = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            btnMotoRein = new Button();
            btnAutorein = new Button();
            nudMotorradrein = new NumericUpDown();
            nudAutorein = new NumericUpDown();
            panel2 = new Panel();
            labzweirad = new Label();
            labAutos = new Label();
            labEtagen = new Label();
            label11 = new Label();
            lblZweirad = new Label();
            label15 = new Label();
            label14 = new Label();
            label10 = new Label();
            label9 = new Label();
            label6 = new Label();
            cbSimulation = new ComboBox();
            panelSimulation = new Panel();
            panelReset.SuspendLayout();
            panelErstellung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPZweirad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPAuto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEtagen).BeginInit();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMotorradraus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAutoraus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMotorradrein).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAutorein).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelReset
            // 
            panelReset.Controls.Add(btnReset);
            panelReset.Location = new Point(178, 2);
            panelReset.Name = "panelReset";
            panelReset.Size = new Size(99, 39);
            panelReset.TabIndex = 20;
            panelReset.Visible = false;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(3, 13);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 0;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // panelErstellung
            // 
            panelErstellung.Controls.Add(label3);
            panelErstellung.Controls.Add(nudPZweirad);
            panelErstellung.Controls.Add(label1);
            panelErstellung.Controls.Add(nudPAuto);
            panelErstellung.Controls.Add(label2);
            panelErstellung.Controls.Add(nudEtagen);
            panelErstellung.Controls.Add(button1);
            panelErstellung.Location = new Point(6, 15);
            panelErstellung.Name = "panelErstellung";
            panelErstellung.Size = new Size(166, 194);
            panelErstellung.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 130);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 5;
            label3.Text = "Zweiradparkplätze";
            // 
            // nudPZweirad
            // 
            nudPZweirad.Location = new Point(3, 128);
            nudPZweirad.Name = "nudPZweirad";
            nudPZweirad.Size = new Size(42, 23);
            nudPZweirad.TabIndex = 12;
            nudPZweirad.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 5);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Etagen";
            // 
            // nudPAuto
            // 
            nudPAuto.Location = new Point(3, 64);
            nudPAuto.Name = "nudPAuto";
            nudPAuto.Size = new Size(42, 23);
            nudPAuto.TabIndex = 11;
            nudPAuto.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 66);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 4;
            label2.Text = "Autoparkplätze";
            // 
            // nudEtagen
            // 
            nudEtagen.Location = new Point(3, 3);
            nudEtagen.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudEtagen.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudEtagen.Name = "nudEtagen";
            nudEtagen.Size = new Size(42, 23);
            nudEtagen.TabIndex = 10;
            nudEtagen.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(3, 166);
            button1.Name = "button1";
            button1.Size = new Size(142, 23);
            button1.TabIndex = 9;
            button1.Text = "Erstelle Parkhaus";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(lblParkplatz);
            panel6.Controls.Add(label18);
            panel6.Controls.Add(lblParkdeck);
            panel6.Controls.Add(label16);
            panel6.Controls.Add(btnKennzeichensuche);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(tbSuche);
            panel6.Location = new Point(480, 15);
            panel6.Name = "panel6";
            panel6.Size = new Size(234, 126);
            panel6.TabIndex = 25;
            // 
            // lblParkplatz
            // 
            lblParkplatz.AutoSize = true;
            lblParkplatz.Location = new Point(187, 103);
            lblParkplatz.Name = "lblParkplatz";
            lblParkplatz.Size = new Size(10, 15);
            lblParkplatz.TabIndex = 7;
            lblParkplatz.Text = " ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(109, 103);
            label18.Name = "label18";
            label18.Size = new Size(58, 15);
            label18.TabIndex = 6;
            label18.Text = "Parkplatz:";
            // 
            // lblParkdeck
            // 
            lblParkdeck.AutoSize = true;
            lblParkdeck.Location = new Point(187, 84);
            lblParkdeck.Name = "lblParkdeck";
            lblParkdeck.Size = new Size(10, 15);
            lblParkdeck.TabIndex = 5;
            lblParkdeck.Text = " ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(9, 84);
            label16.Name = "label16";
            label16.Size = new Size(158, 15);
            label16.TabIndex = 4;
            label16.Text = "Fahrzeug steht auf Parkdeck:";
            // 
            // btnKennzeichensuche
            // 
            btnKennzeichensuche.Location = new Point(33, 58);
            btnKennzeichensuche.Name = "btnKennzeichensuche";
            btnKennzeichensuche.Size = new Size(164, 23);
            btnKennzeichensuche.TabIndex = 3;
            btnKennzeichensuche.Text = "Suche nach Kennzeichen";
            btnKennzeichensuche.UseVisualStyleBackColor = true;
            btnKennzeichensuche.Click += button6_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(9, 32);
            label13.Name = "label13";
            label13.Size = new Size(77, 15);
            label13.TabIndex = 2;
            label13.Text = "Kennzeichen:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(82, 5);
            label12.Name = "label12";
            label12.Size = new Size(83, 21);
            label12.TabIndex = 1;
            label12.Text = "Autosuche";
            // 
            // tbSuche
            // 
            tbSuche.Location = new Point(112, 29);
            tbSuche.Name = "tbSuche";
            tbSuche.Size = new Size(100, 23);
            tbSuche.TabIndex = 0;
            // 
            // rtbAusgabe
            // 
            rtbAusgabe.Location = new Point(480, 147);
            rtbAusgabe.Name = "rtbAusgabe";
            rtbAusgabe.Size = new Size(234, 196);
            rtbAusgabe.TabIndex = 0;
            rtbAusgabe.Text = "";
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(btnMotoRaus);
            panel3.Controls.Add(btnAutoRaus);
            panel3.Controls.Add(nudMotorradraus);
            panel3.Controls.Add(nudAutoraus);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(btnMotoRein);
            panel3.Controls.Add(btnAutorein);
            panel3.Controls.Add(nudMotorradrein);
            panel3.Controls.Add(nudAutorein);
            panel3.Location = new Point(480, 349);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 112);
            panel3.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 88);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 24;
            label7.Text = "Zweiräder";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 61);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 23;
            label8.Text = "Autos";
            // 
            // btnMotoRaus
            // 
            btnMotoRaus.Location = new Point(113, 86);
            btnMotoRaus.Name = "btnMotoRaus";
            btnMotoRaus.Size = new Size(109, 23);
            btnMotoRaus.TabIndex = 22;
            btnMotoRaus.Text = "rausfahren lassen";
            btnMotoRaus.UseVisualStyleBackColor = true;
            btnMotoRaus.Click += btnMotoRaus_Click_1;
            // 
            // btnAutoRaus
            // 
            btnAutoRaus.Location = new Point(113, 61);
            btnAutoRaus.Name = "btnAutoRaus";
            btnAutoRaus.Size = new Size(109, 23);
            btnAutoRaus.TabIndex = 21;
            btnAutoRaus.Text = "rausfahren lassen";
            btnAutoRaus.UseVisualStyleBackColor = true;
            btnAutoRaus.Click += btnAutoRaus_Click;
            // 
            // nudMotorradraus
            // 
            nudMotorradraus.Location = new Point(3, 86);
            nudMotorradraus.Name = "nudMotorradraus";
            nudMotorradraus.Size = new Size(42, 23);
            nudMotorradraus.TabIndex = 20;
            nudMotorradraus.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudAutoraus
            // 
            nudAutoraus.Location = new Point(3, 59);
            nudAutoraus.Name = "nudAutoraus";
            nudAutoraus.Size = new Size(42, 23);
            nudAutoraus.TabIndex = 19;
            nudAutoraus.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 32);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 18;
            label5.Text = "Zweiräder";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 5);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 17;
            label4.Text = "Autos";
            // 
            // btnMotoRein
            // 
            btnMotoRein.Location = new Point(113, 30);
            btnMotoRein.Name = "btnMotoRein";
            btnMotoRein.Size = new Size(109, 23);
            btnMotoRein.TabIndex = 16;
            btnMotoRein.Text = "einfahren lassen";
            btnMotoRein.UseVisualStyleBackColor = true;
            btnMotoRein.Click += btnMotoRein_Click;
            // 
            // btnAutorein
            // 
            btnAutorein.Location = new Point(113, 5);
            btnAutorein.Name = "btnAutorein";
            btnAutorein.Size = new Size(109, 23);
            btnAutorein.TabIndex = 15;
            btnAutorein.Text = "einfahren lassen";
            btnAutorein.UseVisualStyleBackColor = true;
            btnAutorein.Click += btnAutorein_Click;
            // 
            // nudMotorradrein
            // 
            nudMotorradrein.Location = new Point(3, 30);
            nudMotorradrein.Name = "nudMotorradrein";
            nudMotorradrein.Size = new Size(42, 23);
            nudMotorradrein.TabIndex = 14;
            nudMotorradrein.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudAutorein
            // 
            nudAutorein.Location = new Point(3, 3);
            nudAutorein.Name = "nudAutorein";
            nudAutorein.Size = new Size(42, 23);
            nudAutorein.TabIndex = 13;
            nudAutorein.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel2
            // 
            panel2.Controls.Add(labzweirad);
            panel2.Controls.Add(labAutos);
            panel2.Controls.Add(labEtagen);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(lblZweirad);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(6, 215);
            panel2.Name = "panel2";
            panel2.Size = new Size(166, 252);
            panel2.TabIndex = 21;
            // 
            // labzweirad
            // 
            labzweirad.AutoSize = true;
            labzweirad.Location = new Point(8, 174);
            labzweirad.Name = "labzweirad";
            labzweirad.Size = new Size(10, 15);
            labzweirad.TabIndex = 11;
            labzweirad.Text = " ";
            // 
            // labAutos
            // 
            labAutos.AutoSize = true;
            labAutos.Location = new Point(8, 119);
            labAutos.Name = "labAutos";
            labAutos.Size = new Size(10, 15);
            labAutos.TabIndex = 10;
            labAutos.Text = " ";
            // 
            // labEtagen
            // 
            labEtagen.AutoSize = true;
            labEtagen.Location = new Point(8, 63);
            labEtagen.Name = "labEtagen";
            labEtagen.Size = new Size(10, 15);
            labEtagen.TabIndex = 9;
            labEtagen.Text = " ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(55, 174);
            label11.Name = "label11";
            label11.Size = new Size(108, 15);
            label11.TabIndex = 3;
            label11.Text = "Freie Zweiradplätze";
            // 
            // lblZweirad
            // 
            lblZweirad.AutoSize = true;
            lblZweirad.Location = new Point(8, 174);
            lblZweirad.Name = "lblZweirad";
            lblZweirad.Size = new Size(0, 15);
            lblZweirad.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(8, 119);
            label15.Name = "label15";
            label15.Size = new Size(0, 15);
            label15.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 62);
            label14.Name = "label14";
            label14.Size = new Size(0, 15);
            label14.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(55, 119);
            label10.Name = "label10";
            label10.Size = new Size(92, 15);
            label10.TabIndex = 2;
            label10.Text = "Freie Autoplätze";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(55, 62);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 1;
            label9.Text = "Etagen";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(8, 11);
            label6.Name = "label6";
            label6.Size = new Size(137, 21);
            label6.TabIndex = 0;
            label6.Text = "Parkhausübersicht";
            // 
            // cbSimulation
            // 
            cbSimulation.FormattingEnabled = true;
            cbSimulation.Location = new Point(353, 15);
            cbSimulation.Name = "cbSimulation";
            cbSimulation.Size = new Size(121, 23);
            cbSimulation.TabIndex = 26;
            cbSimulation.Visible = false;
            cbSimulation.SelectedIndexChanged += cbSimulation_SelectedIndexChanged;
            // 
            // panelSimulation
            // 
            panelSimulation.Location = new Point(178, 41);
            panelSimulation.Name = "panelSimulation";
            panelSimulation.Size = new Size(296, 427);
            panelSimulation.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 471);
            Controls.Add(rtbAusgabe);
            Controls.Add(panelSimulation);
            Controls.Add(cbSimulation);
            Controls.Add(panelReset);
            Controls.Add(panelErstellung);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            panelReset.ResumeLayout(false);
            panelErstellung.ResumeLayout(false);
            panelErstellung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPZweirad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPAuto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEtagen).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMotorradraus).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAutoraus).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMotorradrein).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAutorein).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelReset;
        private Button btnReset;
        private Panel panelErstellung;
        private Label label3;
        private NumericUpDown nudPZweirad;
        private Label label1;
        private NumericUpDown nudPAuto;
        private Label label2;
        private NumericUpDown nudEtagen;
        private Button button1;
        private Panel panel6;
        private Label lblParkplatz;
        private Label label18;
        private Label lblParkdeck;
        private Label label16;
        private Button btnKennzeichensuche;
        private Label label13;
        private Label label12;
        private TextBox tbSuche;
        private RichTextBox rtbAusgabe;
        private Panel panel3;
        private Label label7;
        private Label label8;
        private Button btnMotoRaus;
        private Button btnAutoRaus;
        private NumericUpDown nudMotorradraus;
        private NumericUpDown nudAutoraus;
        private Label label5;
        private Label label4;
        private Button btnMotoRein;
        private Button btnAutorein;
        private NumericUpDown nudMotorradrein;
        private NumericUpDown nudAutorein;
        private Panel panel2;
        private Label labzweirad;
        private Label labAutos;
        private Label labEtagen;
        private Label label11;
        private Label lblZweirad;
        private Label label15;
        private Label label14;
        private Label label10;
        private Label label9;
        private Label label6;
        private ComboBox cbSimulation;
        private Panel panelSimulation;
    }
}