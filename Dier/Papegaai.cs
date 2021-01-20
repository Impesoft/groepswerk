using System;
using System.Collections.Generic;
using System.Text;

namespace Dieren
{
    class Papegaai :Dier
    {
        Random rnd = new Random();
        public Papegaai(string naam) : base(naam)
        {
            Naam = naam;
        }
        public override string Praten(string vraag)
        {
            int chance = rnd.Next(1, 6);
            if (chance == 3) 
            {
                return "Koko kopke krabben";
            }
            else
            {
                return vraag;
            }
        }
        public override string Strelen()
        {
            return "Koko.";
        }
    }
}
