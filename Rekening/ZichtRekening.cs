using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekening
{
    internal class ZichtRekening : Rekening
    {
        public ZichtRekening(string rekeningNummer, double saldo)
            : base(rekeningNummer, saldo)
        {
            Minimum = -100;
        }
    }
}