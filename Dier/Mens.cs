namespace Dieren
{
    internal class Mens : IDier
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Mens(string naam)
        {
            Name = naam;
        }

        public string Eten()
        {
            return "Amai!\nDa's Lekker!";
        }

        public string Praten(string vraag)
        {
            switch (vraag)
            {
                case "Goedendag.":
                    return "Voor u van 't zelfde.";

                case "Hey!":
                    return "Yo!";

                case "Sanka, Are you dead?":
                    return "Yah Man!";

                case "Hoe oud bent u?":
                    return "Hoe onbeleefd bent u!";

                case "En? hoe voelen we ons vandaag?":
                    return "tiptop!";

                case "Hoe heet je?":
                    return "bij 't vuur.";

                case "Ook de grappigste thuis zeker?":
                    return "Hoezo ook?";

                case "Vraag 7":
                    return "7de antwoord";

                case "Vraag 8":
                    return "8e antwoord";

                case "9?":
                    return "Nein!";

                default:
                    return "";
            }
        }

        public string Strelen()
        {
            return "Blijf van mijn lijf. Arrh.";
        }
    }
}