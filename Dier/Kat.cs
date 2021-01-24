namespace Dieren
{
    internal class Kat : IDier
    {
        private int _teller = 0;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Kat(string naam)
        {
            Name = naam;
        }

        public string Praten(string vraag)
        {
            _teller++;
            if (_teller % 3 == 0)
            {
                return "Miauwkes";
            }
            return "";
        }

        public string Strelen()
        {
            return "RrRr.";
        }

        public string Eten()
        {
            return "";
        }
    }
}