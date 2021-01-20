using System;
using System.Collections.Generic;
using System.Text;

namespace Rekening
{
    public class Cirkel : Punt
    {
        private double _r;

        public double R
        {
            get { return _r; }
            set { _r = value; }
        }

        public Cirkel()
        {

        }
        public Cirkel(double x,double y, double r)
        {
            X = x;
            Y = y;
            R = r;

        }
        public double Omtrek()
        {
            return 2 * Math.PI * R;
        }
        public virtual double Oppervlakte()
        {
            return Math.PI * R * R;
        }
        public override string Gegevens()
        {
            string tekstueleVoorstelling = $"{base.Gegevens()} straal {R}";
            return tekstueleVoorstelling;

        }
    }
}
