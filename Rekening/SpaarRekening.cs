using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekening
{
    internal class SpaarRekening : Rekening
    {
        private double _percentage;

        public double Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }

        public SpaarRekening(string rekeningnummer, double saldo, double intrest)
            : base(rekeningnummer, saldo)
        {
            Percentage = intrest;
        }

        public void SchrijfRenteBij()
        {
            Saldo += (Saldo / 100) * Percentage;
        }

        public override string ToString()
        {
            return base.ToString() + $" ( {Percentage}%)";
        }
    }
}