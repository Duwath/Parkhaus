using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkhaus360
{
    //Im struct Position wird die Etage und der genaue Parkplatz gespeichert
    internal struct Position
    {
        public int etage;
        public int platz;
        public Position(int e, int p)
        {
            etage = e;
            platz = p;
        }
    }
    //Im Parkplatz selbst ist ein Verweis auf die Position und das Fahrzeug Objekt selbst gespeichert
    internal class Parkplatz
    {
        private Fahrzeug fahrzeug;
        private Position position;

        public Parkplatz(Position pos)
        {
            position = pos;
        }
        //Getter für die Position
        public Position GetPosition()
        {
            return position;
        }
        //Methode um zu prüfen ob ein spezifischer Parkplatz frei ist
        public bool IstFrei()
        {
            return fahrzeug == null;
        }
        //Methode um einem Parkplatz ein Fahrzeug Objekt zuzuweisen
        public void belegePlatz(Fahrzeug f)
        {
            fahrzeug = f;
        }
        //Getter-Methode um die Informationen des Fahrzeugs wieder aus dem Parkplatz raus zu bekommen
        public Fahrzeug GetFahrzeug()
        {
            return fahrzeug;
        }
        //Methode um einen Platz wieder freizugeben.
        //Das Fahrzeug Objekt auf welches dort verwiesen wurde existiert zwar erstmal weiter
        //aber wird vom Garbagecollector entfernt.
        public void GibPlatzFrei()
        {
            fahrzeug = null;
        }       
    }
    //Modifier der Parkplatzklasse um Parkplätze von Autos und Motorrädern unterscheiden zu können
    internal class AutoParkplatz : Parkplatz
    {
        public AutoParkplatz(Position pos) : base(pos)
        {
        }
        public void belegePlatz(Auto a)
        {
            base.belegePlatz(a);
        }

        public new Auto GetFahrzeug()
        {
            return (Auto)base.GetFahrzeug();
        }
    }
    internal class MotorradParkplatz : Parkplatz
    {
        public MotorradParkplatz(Position pos) : base(pos)
        {
        }
        public void belegePlatz(Auto a)
        {
            base.belegePlatz(a);
        }
        public new Motorrad GetFahrzeug()
        {
            return (Motorrad)base.GetFahrzeug();
        }
    }
}
