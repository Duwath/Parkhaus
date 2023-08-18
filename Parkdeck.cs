using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkhaus360
{
    //Klasse Parkdeck enthält zwei Listobjekte in denen jeweils Auto und Motorrad
    //parkplätze gespeichert werden.
    internal class Parkdeck
    {
        private List<Parkplatz> autoparkplaetze;
        private List<Parkplatz> motorradparkplaetze;
        //Im Constructor werden die belegten Parkplätze über die for-Schleifen
        //direkt in die Listen abgelegt.
        public Parkdeck(int deck, int autoanz, int motanz)
        {
            autoparkplaetze = new List<Parkplatz>();
            motorradparkplaetze = new List<Parkplatz>();
            int position = 1;
            for (int i = 0; i < autoanz; ++i)
            {
                autoparkplaetze.Add(new AutoParkplatz(new Position(deck, position++)));
            }
            for (int i = 0; i < motanz; ++i)
            {
                motorradparkplaetze.Add(new MotorradParkplatz(new Position(deck, position++)));
            }
        }
        //Die folgenden Methoden bedienen sich der Klasse Parplatz zum erreichen des Ziels

        //Methode um einen freien Autoparkplatz zu finden. 
        //In der foreach Schleife wird durch alle Autoarkplätze
        //gegangen und beim ersten freien gestoppt.
        public AutoParkplatz FindeFreienParkplatz(Auto a)
        {
            foreach (Parkplatz p in autoparkplaetze)
            {
                if (p.IstFrei())
                return (AutoParkplatz)p;
            }
            return null;
        }
        //Hier passiert genau das umgekehrte. Es wird beim ersten belegten
        //Autoparkplatz gestoppt.
        public AutoParkplatz FindeErstenBelegtenAutoparkplatz()
        {
            foreach (Parkplatz p in autoparkplaetze)
            {
                if (!p.IstFrei())
                return (AutoParkplatz)p;
            }
            return null;
        }
        //Die exakt selben Methoden wie darüber nur für Motorräder
        public MotorradParkplatz FindeFreienParkplatz()
        {
            foreach (Parkplatz p in motorradparkplaetze)
            {
                if (p.IstFrei())
                return (MotorradParkplatz)p;
            }
            return null;
        }
        public MotorradParkplatz FindeErstenBelegtenMotorradparkplatz()
        {
            foreach (Parkplatz p in motorradparkplaetze)
            {
                if (!p.IstFrei())
                return (MotorradParkplatz)p;
            }
            return null;
        }
        //Hier suche ich ein spezifisches Fahrzeug anhand seines Kennzeichens.
        //Diese Methode wird von der Suchfunktion benötigt.
        public Parkplatz FindeFahrzeug(string kenn)
        {
            foreach (Parkplatz pp in autoparkplaetze)
            {
                Fahrzeug f = pp.GetFahrzeug();

                if (f != null && f.GetKennzeichen().Trim().Equals(kenn.Trim()))
                {
                    return pp;
                }
            }
            foreach (Parkplatz pp in motorradparkplaetze)
            {
                Fahrzeug f = pp.GetFahrzeug();
                if (f != null && f.GetKennzeichen().Equals(kenn))
                return pp;
            }
            return null;
        }
        //Methode gibt die anzahl aller freien Autoparkplätze aus
        public int GetFreieAutoparkplatzAnzahl()
        {
            int Autoparkplatz = 0;
            foreach (Parkplatz pp in autoparkplaetze)
            {
                if (pp.IstFrei())
                {
                    Autoparkplatz++;
                }
            }
            return Autoparkplatz;
        }
        //Methode gibt die anzahl aller freien Motorradparkplätze aus
        public int GetFreieMotorradparkplatzAnzahl()
        {
            int Motorradparkplatz = 0;
            foreach (Parkplatz pp in motorradparkplaetze)
            {
                if (pp.IstFrei())
                {
                    Motorradparkplatz++;
                }
            }
            return Motorradparkplatz;
        }
        //Methode gibt die Anzahl aller belegten Autoparkplätze aus
        public int GetBelegteAutoparkplatzAnzahl()
        {
            int leerAutoparkplatz = 0;
            foreach (Parkplatz pp in autoparkplaetze)
            {
                if (!pp.IstFrei())
                {
                    leerAutoparkplatz++;
                }
            }
            return leerAutoparkplatz;
        }
        //Methode gibt die Anzahl aller belegten Motorradparkplätze aus
        public int GetBelegteMotorradparkplatzAnzahl()
        {
            int leereMotorradparkplatz = 0;
            foreach (Parkplatz pp in motorradparkplaetze)
            {
                if (!pp.IstFrei())
                {
                    leereMotorradparkplatz++;
                }
            }
            return leereMotorradparkplatz;
        }
        //Hier wird geprüft ob ein bestimmter Autoparkplatz frei ist
        //Dies wird für die grafische Umsetzung genutzt
        public bool IstAutoparkplatzFrei(int index)
        {
            if (index >= 0 && index < autoparkplaetze.Count)
            {
                return autoparkplaetze[index].IstFrei();
            }
            return false; 
        }
        //Hier wird geprüft ob ein bestimmter Motorradparkplatz frei ist
        //Dies wird für die grafische Umsetzung genutzt
        public bool IstMotorradparkplatzFrei(int index)
        {
            if (index >= 0 && index < motorradparkplaetze.Count)
            {
                return motorradparkplaetze[index].IstFrei();
            }
            return false; 
        }
    }
}
