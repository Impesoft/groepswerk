using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Rekening
{
    public class Punt
    {
        private double _x;

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }
        private double _y;

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Punt()
        {

        }
        public Punt(double x, double y)
        {
            X = x;
            Y = y;
        }
        public virtual string Gegevens()
        {
            string tekstueleVoorstelling = $"({_x},{_y})";
            return(tekstueleVoorstelling);
        }
    }
}
