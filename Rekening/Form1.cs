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
        private Rekening rekening = new Rekening("123-4530396-13", 100);
        private SpaarRekening spaarrekening = new SpaarRekening("735-1420224-12", 200, 5);
        private ZichtRekening zichtrekening = new ZichtRekening("987-6543210-12", 25);

        public Form1()
        {
            InitializeComponent();
        }

        private void RekeningPlus_Click(object sender, EventArgs e)
        {
            rekening.Storten(Convert.ToDouble(invoerRekening.Text));
            uitvoerRekening.Text = rekening.ToString();
        }

        private void RekeningMin_Click(object sender, EventArgs e)
        {
            rekening.Afhalen(Convert.ToDouble(invoerRekening.Text));
            uitvoerRekening.Text = rekening.ToString();
        }

        private void SpaarPlus_Click(object sender, EventArgs e)
        {
            spaarrekening.Storten(Convert.ToDouble(invoerSpaar.Text));
            uitvoerSpaarrekening.Text = spaarrekening.ToString();
        }

        private void SpaarMin_Click(object sender, EventArgs e)
        {
            spaarrekening.Afhalen(Convert.ToDouble(invoerSpaar.Text));
            uitvoerSpaarrekening.Text = spaarrekening.ToString();
        }

        private void Intrest_Click(object sender, EventArgs e)
        {
            spaarrekening.SchrijfRenteBij();
            uitvoerSpaarrekening.Text = spaarrekening.ToString();
        }

        private void ZichtPlus_Click(object sender, EventArgs e)
        {
            zichtrekening.Storten(Convert.ToDouble(invoerZicht.Text));
            uitvoerZichtrekening.Text = zichtrekening.ToString();
        }

        private void ZichtMin_Click(object sender, EventArgs e)
        {
            zichtrekening.Afhalen(Convert.ToDouble(invoerZicht.Text));
            uitvoerZichtrekening.Text = zichtrekening.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uitvoerRekening.Text = rekening.ToString();
            uitvoerSpaarrekening.Text = spaarrekening.ToString();
            uitvoerZichtrekening.Text = zichtrekening.ToString();
        }
    }
}