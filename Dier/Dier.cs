using System;
using System.Collections.Generic;
using System.Text;

namespace Dieren
{
 
    abstract class Dier
    {
        public virtual string Eten()
        {
            return "";
        }
        public virtual string Praten(string vraag)
        {
            return "";
        }
        public virtual string Strelen()
        {
            return "";
        }
        public virtual string Naam 
        {
            get
            {
                return _naam;
            }
            protected set 
            {
                _naam = value;
            }
        }
        private string _naam;
        protected Dier(string naam)
        {
    
            
                _naam = naam;
            
        }
    }
}
