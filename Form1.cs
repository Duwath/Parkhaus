using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parkhaus360
{
    public partial class Form1 : Form
    {
        //Fields
        private Parkhaus haus;
        //In Form1 werden die GUI Componenten der Windowsform initialisiert
        public Form1()
        {
            InitializeComponent();
        }
        //Hier wird das Dropdownmenü konfiguriert und mit der Anzahl der Etagen bestückt
        //Ausserdem wird der Selected Index (ausgewähltes Feld) auf die erste Position gesetzt
        private void Simulationsconstruction()
        {
            for (int i = 0; i < haus.GetDeckAnzahl(); i++)
            {
                cbSimulation.Show();
                cbSimulation.Items.Add("Ebene " + (i + 1));
            }
            cbSimulation.SelectedIndex = 0;
        }
        //Diese Methode wird immer aufgerufen wenn:
        //1. Ein Parkhaus konstruiert wird
        //2. Ein Fahrzeug rein oder rausfährt

        private void SimulationStart()
        {
            //Ein Clear um bei jedem aufrufen der Methode die alten Zeichen zu löschen
            panelSimulation.Controls.Clear();
            //Hier wird ausgewählt welche Etage ausgewählt ist
            int etage = cbSimulation.SelectedIndex;
            int y = 0;
            //In den folgenden forschleifen werden anhand eines Koordinatensystems
            //X und Y labelobjekte mit den Symbolen für Autos und Motorrädern
            //bestückt und in der ensprechenden Farbe (rot=besetzt, grün=frei)
            //eingefärbt.
            for (int x = 0; x < (int)nudPAuto.Value; x++)
            {
                if (x % 10 == 0)
                {
                    y += 20;
                }
                Label labeltemp = new Label();
                labeltemp.Name = x.ToString();
                labeltemp.Text = "O";
                if (haus.IstAutoParkplatzFrei(etage, x) == true)
                {
                    labeltemp.ForeColor = Color.Green;
                }
                else
                {
                    labeltemp.ForeColor = Color.Red;
                }
                labeltemp.Location = new Point(x % 10 * 15, y);
                labeltemp.Width = 12;
                labeltemp.Height = 12;
                panelSimulation.Controls.Add(labeltemp);
            }

            y += 20;
            for (int x = 0; x < nudPZweirad.Value; x++)
            {
                if (x % 10 == 0)
                {
                    y += 20;
                }
                Label labeltemp = new Label();
                labeltemp.Name = x.ToString();
                labeltemp.Text = "Y";
                if (haus.IstMotorradParkplatzFrei(etage, x) == true)
                {
                    labeltemp.ForeColor = Color.Green;
                }
                else
                {
                    labeltemp.ForeColor = Color.Red;
                }
                labeltemp.Location = new Point(x % 10 * 15, y);
                labeltemp.Width = 12;
                labeltemp.Height = 12;
                panelSimulation.Controls.Add(labeltemp);
            }
        }
        //In dieser Methode wird ausgelesen wieviele Etagen und wieviele
        //Parkplätze für die Fahrzeuge vorhanden sind.
        //Danach wird das panel versteckt und der Resetbutton wird sichtbar gemacht
        private void button1_Click(object sender, EventArgs e)
        {
            int etage = (int)nudEtagen.Value;
            int autoParkPlaetze = (int)nudPAuto.Value;
            int zweiradParkPlaetze = (int)nudPZweirad.Value;
            haus = new Parkhaus(etage, autoParkPlaetze, zweiradParkPlaetze);
            panelErstellung.Visible = false;
            panelReset.Visible = true;
            Liveupdate();
            Simulationsconstruction();
            SimulationStart();
        }
        //Alle label welche im laufenden Program gefüllt werden,
        //werden geleert. Ausserdem die Ritchtextbox welche als 
        //Liveticker dient und das Panel mit der grafischen
        //Übersicht über die Parkplätze
        //Dann wird der Resetknopf wieder versteckt und das 
        //Erstellungspanel sichtbar gemacht
        private void btnReset_Click(object sender, EventArgs e)
        {
            labAutos.Text = " ";
            labEtagen.Text = " ";
            labzweirad.Text = " ";
            panelReset.Visible = false;
            panelErstellung.Visible = true;
            rtbAusgabe.Clear();
            cbSimulation.Items.Clear();
            cbSimulation.Hide();
            panelSimulation.Controls.Clear();
        }
        //Hier werden die label an der linken Seite mit den aktuellen
        //Informationen bestückt
        private void Liveupdate()
        {
            labEtagen.Text = haus.GetDeckAnzahl().ToString();
            labAutos.Text = haus.GetFreieAutoParkplatzAnzahl().ToString();
            labzweirad.Text = haus.GetFreieMotorradParkplatzAnzahl().ToString();
        }
        //Methode zum parken von X Autos
        //Falls das Parkhaus voll ist erscheint eine Messagebox
        //Falls kein Parkhaus exisiert wird darauf hingewiesen
        private void btnAutorein_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nudAutorein.Value; i++)
            {
                if (haus == null)
                {
                    MessageBox.Show("Bitte erstellen Sie zuerst ein Parkhaus");
                    break;
                }
                else
                {
                    if (haus.GetFreieAutoParkplatzAnzahl() <= 0)
                    {
                        MessageBox.Show("Es sind keine Autoparkplätze mehr frei");
                        break;
                    }
                    else
                    {
                        Auto auto = new Auto(ErstelleNummernschild());
                        Parkplatz p = haus.FindeFreienParkplatz(auto);
                        p.belegePlatz(auto);
                        rtbAusgabe.AppendText(auto.GetKennzeichen() + " Typ: Auto Ebene: " + p.GetPosition().etage.ToString() + " Platz: " + p.GetPosition().platz.ToString() + Environment.NewLine);
                        rtbAusgabe.SelectionStart = rtbAusgabe.Text.Length;
                        rtbAusgabe.ScrollToCaret();
                    }
                    Liveupdate();
                }
            }
            SimulationStart();
        }
        //Methode zum parken von X Motorrädern
        //Falls das Parkhaus voll ist erscheint eine Messagebox
        //Falls kein Parkhaus exisiert wird darauf hingewiesen
        private void btnMotoRein_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nudMotorradrein.Value; i++)
            {
                if (haus == null)
                {
                    MessageBox.Show("Bitte erstellen Sie zuerst ein Parkhaus");
                    break;
                }
                else
                {
                    if (haus.GetFreieMotorradParkplatzAnzahl() <= 0)
                    {
                        MessageBox.Show("Es sind keine Motorradparkplätze mehr frei");
                        break;
                    }
                    else
                    {
                        Motorrad moto = new Motorrad(ErstelleNummernschild());
                        Parkplatz p = haus.FindeFreienParkplatz(moto);
                        p.belegePlatz(moto);
                        rtbAusgabe.AppendText(moto.GetKennzeichen() + " Typ: Zweirad Ebene: " + p.GetPosition().etage.ToString() + " Platz: " + p.GetPosition().platz.ToString() + Environment.NewLine);
                        rtbAusgabe.SelectionStart = rtbAusgabe.Text.Length;
                        rtbAusgabe.ScrollToCaret();
                    }
                    Liveupdate();
                }
            }
            SimulationStart();
        }
        //Hier wird ein Random-Nummernschild zusammengesetzt
        public string ErstelleNummernschild()
        {
            StringBuilder nummernschild = new StringBuilder();
            // Erste Gruppe (2-3 Zeichen)
            nummernschild.Append(RandomBuchstaben(1, 3));
            nummernschild.Append("-");
            // Zweite Gruppe (2 Zeichen)
            nummernschild.Append(RandomBuchstaben(1, 2));
            nummernschild.Append(" ");
            // Dritte Gruppe (1-3 Zahlen)
            nummernschild.Append(RandomZahlen(1, 4));
            return nummernschild.ToString();
        }
        //Hier werden Random Buchstaben erstellt
        public string RandomBuchstaben(int minLength, int maxLength)
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
        //Hier werden Random Zahlen erstellt
        public string RandomZahlen(int minLength, int maxLength)
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
        //In dieser Methode wird das erste gefundene Autoobjekt 
        //Abgerufen und der Verweis auf das Objekt in seinem Parkplatz
        //gelöscht
        private void btnAutoRaus_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nudAutoraus.Value; i++)
            {
                if (haus.GetBelegteAutoParkplatzAnzahl() <= 0)
                {
                    MessageBox.Show("Es sind keine weiteren Autos mehr geparkt.");
                    break;
                }
                else
                {
                    Parkplatz pp = haus.FindeErstenBelegtenAutoparkplatz();
                    if (pp != null)
                    {
                        rtbAusgabe.AppendText(pp.GetFahrzeug().GetKennzeichen().ToString() + " fährt raus." + Environment.NewLine);
                        rtbAusgabe.SelectionStart = rtbAusgabe.Text.Length;
                        rtbAusgabe.ScrollToCaret();
                        pp.GibPlatzFrei();
                    }
                }
            }
            Liveupdate();
            SimulationStart();
        }
        //In dieser Methode wird das erste gefundene Motorradobjekt 
        //Abgerufen und der Verweis auf das Objekt in seinem Parkplatz
        //gelöscht
        private void btnMotoRaus_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < nudMotorradraus.Value; i++)
            {
                if (haus.GetbelegteMotorradParkplatzAnzahl() <= 0)
                {
                    MessageBox.Show("Es sind keine weiteren Motorräder mehr geparkt.");
                    break;
                }
                else
                {
                    Parkplatz pp = haus.FindeErstenBelegtenMotorradparkplatz();
                    if (pp != null)
                    {
                        rtbAusgabe.AppendText(pp.GetFahrzeug().GetKennzeichen().ToString() + " fährt raus." + Environment.NewLine);
                        rtbAusgabe.SelectionStart = rtbAusgabe.Text.Length;
                        rtbAusgabe.ScrollToCaret();
                        pp.GibPlatzFrei();
                    }
                }
            }
            Liveupdate();
            SimulationStart();
        }
        //Methode zur Suche
        private void button6_Click(object sender, EventArgs e)
        {
            if (haus.FindeFahrzeug(tbSuche.Text.ToString()) == null)
            {
                MessageBox.Show("Das Auto mit diesem Kennzeichen ist nicht geparkt.");
            }
            else
            {
                Parkplatz pp = haus.FindeFahrzeug(tbSuche.Text.ToString());
                lblParkdeck.Text = pp.GetPosition().etage.ToString();
                lblParkplatz.Text = pp.GetPosition().platz.ToString();
            }
        }
        //Methode um die bildliche Umsetzung beim ändern des Indexes
        //im Dropdownmenü neu zu laden
        private void cbSimulation_SelectedIndexChanged(object sender, EventArgs e)
        {
            SimulationStart();
        }
    }
}
