﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkhaus360
{
    internal class Parkhaus
    {
        private List<Parkdeck> decks;
        public Parkhaus(int deckanz, int autoanz, int motanz)
        {
            decks = new List<Parkdeck>();
            for (int i = 1; i <= deckanz; i++)
            {
                decks.Add(new Parkdeck(i, autoanz, motanz));
            }

        }

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
        public int GetDeckAnzahl()
        {
            return decks.Count;
        }
        public int GetFreieAutoParkplatzAnzahl()
        {
            int autoanzahl = 0;
            foreach (Parkdeck pd in decks)
            {
                autoanzahl += pd.GetFreieAutoparkplatzAnzahl();
               
            }
            return autoanzahl;
        }
        public int GetFreieMotorradParkplatzAnzahl()
        {
            int motorradanzahl = 0;
            foreach (Parkdeck pd in decks)
            {
                motorradanzahl += pd.GetFreieMotorradparkplatzAnzahl();
            }
            return motorradanzahl;
        }
        public int GetBelegteAutoParkplatzAnzahl()
        {
            int leereautoanzahl = 0;
            foreach (Parkdeck pd in decks)
            {
                leereautoanzahl += pd.GetBelegteAutoparkplatzAnzahl();

            }
            return leereautoanzahl;
        }
        public int GetbelegteMotorradParkplatzAnzahl()
        {
            int leeremotorradanzahl = 0;
            foreach (Parkdeck pd in decks)
            {
               leeremotorradanzahl += pd.GetFreieMotorradparkplatzAnzahl();
            }
            return leeremotorradanzahl;
        }
        public bool IstAutoParkplatzFrei(int deckIndex, int parkplatzIndex)
        {
            if (deckIndex >= 0 && deckIndex < decks.Count)
            {
                return decks[deckIndex].IstAutoparkplatzFrei(parkplatzIndex);
            }
            return false; // Deck-Index ungültig oder Deck existiert nicht
        }

        public bool IstMotorradParkplatzFrei(int deckIndex, int parkplatzIndex)
        {
            if (deckIndex >= 0 && deckIndex < decks.Count)
            {
                return decks[deckIndex].IstMotorradparkplatzFrei(parkplatzIndex);
            }
            return false; // Deck-Index ungültig oder Deck existiert nicht
        }
        public bool DieserPlatzBelegt(int deckIndex, int parkplatzIndex)
        {

            return false;
        }


    }
}
