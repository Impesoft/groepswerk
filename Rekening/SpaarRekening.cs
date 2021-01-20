using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekening
{
    class SpaarRekening : Rekening
    {
        private double _percentage;

        public double Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }

        public SpaarRekening(string accountNumber, double saldo, double percentage)
            :base(accountNumber, saldo)
        {
            Percentage = percentage;
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
