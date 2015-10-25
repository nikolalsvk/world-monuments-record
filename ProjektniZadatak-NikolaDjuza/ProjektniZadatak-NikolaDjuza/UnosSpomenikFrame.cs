using ProjektniZadatak_NikolaDjuza.Class;
using ProjektniZadatak_NikolaDjuza.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektniZadatak_NikolaDjuza
{
    public partial class UnosSpomenikFrame : Form
    {
        public static Spomenik noviSpomenik;

        private static bool tipUnet = false;
        public static bool izmenaSpomenika = false;
        private static int indexMenjanogSpomenika = -1;
        private static bool formValid;

        public UnosSpomenikFrame()
        {
            InitializeComponent();

            if (noviSpomenik == null)
            {
                noviSpomenik = new Spomenik();
                izmenaSpomenika = false;
            }


        }

        private void NoviSpomenik_Load(object sender, EventArgs e)
        {
            if (izmenaSpomenika)
            {
                this.Text = "Izmena spomenika";
            }
            else
            {
                this.Text = "Unos spomenika";
            }

            SlikaSpomenikaBox.Image = Resources._default;

            BindingSource sourcePostojece = new BindingSource(MainFrame.postojeceEtikete, null);
            PostojeceEtiketeGridView.DataSource = sourcePostojece;

            BindingSource source = new BindingSource(noviSpomenik.Etikete, null);
            EtiketeDataGridView.DataSource = source;

            PostojeceEtiketeGridView.Columns[1].Visible = false;
            PostojeceEtiketeGridView.Columns[0].HeaderText = "Sifra etikete";
            PostojeceEtiketeGridView.Columns[2].Visible = false;
            PostojeceEtiketeGridView.ClearSelection();

            EtiketeDataGridView.Columns[1].Visible = false;
            EtiketeDataGridView.Columns[0].HeaderText = "Sifra etikete";
            EtiketeDataGridView.Columns[2].Visible = false;
            EtiketeDataGridView.ClearSelection();

            if (izmenaSpomenika)
            {
                izmenaSpomenika = true;
                tipUnet = true;
                indexMenjanogSpomenika = MainFrame.evidencijaSpomenika.IndexOf(noviSpomenik);
                loadWholeSpomenik();
                IdSpomenikaTextBox.Enabled = false;

                CurrencyManager cm = (CurrencyManager)BindingContext[PostojeceEtiketeGridView.DataSource];
                cm.SuspendBinding();
                foreach (DataGridViewRow row in PostojeceEtiketeGridView.Rows)
                {
                    Etiketa et = (Etiketa)row.DataBoundItem;
                    for (int i = 0; i < noviSpomenik.Etikete.Count; i++)
                    {
                        if (noviSpomenik.Etikete[i].SifraEtikete.Equals(et.SifraEtikete))
                        {
                            if (PostojeceEtiketeGridView.Rows[row.Index].Visible)
                            {
                                PostojeceEtiketeGridView.Rows[row.Index].Visible = false;
                            }
                            break;
                        }
                    }
                }
                cm.ResumeBinding();
            }
        }

        private void loadWholeSpomenik()
        {
            IdSpomenikaTextBox.Text = noviSpomenik.SifraSpomenika;
            ImeSpomenikaTextBox.Text = noviSpomenik.Ime;
            PrihodTextBox.Text = Convert.ToString(noviSpomenik.GodisnjiPrihod);
            KlimaComboBox.SelectedIndex = (int)noviSpomenik.Klima;
            TuristickiStatusComboBox.SelectedIndex = (int)noviSpomenik.TuristickiStatus;
            OpisSpomenikaTextBox.Text = noviSpomenik.Opis;
            datumMaskedTextBox.Text = noviSpomenik.DatumOtkrivanja;
            UgrozeneVrsteCheckBox.Checked = noviSpomenik.StanisteUgrozenih;
            UgrozenostCheckBox.Checked = noviSpomenik.EkoloskiUgrozen;
            NaseljenCheckBox.Checked = noviSpomenik.NaseljenRegion;
            SlikaSpomenikaBox.Image = noviSpomenik.SlikaSpomenika;
            TipSpomenikaTextBox.Text = noviSpomenik.Tip.ImeTipa;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            formValid = true;
            this.ValidateChildren();
            if (formValid)
            {
                noviSpomenik.SifraSpomenika = IdSpomenikaTextBox.Text;
                noviSpomenik.Ime = ImeSpomenikaTextBox.Text;
                noviSpomenik.GodisnjiPrihod = Convert.ToDecimal(PrihodTextBox.Text);
                noviSpomenik.Klima = (Class.KlimaSpomenika)KlimaComboBox.SelectedIndex;
                noviSpomenik.TuristickiStatus = (Class.TuristickiStatusSpomenika)TuristickiStatusComboBox.SelectedIndex;
                noviSpomenik.Opis = OpisSpomenikaTextBox.Text;
                noviSpomenik.EkoloskiUgrozen = UgrozenostCheckBox.Checked;
                noviSpomenik.StanisteUgrozenih = UgrozeneVrsteCheckBox.Checked;
                noviSpomenik.NaseljenRegion = NaseljenCheckBox.Checked;
                noviSpomenik.DatumOtkrivanja = datumMaskedTextBox.Text;
                if (noviSpomenik.SlikaSpomenika == null)
                {
                    noviSpomenik.SlikaSpomenika = noviSpomenik.Tip.Ikonica;
                }
                else
                {
                    noviSpomenik.SlikaSpomenika = SlikaSpomenikaBox.Image;
                }
                // tip vec dodat
                // etiketa vec dodata
                if (izmenaSpomenika)
                {
                    MainFrame.evidencijaSpomenika.RemoveAt(indexMenjanogSpomenika);
                    MainFrame.evidencijaSpomenika.Insert(indexMenjanogSpomenika, noviSpomenik);
                }
                else
                {
                    MainFrame.evidencijaSpomenika.Add(noviSpomenik);
                }
            }
            else
            {
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PrihodTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ovo je događaj koji se dešava kada korisnik nešto otkuca u polje
            if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == '.'
                || e.KeyChar == ',')) //Proveravamo da li je ukucano brojka ili backspace
            {
                e.Handled = true; //Ako nije, zaustavimo dalju obradu ovog događaja putem e.Handled= true
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
                    noviSpomenik.SlikaSpomenika = SlikaSpomenikaBox.Image;
                }
            }
        }

        private void TipButton_Click(object sender, EventArgs e)
        {
            PrikazTipSpomenikaFrame tipFrame = new PrikazTipSpomenikaFrame();
            DialogResult r = tipFrame.ShowDialog();

            if (r.Equals(DialogResult.OK))
            {
                //MessageBox.Show("Tip unet", "Tip unet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tipUnet = true;
                TipSpomenikaTextBox.Text = noviSpomenik.Tip.ImeTipa;
            }
            else
            {
                //MessageBox.Show("Tip nije unet", "Tip nije unet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void SlikaSpomenikaBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(SlikaSpomenikaBox, "Trenutna slika spomenika");
        }

        private void obrisiButton_Click(object sender, EventArgs e)
        {
            SlikaSpomenikaBox.Image = Resources._default;
            noviSpomenik.SlikaSpomenika = null;
        }

        private void DataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (e.RowIndex != -1)
            {
                Etiketa et = (Etiketa)dg.Rows[e.RowIndex].DataBoundItem;

                dg.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = et.OpisEtikete;
            }
        }

        private void FromPostojeceToEtiketeButton_Click(object sender, EventArgs e)
        {
            if (PostojeceEtiketeGridView.SelectedRows.Count > 0)
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[PostojeceEtiketeGridView.DataSource];
                cm.SuspendBinding();
                foreach (DataGridViewRow row in PostojeceEtiketeGridView.SelectedRows)
                {
                    Etiketa et = (Etiketa)row.DataBoundItem;
                    noviSpomenik.Etikete.Add(et);

                    PostojeceEtiketeGridView.Rows[row.Index].Visible = false;
                }
                cm.ResumeBinding();
                BindingSource source = new BindingSource(noviSpomenik.Etikete, null);
                EtiketeDataGridView.DataSource = source;
                EtiketeDataGridView.Refresh();
                PostojeceEtiketeGridView.ClearSelection();
                EtiketeDataGridView.ClearSelection();
            }
        }

        private void FromEtiketeToPostojeceButton_Click(object sender, EventArgs e)
        {
            if (EtiketeDataGridView.SelectedRows.Count > 0)
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[EtiketeDataGridView.DataSource];
                cm.SuspendBinding();
                foreach (DataGridViewRow row in EtiketeDataGridView.SelectedRows)
                {
                    foreach (DataGridViewRow r in PostojeceEtiketeGridView.Rows)
                    {
                        Etiketa et = (Etiketa)row.DataBoundItem;

                        if (et.SifraEtikete.Equals(((Etiketa)r.DataBoundItem).SifraEtikete))
                        {
                            PostojeceEtiketeGridView.Rows[r.Index].Visible = true;
                            noviSpomenik.Etikete.Remove(et);
                            break;
                        }
                    }
                }
                cm.ResumeBinding();
            }
        }

        private void PostojeceEtiketeGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex != 0)
                return;

            DataGridView dg = (DataGridView)sender;

            Etiketa et = (Etiketa)dg.Rows[e.RowIndex].DataBoundItem;

            e.CellStyle.BackColor = et.BojaEtikete;
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
            Help.ShowHelp(this, "..\\..\\Resources\\Help.chm", HelpNavigator.Topic, "dodavanje_spomenika.htm");
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
                else if (box.Name.Contains("Id"))
                {
                    String sifra = box.Text;
                    foreach (Spomenik s in MainFrame.evidencijaSpomenika)
                    {
                        if (s.SifraSpomenika.Equals(sifra))
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

        private void datumMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            MaskedTextBox box = (MaskedTextBox)sender;
            if (box.Text.Equals("  /  /"))
            {
                errorProvider.SetError(box, "Datum nije izabran!");
                formValid = false;
            }
            else
            {
                DateTime dt;
                bool isDateValid = DateTime.TryParseExact(box.Text,
                    "dd/MM/yyyy", CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out dt);
                if (isDateValid)
                {
                    errorProvider.SetError(box, "");
                }
                else
                {
                    errorProvider.SetError(box, "Datum nije ispravno unesen!");
                }
            }
        }

        private void KlimaComboBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox box = (ComboBox)sender;

            if (box.SelectedIndex == -1)
            {
                errorProvider.SetError(box, "Nijedna opcija nije izabrana!");
                formValid = false;
            }
            else
            {
                errorProvider.SetError(box, "");
            }
        }

        private void TipButton_Validating(object sender, CancelEventArgs e)
        {
            Button but = (Button)sender;

            if (tipUnet)
            {
                errorProvider.SetError(but, "");
            }
            else
            {
                errorProvider.SetError(but, "Tip nije izabran");
                formValid = false;
            }
        }
    }
}
