using System;

namespace Dieren
{
    internal class Papegaai : IDier
    {
        private Random rnd = new Random();
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Papegaai(string naam)
        {
            Name = naam;
        }

        public string Praten(string vraag)
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

        public string Strelen()
        {
            return "Koko.";
        }

        public string Eten()
        {
            return "";
        }
    }
}