using ProjektniZadatak_NikolaDjuza.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektniZadatak_NikolaDjuza
{
    public partial class UnosEtiketaSpomenikaFrame : Form
    {
        public static Etiketa et;
        public static bool izmenaEtikete = false;

        private static bool formValid = false;

        public UnosEtiketaSpomenikaFrame()
        {
            InitializeComponent();
        }

        private void BojaButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult r = cd.ShowDialog();

            if (r.Equals(DialogResult.OK))
            {
                BojaButton.BackColor = cd.Color;
            }
        }

        private void EtiketaSpomenikaFrame_Load(object sender, EventArgs e)
        {
            if (izmenaEtikete)
            {
                sifraEtiketeTextBox.Text = et.SifraEtikete;
                sifraEtiketeTextBox.Enabled = false;
                opisEiketeTextBox.Text = et.OpisEtikete;
                BojaButton.BackColor = et.BojaEtikete;

                this.Text = "Izmena etikete";
            }
            else
            {
                et = new Etiketa();
                sifraEtiketeTextBox.Enabled = true;
                this.Text = "Unos etikete";
            }
            formValid = false;
        }

        private void DodajEtiketuButton_Click(object sender, EventArgs e)
        {
            formValid = true;
            this.ValidateChildren();
            if (!formValid)
            {
                return;
            }

            if (!sifraEtiketeTextBox.Text.Equals("") && !opisEiketeTextBox.Text.Equals("") && !izmenaEtikete)
            {
                et.SifraEtikete = sifraEtiketeTextBox.Text;
                et.BojaEtikete = BojaButton.BackColor;
                et.OpisEtikete = opisEiketeTextBox.Text;

                MainFrame.postojeceEtikete.Add(et);
            }

            if (izmenaEtikete)
            {
                Etiketa novaEtiketa = new Etiketa();
                novaEtiketa.SifraEtikete = sifraEtiketeTextBox.Text;
                novaEtiketa.BojaEtikete = BojaButton.BackColor;
                novaEtiketa.OpisEtikete = opisEiketeTextBox.Text;

                int ind = MainFrame.postojeceEtikete.IndexOf(et);
                MainFrame.postojeceEtikete.Remove(et);
                MainFrame.postojeceEtikete.Insert(ind, novaEtiketa);
                foreach (Spomenik s in MainFrame.evidencijaSpomenika)
                {
                    foreach (Etiketa eti in s.Etikete)
                    {
                        if (novaEtiketa.SifraEtikete.Equals(eti.SifraEtikete))
                        {
                            int index = s.Etikete.IndexOf(eti);
                            s.Etikete.RemoveAt(index);
                            s.Etikete.Insert(index, novaEtiketa);
                            break;
                        }
                    }
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void HelpToolstripItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "..\\..\\Resources\\Help.chm", HelpNavigator.Topic, "dodavanje_etikete.htm");
        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox box = (TextBox)sender;
            bool istaSifra = false;

            if (box.Enabled)
            {
                if (box.Text.Equals(""))
                {
                    errorProvider.SetError(box, "Polje ne moze biti prazno!");

                    formValid = false;
                }
                else if (box.Name.Contains("sifra") && !box.Text.Equals(""))
                {
                    String sifra = box.Text;
                    foreach (Etiketa et in MainFrame.postojeceEtikete)
                    {
                        if (et.SifraEtikete.Equals(sifra))
                        {
                            errorProvider.SetError(box, "Sifra je vec zauzeta!");

                            formValid = false;
                            istaSifra = true;
                            break;
                        }
                    }
                    if (!istaSifra)
                    {
                        errorProvider.SetError(box, "");
                    }
                }
                else
                {
                    errorProvider.SetError(box, "");
                }
            }
        }

        private void BojaButton_Validating(object sender, CancelEventArgs e)
        {
            Button but = (Button)sender;

            if (but.BackColor.Equals(SystemColors.Control))
            {
                errorProvider.SetError(but, "Boja nije izabrana!");
                formValid = false;
            }
            else
            {
                errorProvider.SetError(but, "");
            }
        }

        private void opisEiketeTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox box = (TextBox)sender;

            if (box.Text.Equals(""))
            {
                errorProvider.SetError(box, "Polje ne moze biti prazno!");

                formValid = false;
            }
            else
            {
                errorProvider.SetError(box, "");
            }
        }
    }
}
