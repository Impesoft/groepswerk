using System;
using System.Collections.Generic;
using System.Text;

namespace Dieren
{
    internal class Kat : Dier
    {
        private int _teller = 0;

        public Kat(string naam) : base(naam)
        {
            Naam = naam;
        }

        public override string Praten(string vraag)
        {
            _teller++;
            if (_teller % 3 == 0)
            {
                return "Miauwkes";
            }
            return "";
        }

        public override string Strelen()
        {
            return "RrRr.";
        }
    }
}