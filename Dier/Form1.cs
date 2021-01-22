using System;
using System.Windows.Forms;

namespace Dieren
{
    public partial class Form1 : Form
    {
        public bool animalInstantiated = false;
        private IDier dierObject;

        public Form1()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            string naam = NaamBox.Text.ToString();
            bool heeftNaam = (naam != "");
            if (heeftNaam)
            {
                NaamBox.Enabled = false;
                MaakDier(naam);
            }
            else
            {
                MessageBox.Show("Geef je dier een naam!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MaakDier(string naam)
        {
            IkBenEen dierType = 0;
            animalInstantiated = true;
            if (Cat.Checked)
            {
                dierType = IkBenEen.Kat;
            }
            if (Parrot.Checked)
            {
                dierType = IkBenEen.Papegaai;
            }
            if (Human.Checked)
            {
                dierType = IkBenEen.Mens;
            }
            IDier dierObject = DitIsEen(dierType, naam);
        }

        private IDier DitIsEen(IkBenEen dierType, string naam)
        {
            IDier dierObject;
            switch (dierType)
            {
                case IkBenEen.Kat:
                    dierObject = new Dieren.Kat(naam);
                    break;

                case IkBenEen.Papegaai:
                    dierObject = new Dieren.Papegaai(naam);
                    break;

                case IkBenEen.Mens:
                    dierObject = new Dieren.Mens(naam);
                    break;

                default:
                    MessageBox.Show("uitzondering Onbekend Dier");
                    return null;
            }
            return dierObject;
        }

        private void Praten_Click(object sender, EventArgs e)
        {
            if (animalInstantiated)
            {
                var selected = Vraag.SelectedItem;
                if (selected != null)
                {
                    string tekst = dierObject.Praten(selected.ToString());
                    if (tekst != "")
                    {
                        MessageBox.Show($"{dierObject.Name} : {tekst}", "praat");
                    }
                }
                else
                {
                    MessageBox.Show("Geen tekst geselecteerd!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Dit dier werd niet geinstantieerd!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Strelen_Click(object sender, EventArgs e)
        {
            if (animalInstantiated)
            {
                string tekst = dierObject.Strelen();
                if (tekst != "")
                {
                    MessageBox.Show($"{dierObject.Name} : {tekst}", "strelen");
                }
            }
            else
            {
                MessageBox.Show("Dit dier werd niet geinstantieerd!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Eten_Click(object sender, EventArgs e)
        {
            if (animalInstantiated)
            {
                string tekst = dierObject.Eten();
                if (tekst != "")
                {
                    MessageBox.Show($"{dierObject.Name} : {tekst}", "eten");
                }
            }
            else
            {
                MessageBox.Show("Dit dier werd niet geinstantieerd!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Cat_CheckedChanged(object sender, EventArgs e)
        {
            dierObject = null;
            NaamBox.Text = "";
            NaamBox.Enabled = true;
            animalInstantiated = false;
        }

        private void Parrot_CheckedChanged(object sender, EventArgs e)
        {
            dierObject = null;
            NaamBox.Text = "";
            NaamBox.Enabled = true;
            animalInstantiated = false;
        }

        private void Human_CheckedChanged(object sender, EventArgs e)
        {
            dierObject = null;
            NaamBox.Text = "";
            NaamBox.Enabled = true;
            animalInstantiated = false;
        }
    }
}