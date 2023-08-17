using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkhaus360
{
    internal class Fahrzeug
    {
        private string kennzeichen;
        public Fahrzeug(string kenn)
        {
            kennzeichen = kenn;
        }
        public string GetKennzeichen()
        {
            return kennzeichen;
        }
    }

    internal class Auto : Fahrzeug
    {
        public Auto(string kenn) : base(kenn)
        {
        }

    }

    internal class Motorrad : Fahrzeug
    {
        public Motorrad(string kenn) : base(kenn)
        {
        }
    }
}
