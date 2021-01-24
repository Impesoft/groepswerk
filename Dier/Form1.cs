using System;
using System.Windows.Forms;

namespace Dieren
{
    public partial class Form1 : Form
    {
        public bool AnimalInstantiated = false;
        public IDier DierObject;

        public Form1()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            string naam = NaamBox.Text.ToString();
            CheckHeeftNaam(naam);
        }

        private void CheckHeeftNaam(string naam)
        {
            bool heeftNaam = (naam != "");
            if (heeftNaam)
            {
                NaamBox.Enabled = false;
                MaakDier(naam);
            }
            else
            {
                Error("Geef je dier een naam!");
            }
        }

        private void MaakDier(string naam)
        {
            IkBenEen dierType;
            AnimalInstantiated = true;
            dierType = DefineDierType();
            DierObject = DitIsEen(dierType, naam);
        }

        private IkBenEen DefineDierType()
        {
            IkBenEen dierType = 0;
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
            return dierType;
        }

        public IDier DitIsEen(IkBenEen dierType, string naam)
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
                    Error("uitzondering Onbekend Dier");
                    return null;
            }
            return dierObject;
        }

        private void Praten_Click(object sender, EventArgs e)
        {
            if (AnimalInstantiated)
            {
                PraatAlsIkKan();
            }
            else
            {
                Error("Dit dier werd niet geinstantieerd!");
            }
        }

        private void Strelen_Click(object sender, EventArgs e)
        {
            if (AnimalInstantiated)
            {
                AlDanNietReageerOpStrelen();
            }
            else
            {
                Error("Dit dier werd niet geinstantieerd!");
            }
        }

        private void Eten_Click(object sender, EventArgs e)
        {
            if (AnimalInstantiated)
            {
                AlDanNietBespreekEten();
            }
            else
            {
                Error("Dit dier werd niet geinstantieerd!");
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PraatAlsIkKan()
        {
            var selected = Vraag.SelectedItem;
            if (selected != null)
            {
                Praat(selected);
            }
            else
            {
                Error("Geen tekst geselecteerd!");
            }
        }

        private void Praat(object selected)
        {
            string tekst = DierObject.Praten(selected.ToString());
            if (tekst != "")
            {
                Popup(tekst, "praat");
            }
        }

        private void AlDanNietReageerOpStrelen()
        {
            string tekst = DierObject.Strelen();
            if (tekst != "")
            {
                Popup(tekst, "strelen");
            }
        }

        private void AlDanNietBespreekEten()
        {
            string tekst = DierObject.Eten();
            if (tekst != "")
            {
                Popup(tekst, "eten");
            }
        }

        private void Popup(string tekst, string methode)
        {
            MessageBox.Show($"{DierObject.Name} : {tekst}", methode);
        }

        private void Error(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Cat_CheckedChanged(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void Parrot_CheckedChanged(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void Human_CheckedChanged(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void ResetValues()
        {
            DierObject = null;
            NaamBox.Text = "";
            NaamBox.Enabled = true;
            AnimalInstantiated = false;
        }
    }
}