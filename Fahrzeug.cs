using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkhaus360
{
    //Im Fahrzeug Objekt wird das random erstelle Kennzeichen gespeichert.
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
    //Modifier für die Fahrzeugklasse um Auto und Motorrad unterscheiden zu können.
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
