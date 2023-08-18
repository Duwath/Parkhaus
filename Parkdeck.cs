using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkhaus360
{
    internal class Parkdeck
    {
        private List<Parkplatz> autoparkplaetze;
        private List<Parkplatz> motorradparkplaetze;

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

        public AutoParkplatz FindeFreienParkplatz(Auto a)
        {
            foreach (Parkplatz p in autoparkplaetze)
            {
                if (p.IstFrei())
                    return (AutoParkplatz)p;
            }
            return null;
        }
        public AutoParkplatz FindeErstenBelegtenAutoparkplatz()
        {
            foreach (Parkplatz p in autoparkplaetze)
            {
                if (!p.IstFrei())
                    return (AutoParkplatz)p;
            }
            return null;
        }
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
        public bool IstAutoparkplatzFrei(int index)
        {
            if (index >= 0 && index < autoparkplaetze.Count)
            {
                return autoparkplaetze[index].IstFrei();
            }
            return false; // Index ungültig oder Parkplatz existiert nicht
        }

        public bool IstMotorradparkplatzFrei(int index)
        {
            if (index >= 0 && index < motorradparkplaetze.Count)
            {
                return motorradparkplaetze[index].IstFrei();
            }
            return false; // Index ungültig oder Parkplatz existiert nicht
        }

    }
}
