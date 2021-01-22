using System;

namespace CilinderForm
{
    public class Cirkel : Punt
    {
        private double _r;

        public double R
        {
            get { return _r; }
            set { _r = value; }
        }

        public Cirkel() : base()
        {
            R = new Random().Next(1, 10);
        }

        public Cirkel(double x, double y, double r) : base(x, y)
        {
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