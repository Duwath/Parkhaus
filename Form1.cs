using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace Parkhaus360
{
    public partial class Form1 : Form
    {
        private Parkhaus haus;
        public Form1()
        {
            InitializeComponent();
        }
        private void Umblende()
        {
            if (panelReset.Visible == true)
            {
                labAutos.Text = " ";
                labEtagen.Text = " ";
                labzweirad.Text = " ";
                panelSimulation.Controls.Clear();
                panelReset.Visible = false;
                panelErstellung.Visible = true;
                rtbAusgabe.Clear();
            }
            else
            {
                panelErstellung.Visible = false;
                panelReset.Visible = true;
            }

        }
        private void SimulationStart()
        {
            int y = 0;
            for (int x = 0; x < (int)nudPAuto.Value; x++)
            {
                if (x % 10 == 0)
                {
                    y += 20;
                }
                Label labeltemp = new Label();
                labeltemp.Name = x.ToString();
                labeltemp.Text = "O";
                labeltemp.ForeColor = Color.Green;
                labeltemp.Location = new Point(x % 10 * 15, y);
                labeltemp.Width = 12;
                labeltemp.Height = 12;
                panelSimulation.Controls.Add(labeltemp);
            }
            y += 20;
            for (int x = 0; x < (int)nudPZweirad.Value; x++)
            {
                if (x % 10 == 0)
                {
                    y += 20;
                }
                Label labeltemp = new Label();
                labeltemp.Name = x.ToString();
                labeltemp.Text = "Y";
                labeltemp.ForeColor = Color.Green;
                labeltemp.Location = new Point(x % 10 * 15, y);
                labeltemp.Width = 12;
                labeltemp.Height = 12;
                panelSimulation.Controls.Add(labeltemp);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Umblende();
            SimulationStart();
            int etage = (int)nudEtagen.Value;
            int autoParkPlaetze = (int)nudPAuto.Value;
            int zweiradParkPlaetze = (int)nudPZweirad.Value;
            haus = new Parkhaus(etage, autoParkPlaetze, zweiradParkPlaetze);
            Liveupdate();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Umblende();
        }
        private void Liveupdate()
        {
            labEtagen.Text = haus.GetDeckAnzahl().ToString();
            labAutos.Text = haus.GetFreieAutoParkplatzAnzahl().ToString();
            labzweirad.Text = haus.GetFreieMotorradParkplatzAnzahl().ToString();
        }

        private void btnAutorein_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nudAutorein.Value; i++)
            {
                if (haus.GetFreieAutoParkplatzAnzahl() <= 0)
                {
                    MessageBox.Show("Es sind keine Autoparkplätze mehr frei");
                }
                else
                {
                    Auto auto = new Auto(ErstelleNummernschild());

                    Parkplatz p = haus.FindeFreienParkplatz(auto);
                    p.belegePlatz(auto);
                    rtbAusgabe.AppendText(auto.GetKennzeichen() +" Typ: Auto Ebene: "+ Environment.NewLine);
                    rtbAusgabe.SelectionStart = rtbAusgabe.Text.Length;
                    rtbAusgabe.ScrollToCaret();
                    
                }
            }
            Liveupdate();
        }
        private void btnMotoRein_Click(object sender, EventArgs e)
        {
            if (haus.GetFreieMotorradParkplatzAnzahl() <= 0)
            {
                MessageBox.Show("Es sind keine Motorradparkplätze mehr frei");
            }
            else
            {
                for (int i = 0; i < nudMotorradrein.Value; i++)
                {
                    Motorrad moto = new Motorrad(ErstelleNummernschild());

                    Parkplatz p = haus.FindeFreienParkplatz(moto);
                    p.belegePlatz(moto);
                    rtbAusgabe.AppendText(moto.GetKennzeichen() + Environment.NewLine);
                    rtbAusgabe.SelectionStart = rtbAusgabe.Text.Length;
                    rtbAusgabe.ScrollToCaret();
                    
                }
            }
            Liveupdate();
        }
        public string ErstelleNummernschild()
        {
            StringBuilder nummernschild = new StringBuilder();

            // Erste Gruppe (2-3 Zeichen)
            nummernschild.Append(RandomLetters(1, 3));
            nummernschild.Append("-");

            // Zweite Gruppe (2 Zeichen)
            nummernschild.Append(RandomLetters(1, 2));
            nummernschild.Append(" ");

            // Dritte Gruppe (1-3 Zahlen)
            nummernschild.Append(RandomNumbers(1, 4));

            return nummernschild.ToString();
        }

        public string RandomLetters(int minLength, int maxLength)
        {
            Random random = new Random();
            int length = random.Next(minLength, maxLength + 1);
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder kennzeichen = new StringBuilder();
            for (int i = 1; i <= length; i++)
            {
                kennzeichen.Append(letters[random.Next(0, 26)]);
            }
            return kennzeichen.ToString();
        }


        public string RandomNumbers(int minLength, int maxLength)
        {
            Random random = new Random();
            int length = random.Next(minLength, maxLength + 1);
            const string numbers = "0123456789";
            StringBuilder kennzeichennr = new StringBuilder();
            for (int i = 1; i <= length; i++)
            {
                kennzeichennr.Append(numbers[random.Next(0, 10)]);
            }
            return kennzeichennr.ToString();
        }


    }
}
