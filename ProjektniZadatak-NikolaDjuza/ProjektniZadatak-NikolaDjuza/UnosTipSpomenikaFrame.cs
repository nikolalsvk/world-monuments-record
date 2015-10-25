using ProjektniZadatak_NikolaDjuza.Class;
using ProjektniZadatak_NikolaDjuza.Dialog;
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
    public partial class UnosTipSpomenikaFrame : Form
    {
        public static TipSpomenika tip;
        public static bool izmenaTipa = false;
        private static int indexMenjanogTipa;

        private static bool formValid;
        public UnosTipSpomenikaFrame()
        {
            InitializeComponent();
        }

        private void TipSpomenikaFrame_Load(object sender, EventArgs e)
        {
            if (izmenaTipa)
            {
                SifraTipaTextBox.Text = tip.SifraTipaSpomenika;
                SifraTipaTextBox.Enabled = false;
                ImeTipaTextBox.Text = tip.ImeTipa;
                OpisTipaTextBox.Text = tip.Opis;
                SlikaSpomenikaBox.Image = tip.Ikonica;

                indexMenjanogTipa = MainFrame.postojeciTipovi.IndexOf(tip);

                this.Text = "Izmena tipa";
            }
            else
            {
                this.Text = "Unos tipa";
                SifraTipaTextBox.Enabled = true;
            }
        }

        private void dodajTipButton_Click(object sender, EventArgs e)
        {
            formValid = true;
            this.ValidateChildren();
            if (!formValid)
            {
                return;
            }

            TipSpomenika tip = new TipSpomenika();
            tip.SifraTipaSpomenika = SifraTipaTextBox.Text;
            tip.ImeTipa = ImeTipaTextBox.Text;
            tip.Opis = OpisTipaTextBox.Text;
            tip.Ikonica = SlikaSpomenikaBox.Image;

            if (izmenaTipa)
            {
                MainFrame.postojeciTipovi.RemoveAt(indexMenjanogTipa);
                MainFrame.postojeciTipovi.Insert(indexMenjanogTipa, tip);
            }
            else
            {
                MainFrame.postojeciTipovi.Add(tip);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void izmeniButton_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Da li sigurno zelite da izmenite tip",
                "Da li sigurno zelite da izmenite tip", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r.Equals(DialogResult.Yes))
            {

                TipSpomenika noviTip = new TipSpomenika();
                noviTip.SifraTipaSpomenika = SifraTipaTextBox.Text;
                noviTip.ImeTipa = ImeTipaTextBox.Text;
                noviTip.Opis = OpisTipaTextBox.Text;
                noviTip.Ikonica = SlikaSpomenikaBox.Image;


                int ind = MainFrame.postojeciTipovi.IndexOf(tip);
                MainFrame.postojeciTipovi.RemoveAt(ind);
                MainFrame.postojeciTipovi.Insert(ind, noviTip);


                for (int i = 0; i < MainFrame.evidencijaSpomenika.Count; i++)
                {
                    Spomenik s = MainFrame.evidencijaSpomenika[i];
                    if (tip.SifraTipaSpomenika.Equals(s.Tip.SifraTipaSpomenika))
                    {
                        MainFrame.evidencijaSpomenika[i].Tip = noviTip;
                    }
                }

            }
        }

        private void SlikaSpomenikaBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    SlikaSpomenikaBox.Image = new Bitmap(dlg.FileName);

                    tip.Ikonica = SlikaSpomenikaBox.Image;
                }
            }
        }

        private void SlikaSpomenikaBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(SlikaSpomenikaBox, "Kliknite da biste dodali sliku");
        }

        private void removePicButton_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Da li zelite da trajno obrisete sliku?",
                "Da li zelite da trajno obrisete sliku?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r.Equals(DialogResult.Yes))
            {
                SlikaSpomenikaBox.Image = global::ProjektniZadatak_NikolaDjuza.Properties.Resources._default;

                tip.Ikonica = SlikaSpomenikaBox.Image;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
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
            Help.ShowHelp(this, "..\\..\\Resources\\Help.chm", HelpNavigator.Topic, "dodavanje_tipa.htm");
        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox box = (TextBox)sender;

            if (box.Enabled)
            {
                if (box.Text.Equals(""))
                {
                    errorProvider.SetError(box, "Polje ne moze biti prazno!");
                    formValid = false;
                }
                else if (box.Name.Contains("Sifra"))
                {
                    bool sifraPostoji = false;
                    String sifra = box.Text;
                    foreach (TipSpomenika tip in MainFrame.postojeciTipovi)
                    {
                        if (tip.SifraTipaSpomenika.Equals(sifra))
                        {
                            errorProvider.SetError(box, "Sifra je vec zauzeta!");
                            formValid = false;
                            sifraPostoji = true;
                            break;
                        }
                    }
                    if (!sifraPostoji)
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
    }
}
