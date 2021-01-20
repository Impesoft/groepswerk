using System;
using System.Windows.Forms;

namespace Dieren
{
    public partial class Form1 : Form
    {
        public bool animalInstantiated = false;
        Dier dierObject = null;

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
                if (Cat.Checked)
                {
                    dierObject = new Dieren.Kat(naam);
                    animalInstantiated = true;
                }
                if (Parrot.Checked)
                {
                    dierObject = new Dieren.Papegaai(naam);
                    animalInstantiated = true;
                }
                if (Human.Checked)
                {
                    dierObject = new Dieren.Mens(naam);
                    animalInstantiated = true;
                }
            }
            else
            {
                MessageBox.Show("Geef je dier een naam!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                        MessageBox.Show($"{dierObject.Naam} : {tekst}", "praat");
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
                    MessageBox.Show($"{dierObject.Naam} : {tekst}", "strelen");
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
                    MessageBox.Show($"{dierObject.Naam} : {tekst}", "eten");
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
            NaamBox.Enabled=true;
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