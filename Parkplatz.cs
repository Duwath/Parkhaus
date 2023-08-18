using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkhaus360
{
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
    internal abstract class Parkplatz
    {
        private Fahrzeug fahrzeug;
        private Position position;

        public Parkplatz(Position pos)
        {
            position = pos;
        }

        public Position GetPosition()
        {
            return position;
        }
        public bool IstFrei()
        {
            return fahrzeug == null;
        }

        public void belegePlatz(Fahrzeug f)
        {
            fahrzeug = f;
        }

        public Fahrzeug GetFahrzeug()
        {
            return fahrzeug;
        }
        public void GibPlatzFrei()
        {
            fahrzeug = null;
        }
        


    }

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
