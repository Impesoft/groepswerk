using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekening
{
    public partial class Form1 : Form
    {
        Rekening account = new Rekening("123-4530396-13", 100);
        SpaarRekening spaar = new SpaarRekening("735-1420224-12", 200, 5);
        ZichtRekening zicht = new ZichtRekening("987-6543210-12", 25);
        public Form1()
        {
            InitializeComponent();
        }
       
        private void RekeningPlus_Click(object sender, EventArgs e)
        {
            account.Storten(Convert.ToDouble(invoerRekening.Text));
            uitvoerRekening.Text = account.ToString();
        }

        private void RekeningMin_Click(object sender, EventArgs e)
        {
            account.Afhalen(Convert.ToDouble(invoerRekening.Text));
            uitvoerRekening.Text = account.ToString();
        }

        private void SpaarPlus_Click(object sender, EventArgs e)
        {
            spaar.Storten(Convert.ToDouble(invoerSpaar.Text));
            uitvoerSpaar.Text = spaar.ToString();
        }

        private void SpaarMin_Click(object sender, EventArgs e)
        {
            spaar.Afhalen(Convert.ToDouble(invoerSpaar.Text));
            uitvoerSpaar.Text = spaar.ToString();
        }

        private void Intrest_Click(object sender, EventArgs e)
        {
            spaar.SchrijfRenteBij();
            uitvoerSpaar.Text = spaar.ToString();
        }

        private void ZichtPlus_Click(object sender, EventArgs e)
        {
            zicht.Storten(Convert.ToDouble(invoerZicht.Text));
            uitvoerZicht.Text = zicht.ToString();
        }

        private void ZichtMin_Click(object sender, EventArgs e)
        {
            zicht.Afhalen(Convert.ToDouble(invoerZicht.Text));
            uitvoerZicht.Text = zicht.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uitvoerRekening.Text = account.ToString();
            uitvoerSpaar.Text = spaar.ToString();
            uitvoerZicht.Text = zicht.ToString();
        }
    }
}
