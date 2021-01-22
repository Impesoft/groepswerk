using System;
using System.Collections.Generic;
using System.Text;

namespace Dieren
{
    internal interface IDier
    {
        public string Eten();

        public string Praten(string vraag);

        public string Strelen();
    }
}