using System;
using System.Windows.Forms;

namespace Rekening
{
    public partial class CilinderAppForm : Form
    {
        public Punt punt;
        public Cirkel cirkel;
        public Cilinder cilinder;

        public CilinderAppForm()
        {
            InitializeComponent();
            punt = new Punt(3, 4);
            cirkel = new Cirkel(3, 4, 5);
            cilinder = new Cilinder(3, 4, 5, 6);
        }

        private void buttonPunt_Click(object sender, EventArgs e)
        {
            ShowMessage(punt);
        }

        private void buttonCirkel_Click(object sender, EventArgs e)
        {
            ShowMessage(cirkel);
        }

        private void buttonCilinder_Click(object sender, EventArgs e)
        {
            ShowMessage(cilinder);
        }

        private void ShowMessage(Punt jouwPuntachtige)
        {
            MessageBox.Show(jouwPuntachtige.Gegevens());
        }
    }
}