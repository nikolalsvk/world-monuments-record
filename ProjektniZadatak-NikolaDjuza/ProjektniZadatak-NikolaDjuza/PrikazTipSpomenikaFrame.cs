using ProjektniZadatak_NikolaDjuza.Class;
using ProjektniZadatak_NikolaDjuza.Properties;
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
    public partial class PrikazTipSpomenikaFrame : Form
    {
        // da li je korisnik izabrao spomenik
        public static TipSpomenika tipSpomenika = null;
        public static bool samoPrikazi = false;

        public PrikazTipSpomenikaFrame()
        {
            InitializeComponent();

            BindingSource sourcePostojeci = new BindingSource(MainFrame.postojeciTipovi, null);
            postojeciTipoviGridView.DataSource = sourcePostojeci;

            postojeciTipoviGridView.Columns[0].HeaderText = "Šifra tipa";
            postojeciTipoviGridView.Columns[1].HeaderText = "Ime tipa";
            postojeciTipoviGridView.Columns[2].HeaderText = "Opis tipa";
            postojeciTipoviGridView.Columns[3].Visible = false;
            //BindingSource sourceIzabrani = new BindingSource(NoviSpomenikFrame.noviSpomenik.Tip, null);
            //izabranTipGridView.DataSource = sourceIzabrani;

        }


        private void izaberiTipButton_Click(object sender, EventArgs e)
        {
            tipSpomenika = getTipFromDataGridView();

            if (!UnosSpomenikFrame.izmenaSpomenika)
            {
                if (UnosSpomenikFrame.noviSpomenik.Tip == null)
                {
                    UnosSpomenikFrame.noviSpomenik.Tip = new TipSpomenika();
                }
                UnosSpomenikFrame.noviSpomenik.Tip = tipSpomenika;
            }
            else
            {
                UnosSpomenikFrame.noviSpomenik.Tip = tipSpomenika;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private TipSpomenika getTipFromDataGridView()
        {
            if (postojeciTipoviGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = postojeciTipoviGridView.SelectedCells[0].RowIndex;
                DataGridViewRow row = postojeciTipoviGridView.Rows[selectedRowIndex];
                return (TipSpomenika)row.DataBoundItem;
            }
            else
            {
                return null;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tipSpomenika = getTipFromDataGridView();

            if (tipSpomenika != null)
            {
                SifraTipaTextBox.Text = tipSpomenika.SifraTipaSpomenika;
                ImeTipaTextBox.Text = tipSpomenika.ImeTipa;
                OpisTipaTextBox.Text = tipSpomenika.Opis;
                SlikaSpomenikaBox.Image = tipSpomenika.Ikonica;
            }
        }

        private void IzaberiTipSpomenikaFrame_Load(object sender, EventArgs e)
        {
            tipSpomenika = getTipFromDataGridView();

            if (tipSpomenika != null)
            {
                SifraTipaTextBox.Text = tipSpomenika.SifraTipaSpomenika;
                ImeTipaTextBox.Text = tipSpomenika.ImeTipa;
                OpisTipaTextBox.Text = tipSpomenika.Opis;
                SlikaSpomenikaBox.Image = tipSpomenika.Ikonica;
            }

            if (samoPrikazi)
            {
                izaberiTipButton.Enabled = false;
            }
            else
            {
                IzmeniSpomenikButton.Enabled = false;
                dodajButton.Enabled = false;
                izbrisiButton.Enabled = false;
            }
        }

        private void NazadButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void postojeciTipoviGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tipSpomenika = getTipFromDataGridView();

            if (!samoPrikazi)
            {
                if (!UnosSpomenikFrame.izmenaSpomenika)
                {
                    if (UnosSpomenikFrame.noviSpomenik.Tip == null)
                    {
                        UnosSpomenikFrame.noviSpomenik.Tip = new TipSpomenika();
                    }
                    UnosSpomenikFrame.noviSpomenik.Tip = tipSpomenika;
                }
                else
                {
                    UnosSpomenikFrame.noviSpomenik.Tip = tipSpomenika;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void resetWholeTip()
        {
            SifraTipaTextBox.Text = "";
            ImeTipaTextBox.Text = "";
            OpisTipaTextBox.Text = "";
            SlikaSpomenikaBox.Image = Resources._default;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            String dialogText = "Da li ste sigurni da želite da izbrište tip " + ImeTipaTextBox.Text + "?";
            String spomenici = "";
            int brojSpomenika = 0;

            foreach (Spomenik s in MainFrame.evidencijaSpomenika)
            {
                if (s.Tip.SifraTipaSpomenika.Equals(tipSpomenika.SifraTipaSpomenika))
                {
                    if (brojSpomenika == 0)
                    {
                        spomenici += s.Ime;
                    }
                    else
                    {
                        spomenici += ", " + s.Ime;
                    }
                    brojSpomenika++;
                }
            }

            if (brojSpomenika > 0)
            {

                dialogText += " Brisanje ovog tipa će prouzrokovati brisanje spomenika: ";
                dialogText += spomenici + ".";
            }
            else
            {
                dialogText += " Ovaj tip nije povezan ni sa jednim spomenikom!";
            }

            DialogResult r = MessageBox.Show(dialogText,
                "Brisanje tipa spomenika i svih spomenika tog tipa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            BindingList<Spomenik> temp = MainFrame.evidencijaSpomenika;
            if (r.Equals(DialogResult.Yes))
            {
                // mora unazad da ide da bi se sve obrisalo, fucking C#
                for (int i = temp.Count - 1; i > -1; i--)
                {
                    if (temp[i].Tip.SifraTipaSpomenika
                        .Equals(tipSpomenika.SifraTipaSpomenika))
                    {
                        MainFrame.evidencijaSpomenika.Remove(temp[i]);
                    }
                }
                MainFrame.postojeciTipovi.Remove(tipSpomenika);
                resetWholeTip();
            }
        }

        private void IzmeniSpomenikButton_Click(object sender, EventArgs e)
        {
            UnosTipSpomenikaFrame unosFrame = new UnosTipSpomenikaFrame();
            UnosTipSpomenikaFrame.izmenaTipa = true;
            UnosTipSpomenikaFrame.tip = tipSpomenika;

            DialogResult r = unosFrame.ShowDialog();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            UnosTipSpomenikaFrame unosFrame = new UnosTipSpomenikaFrame();
            UnosTipSpomenikaFrame.izmenaTipa = false;
            UnosTipSpomenikaFrame.tip = new TipSpomenika();

            DialogResult r = unosFrame.ShowDialog();
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
            Help.ShowHelp(this, "..\\..\\Resources\\Help.chm", HelpNavigator.Topic, "prikaz_tipova.htm");
        }

        private void PrikazTipSpomenikaFrame_Activated(object sender, EventArgs e)
        {
            tipSpomenika = getTipFromDataGridView();

            if (tipSpomenika != null)
            {
                SifraTipaTextBox.Text = tipSpomenika.SifraTipaSpomenika;
                ImeTipaTextBox.Text = tipSpomenika.ImeTipa;
                OpisTipaTextBox.Text = tipSpomenika.Opis;
                SlikaSpomenikaBox.Image = tipSpomenika.Ikonica;
            }
            else
            {
                resetWholeTip();
            }
        }
    }
}
