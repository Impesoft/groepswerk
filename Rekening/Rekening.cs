using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekening
{
    class Rekening
    {
        private double _saldo;
        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < Minimum)
                {
                    MessageBox.Show($"Het is niet toegestaan om onder {Minimum} te gaan!");
                }
                else
                {
                    _saldo = value;
                }
            }
        }
        private string rekeningnummer;
        public string RekeningNummer
        {
            get { return rekeningnummer; }
            set { rekeningnummer = value; }
        }

        private double _minimum;
        public double Minimum
        {
            get { return _minimum; }
            set { _minimum = value; }
        }

        public Rekening(string rekeningNummer, double saldo)
        {
            RekeningNummer = rekeningNummer;
            Saldo = saldo;
        }
        public void Afhalen(double bedrag)
        {
            Saldo -= bedrag;
            
        }
        public void Storten(double bedrag)
        {
            Saldo += bedrag;
        }
        public override string ToString()
        {
            return $"RekeningNummer {RekeningNummer} saldo € {Saldo}.";
        }
    }
}
