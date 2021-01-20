using System;
using System.Collections.Generic;
using System.Text;

namespace Dieren
{
    class Mens :Dier
    {
        public Mens(string naam) : base (naam)
        {
            Naam = naam;
        }
        public override string Eten()
        {
            return "Amai!\nDa's Lekker!";
        }
        public override string Praten(string vraag) 
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
                    return "Hoe onbeleefd ben u!";
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
            // listBox.SelectedItem.ToString()


        }
        public override string Strelen()
        {
            return "Blijf van mijn lijf. Arrh.";
        }

    }
}
