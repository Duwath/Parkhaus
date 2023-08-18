using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkhaus360
{
    internal class Parkhaus
    {
        private List<Parkdeck> decks;
        //Klasse Parkhaus enthält ein Listobjekt in dem die
        //Parkdecks gespeichert werden.
        //Ausserdem werden bei der erstellung des Parkhausobjektes
        //die Anzahl der Motorrad und Autoparkplätze angegeben 
        //sowie direkt die Parkdecks dazu angelegt
        public Parkhaus(int deckanz, int autoanz, int motanz)
        {
            decks = new List<Parkdeck>();
            for (int i = 1; i <= deckanz; i++)
            {
                decks.Add(new Parkdeck(i, autoanz, motanz));
            }
        }
        //Methode zum Übergeben der Anzahl der Parkdecks
        public int GetDeckAnzahl()
        {
            return decks.Count;
        }
        //Die folgenden Methoden bedienen sich der Klasse Parkdeck zum erreichen des Ziels

        //Methode zum finden eines freien Parkplatzes für ein Auto.        
        public AutoParkplatz FindeFreienParkplatz(Auto a)
        {
            foreach (Parkdeck pd in decks)
            {
                AutoParkplatz pp = pd.FindeFreienParkplatz(a);
                if (pp != null)
                return pp;
            }
            return null;
        }
        //Methode zum finden des ersten belegten Autoparkplatzes
        public AutoParkplatz FindeErstenBelegtenAutoparkplatz()
        {
            foreach (Parkdeck pd in decks)
            {
                AutoParkplatz pp = pd.FindeErstenBelegtenAutoparkplatz();
                if (pp != null)
                return pp;
            }
            return null;
        }
        //Methode zum finden eines freien Parkplatzes für ein Motorrad.
        public MotorradParkplatz FindeFreienParkplatz(Motorrad a)
        {
            foreach (Parkdeck pd in decks)
            {
                MotorradParkplatz pp = pd.FindeFreienParkplatz();
                if (pp != null)
                return pp;
            }
            return null;
        }
        //Methode zum finden des ersten belegten Motorradparkplatzes
        public MotorradParkplatz FindeErstenBelegtenMotorradparkplatz()
        {
            foreach (Parkdeck pd in decks)
            {
                MotorradParkplatz pp = pd.FindeErstenBelegtenMotorradparkplatz();
                if (pp != null)
                return pp;
            }
            return null;
        }
        //Methode zum finden eines spezifischen Fahrzeugs mit Hilfe seines Kennzeichens
        public Parkplatz FindeFahrzeug(string kenn)
        {
            foreach (Parkdeck pd in decks)
            {
                Parkplatz pp = pd.FindeFahrzeug(kenn);
                if (pp != null)
                return pp;
            }
            return null;
        }
        //Methode um herauszufinden wieviele Autoparkplätze noch frei sind
        public int GetFreieAutoParkplatzAnzahl()
        {
            int autoanzahl = 0;
            foreach (Parkdeck pd in decks)
            {
                autoanzahl += pd.GetFreieAutoparkplatzAnzahl();               
            }
            return autoanzahl;
        }
        //Methode um herauszufinden wieviele Motorradparkplätze noch frei sind
        public int GetFreieMotorradParkplatzAnzahl()
        {
            int motorradanzahl = 0;
            foreach (Parkdeck pd in decks)
            {
                motorradanzahl += pd.GetFreieMotorradparkplatzAnzahl();
            }
            return motorradanzahl;
        }
        //Methode um herauszufinden wieviele Autoparkplätze schon belegt sind
        public int GetBelegteAutoParkplatzAnzahl()
        {
            int leereautoanzahl = 0;
            foreach (Parkdeck pd in decks)
            {
                leereautoanzahl += pd.GetBelegteAutoparkplatzAnzahl();
            }
            return leereautoanzahl;
        }
        //Methode um herauszufinden wieviele Motorradparkplätze schon belegt sind
        public int GetbelegteMotorradParkplatzAnzahl()
        {
            int leeremotorradanzahl = 0;
            foreach (Parkdeck pd in decks)
            {
               leeremotorradanzahl += pd.GetBelegteMotorradparkplatzAnzahl();
            }
            return leeremotorradanzahl;
        }
        //Methode um herauszufinden ob ein spezifischer Autoparkplatz frei ist
        public bool IstAutoParkplatzFrei(int deckIndex, int parkplatzIndex)
        {
            if (deckIndex >= 0 && deckIndex < decks.Count)
            {
                return decks[deckIndex].IstAutoparkplatzFrei(parkplatzIndex);
            }
            return false; 
        }
        //Methode um herauszufinden ob ein spezifischer Motorradparkplatz frei ist
        public bool IstMotorradParkplatzFrei(int deckIndex, int parkplatzIndex)
        {
            if (deckIndex >= 0 && deckIndex < decks.Count)
            {
                return decks[deckIndex].IstMotorradparkplatzFrei(parkplatzIndex);
            }
            return false; 
        }      
    }
}
