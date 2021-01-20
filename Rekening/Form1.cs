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
        SpaarRekening sa = new SpaarRekening("735-1420224-12", 200, 5);
        ZichtRekening ca = new ZichtRekening("987-6543210-12", 25);
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
            sa.Storten(Convert.ToDouble(invoerSpaar.Text));
            uitvoerSpaar.Text = sa.ToString();
        }

        private void SpaarMin_Click(object sender, EventArgs e)
        {
            sa.Afhalen(Convert.ToDouble(invoerSpaar.Text));
            uitvoerSpaar.Text = sa.ToString();
        }

        private void Intrest_Click(object sender, EventArgs e)
        {
            sa.SchrijfRenteBij();
            uitvoerSpaar.Text = sa.ToString();
        }

        private void ZichtPlus_Click(object sender, EventArgs e)
        {
            ca.Storten(Convert.ToDouble(invoerZicht.Text));
            uitvoerZicht.Text = ca.ToString();
        }

        private void ZichtMin_Click(object sender, EventArgs e)
        {
            ca.Afhalen(Convert.ToDouble(invoerZicht.Text));
            uitvoerZicht.Text = ca.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uitvoerRekening.Text = account.ToString();
            uitvoerSpaar.Text = sa.ToString();
            uitvoerZicht.Text = ca.ToString();
        }
    }
}
