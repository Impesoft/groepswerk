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
    public partial class CilinderAppForm : Form
    {
        public Punt punt;
        public Cirkel cirkel;
        public Cilinder cilinder;
        public CilinderAppForm()
        {
            InitializeComponent();
            punt = new Punt(3, 4);
            cirkel = new Cirkel(3,4,5);
            cilinder = new Cilinder(3,4,5,6);

        }

        private void buttonPunt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(punt.Gegevens());

        }

        private void buttonCirkel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cirkel.Gegevens());

        }

        private void buttonCilinder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cilinder.Gegevens());

        }
    }
}
