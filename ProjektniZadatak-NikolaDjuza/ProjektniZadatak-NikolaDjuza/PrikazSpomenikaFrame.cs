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
    public partial class PrikazSpomenikaFrame : Form
    {

        public static Spomenik izabranSpomenik = null;
        private static BindingSource sourceEvidencija = null;

        private static BindingList<Spomenik> searchedContentAdvanced;
        public PrikazSpomenikaFrame()
        {
            InitializeComponent();
        }

        private void TabelaSpomenikaFrame_Load(object sender, EventArgs e)
        {
            sourceEvidencija = new BindingSource(MainFrame.evidencijaSpomenika, null);
            spomeniciDataGridView.DataSource = sourceEvidencija;
            searchedContentAdvanced = new BindingList<Spomenik>();

            //spomeniciDataGridView.Columns 2 5 6 7 11
            spomeniciDataGridView.Columns[0].HeaderText = "Sifra spomenika";
            spomeniciDataGridView.Columns[1].HeaderText = "Ime spomenika";
            spomeniciDataGridView.Columns[2].Visible = false;
            spomeniciDataGridView.Columns[3].HeaderText = "Tip";
            spomeniciDataGridView.Columns[4].HeaderText = "Klima";
            spomeniciDataGridView.Columns[5].Visible = false;
            spomeniciDataGridView.Columns[6].Visible = false;
            spomeniciDataGridView.Columns[7].Visible = false;
            spomeniciDataGridView.Columns[8].HeaderText = "Turisticki status";
            spomeniciDataGridView.Columns[9].HeaderText = "Prihod [$]";
            spomeniciDataGridView.Columns[10].Visible = false;
            spomeniciDataGridView.Columns[11].Visible = false;
            spomeniciDataGridView.Columns[12].Visible = false;
            spomeniciDataGridView.Columns[13].Visible = false;

            loadWholeSpomenik();

            EtiketeDataGridView.ClearSelection();
        }

        private void spomeniciDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadWholeSpomenik();
        }

        private void loadWholeSpomenik()
        {
            if (MainFrame.evidencijaSpomenika.Count > 0 && spomeniciDataGridView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = spomeniciDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow row = spomeniciDataGridView.Rows[selectedRowIndex];
                izabranSpomenik = (Spomenik)row.DataBoundItem;

                BindingSource source = new BindingSource(izabranSpomenik.Etikete, null);
                EtiketeDataGridView.DataSource = source;

                EtiketeDataGridView.Columns[1].Visible = false;
                EtiketeDataGridView.Columns[0].HeaderText = "Sifra etikete";
                EtiketeDataGridView.Columns[2].Visible = false;
            }

            if (izabranSpomenik != null)
            {
                IdSpomenikaTextBox.Text = izabranSpomenik.SifraSpomenika;
                ImeSpomenikaTextBox.Text = izabranSpomenik.Ime;
                PrihodTextBox.Text = Convert.ToString(izabranSpomenik.GodisnjiPrihod);
                KlimaComboBox.SelectedIndex = (int)izabranSpomenik.Klima;
                TuristickiStatusComboBox.SelectedIndex = (int)izabranSpomenik.TuristickiStatus;
                OpisSpomenikaTextBox.Text = izabranSpomenik.Opis;
                datumMaskedTextBox.Text = izabranSpomenik.DatumOtkrivanja;
                UgrozeneVrsteCheckBox.Checked = izabranSpomenik.StanisteUgrozenih;
                UgrozenostCheckBox.Checked = izabranSpomenik.EkoloskiUgrozen;
                NaseljenCheckBox.Checked = izabranSpomenik.NaseljenRegion;
                TipSpomenikaTextBox.Text = izabranSpomenik.Tip.ImeTipa;
                if (izabranSpomenik.SlikaSpomenika == null)
                {
                    izabranSpomenik.SlikaSpomenika = izabranSpomenik.Tip.Ikonica;
                }

                SlikaSpomenikaBox.Image = izabranSpomenik.SlikaSpomenika;

                TipSpomenika tip = izabranSpomenik.Tip;

            }
            else
            {
                resetWholeSpomenik();
            }
        }

        private void resetWholeSpomenik()
        {
            IdSpomenikaTextBox.Text = "";
            ImeSpomenikaTextBox.Text = "";
            PrihodTextBox.Text = "";
            KlimaComboBox.SelectedIndex = -1;
            TuristickiStatusComboBox.SelectedIndex = -1;
            OpisSpomenikaTextBox.Text = "";
            datumMaskedTextBox.Text = "";
            UgrozeneVrsteCheckBox.Checked = false;
            UgrozenostCheckBox.Checked = false;
            NaseljenCheckBox.Checked = false;
            TipSpomenikaTextBox.Text = "";

            SlikaSpomenikaBox.Image = Resources._default;

            EtiketeDataGridView.DataSource = null;
            EtiketeDataGridView.Refresh();

        }

        private void IzmeniSpomenikButton_Click(object sender, EventArgs e)
        {
            if (MainFrame.evidencijaSpomenika.Count > 0 && spomeniciDataGridView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = spomeniciDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow row = spomeniciDataGridView.Rows[selectedRowIndex];
                UnosSpomenikFrame.noviSpomenik = (Spomenik)row.DataBoundItem;
                UnosSpomenikFrame.izmenaSpomenika = true;
            }

            UnosSpomenikFrame noviSpomenik = new UnosSpomenikFrame();
            DialogResult r = noviSpomenik.ShowDialog();
            if (r.Equals(DialogResult.OK))
            {
                //MessageBox.Show("Spomenik izmenjen!", "Spomenik izmenjen!",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                spomeniciDataGridView.Refresh();
                loadWholeSpomenik();
            }
            else
            {
                //MessageBox.Show("Spomenik nije izmenjen!",
                //    "Spomenik nije izmenjen!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void izbrisiButton_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Da li želite trajno da obrišete spomenik " + izabranSpomenik.Ime + " ?",
                "Da li želite trajno da obrišete spomenik: " + izabranSpomenik.Ime + " iz evidencije?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (spomeniciDataGridView.SelectedRows.Count > 0 && r.Equals(DialogResult.Yes))
            {
                int selectedRowIndex = spomeniciDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow row = spomeniciDataGridView.Rows[selectedRowIndex];
                Spomenik s = (Spomenik)row.DataBoundItem;

                MainFrame.evidencijaSpomenika.Remove(s);
                spomeniciDataGridView.Refresh();
                loadWholeSpomenik();
            }

            if (spomeniciDataGridView.SelectedRows.Count == 0)
            {
                izabranSpomenik = null;
                loadWholeSpomenik();
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            //sourceEvidencija.Filter = string.Format("SifraSpomenika LIKE '{0}'", filterTextBox.Text);
            //spomeniciDataGridView.Refresh();
            if (searchTextBox.Text.Equals(""))
            {
                spomeniciDataGridView.ClearSelection();
                spomeniciDataGridView.Refresh();

                return;
            }

            BindingList<int> searchedContent = new BindingList<int>();
            foreach (Spomenik s in MainFrame.evidencijaSpomenika)
            {
                if (s.Ime.Contains(searchTextBox.Text))
                {
                    searchedContent.Add(MainFrame.evidencijaSpomenika.IndexOf(s));
                }
            }

            selectRowsInDataGridView(searchedContent);
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            BindingList<Spomenik> filteredContent = new BindingList<Spomenik>();
            foreach (Spomenik s in MainFrame.evidencijaSpomenika)
            {
                if (s.Ime.Contains(filterTextBox.Text))
                {
                    filteredContent.Add(s);
                }
            }

            updateDataGridViewAfterFiltering(filteredContent);
        }

        private void selectRowsInDataGridView(BindingList<int> searchedContent)
        {
            spomeniciDataGridView.ClearSelection();
            if (searchedContent.Count > 0)
            {
                foreach (int i in searchedContent)
                {
                    spomeniciDataGridView.Rows[i].Selected = true;
                }

                spomeniciDataGridView.Refresh();
            }
            else
            {
                spomeniciDataGridView.ClearSelection();
                spomeniciDataGridView.Refresh();
            }
        }

        private void updateDataGridViewAfterFiltering(BindingList<Spomenik> filteredContent)
        {
            sourceEvidencija = new BindingSource(filteredContent, null);
            spomeniciDataGridView.DataSource = sourceEvidencija;
            spomeniciDataGridView.Refresh();
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

        private void EtiketaButton_Click(object sender, EventArgs e)
        {
            UnosEtiketaSpomenikaFrame f = new UnosEtiketaSpomenikaFrame();
            DialogResult r = f.ShowDialog();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            UnosSpomenikFrame novi = new UnosSpomenikFrame();
            UnosSpomenikFrame.izmenaSpomenika = false;
            UnosSpomenikFrame.noviSpomenik = new Spomenik();
            DialogResult r = novi.ShowDialog();
        }

        private void EtiketeDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Etiketa et = (Etiketa)EtiketeDataGridView.Rows[e.RowIndex].DataBoundItem;

                EtiketeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = et.OpisEtikete;
            }
        }

        private void EtiketeDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex != 0)
                return;

            Etiketa et = (Etiketa)EtiketeDataGridView.Rows[e.RowIndex].DataBoundItem;

            e.CellStyle.BackColor = et.BojaEtikete;
            EtiketeDataGridView.ClearSelection();
        }

        private void EtiketeDataGridView_MouseLeave(object sender, EventArgs e)
        {
            EtiketeDataGridView.ClearSelection();
        }

        private void PretragaTextBox_TextChanged(object sender, EventArgs e)
        {
            searchWholeForm();
        }

        private void PretragaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchWholeForm();
        }

        private void ComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            searchWholeForm();
        }

        private void Page_MouseClick(object sender, MouseEventArgs e)
        {
            spomeniciDataGridView.ClearSelection();
        }

        private void searchWholeForm()
        {
            BindingList<int> searchedContent = new BindingList<int>();

            spomeniciDataGridView.ClearSelection();

            String id = sifraPretragaTextBox.Text;
            String ime = imePretragaTextBox.Text;
            Decimal prihod;
            if (prihodPretragaTextBox.Text.Equals(""))
            {
                prihod = -1;
            }
            else
            {
                prihod = Convert.ToDecimal(prihodPretragaTextBox.Text);
            }
            KlimaSpomenika klima = (KlimaSpomenika)klimaPretragaComboBox.SelectedIndex;
            TuristickiStatusSpomenika status = (TuristickiStatusSpomenika)turistickiPretragaComboBox.SelectedIndex;
            String opis = opistPretragaTextBox.Text;
            String datum = datumPretragaTextBox.Text;
            bool ekoloskaUgrozenost = ekUgrozenostPCheckBox.Checked;
            bool stanisteUgrozenih = stanistePCheckBox.Checked;
            bool naseljenoMesto = naseljenoPCheckBox.Checked;
            String imeTipa = imeTipaPretragaTextBox.Text;

            if (id.Equals("") && ime.Equals("") && prihod == -1 && 
                (klimaPretragaComboBox.SelectedIndex == -1
                    || klimaPretragaComboBox.SelectedIndex == 6)
                && (turistickiPretragaComboBox.SelectedIndex == -1
                    || turistickiPretragaComboBox.SelectedIndex == 3) && datum.Equals("  /  /")
                && ekUgrozenostPCheckBox.CheckState == CheckState.Indeterminate
                && stanistePCheckBox.CheckState == CheckState.Indeterminate
                && naseljenoPCheckBox.CheckState == CheckState.Indeterminate
                && imeTipa.Equals(""))
            {
                return;
            }

            foreach (Spomenik s in MainFrame.evidencijaSpomenika)
            {
                if (s.SifraSpomenika.Contains(id) && s.Ime.Contains(ime) &&

                    (s.GodisnjiPrihod.Equals(prihod) || prihod == -1)

                    && (s.Klima.Equals(klima) || klimaPretragaComboBox.SelectedIndex == -1
                    || klimaPretragaComboBox.SelectedIndex == 6)
                    && (s.TuristickiStatus.Equals(status) || turistickiPretragaComboBox.SelectedIndex == -1
                    || turistickiPretragaComboBox.SelectedIndex == 3)
                    && s.Opis.Contains(opis)
                    && (s.DatumOtkrivanja.Equals(datum) || datum.Equals("  /  /"))
                    && (s.EkoloskiUgrozen.Equals(ekoloskaUgrozenost) || ekUgrozenostPCheckBox.CheckState == CheckState.Indeterminate)
                    && (s.StanisteUgrozenih.Equals(stanisteUgrozenih) || stanistePCheckBox.CheckState == CheckState.Indeterminate)
                    && (s.NaseljenRegion.Equals(naseljenoMesto) || naseljenoPCheckBox.CheckState == CheckState.Indeterminate)
                    && s.Tip.ImeTipa.Contains(imeTipa))
                {
                    searchedContent.Add(MainFrame.evidencijaSpomenika.IndexOf(s));
                }
            }

            selectRowsInDataGridView(searchedContent);
        }

        private void filterWholeForm()
        {
            BindingList<Spomenik> filteredContent = new BindingList<Spomenik>();

            spomeniciDataGridView.ClearSelection();

            String id = sifraFilterTextBox.Text;
            String ime = imeFilterTextBox.Text;
            Decimal prihod;
            if (prihodFilterTextBox.Text.Equals(""))
            {
                prihod = -1;
            }
            else
            {
                prihod = Convert.ToDecimal(prihodFilterTextBox.Text);
            }
            KlimaSpomenika klima = (KlimaSpomenika)klimaFilterComboBox.SelectedIndex;
            TuristickiStatusSpomenika status = (TuristickiStatusSpomenika)turistickiFilterComboBox.SelectedIndex;
            String opis = opisFilterTextBox.Text;
            String datum = datumFilterTextBox.Text;
            bool ekoloskaUgrozenost = ekUgroFilterCheckBox.Checked;
            bool stanisteUgrozenih = stanisteFilterCheckBox.Checked;
            bool naseljenoMesto = naseljenoFilterCheckBox.Checked;
            String imeTipa = tipFilterTextBox.Text;

            foreach (Spomenik s in MainFrame.evidencijaSpomenika)
            {
                if (s.SifraSpomenika.Contains(id) && s.Ime.Contains(ime) &&

                    (s.GodisnjiPrihod.Equals(prihod) || prihod == -1)

                    && (s.Klima.Equals(klima) || klimaFilterComboBox.SelectedIndex == -1
                    || klimaPretragaComboBox.SelectedIndex == 6)
                    && (s.TuristickiStatus.Equals(status) || turistickiFilterComboBox.SelectedIndex == -1
                    || turistickiPretragaComboBox.SelectedIndex == 3)
                    && s.Opis.Contains(opis)
                    && (s.DatumOtkrivanja.Equals(datum) || datum.Equals("  /  /"))
                    && (s.EkoloskiUgrozen.Equals(ekoloskaUgrozenost) || ekUgroFilterCheckBox.CheckState == CheckState.Indeterminate)
                    && (s.StanisteUgrozenih.Equals(stanisteUgrozenih) || stanisteFilterCheckBox.CheckState == CheckState.Indeterminate)
                    && (s.NaseljenRegion.Equals(naseljenoMesto) || naseljenoFilterCheckBox.CheckState == CheckState.Indeterminate)
                    && s.Tip.ImeTipa.Contains(imeTipa))
                {
                    filteredContent.Add(s);
                }
            }

            spomeniciDataGridView.ClearSelection();
            updateDataGridViewAfterFiltering(filteredContent);
        }

        private void Filter_TextChanged(object sender, EventArgs e)
        {
            filterWholeForm();
        }

        private void Filter_IndexChanged(object sender, EventArgs e)
        {
            filterWholeForm();
        }

        private void Filter_CheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            filterWholeForm();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0 || tabControl1.SelectedIndex == 1)
            {
                sourceEvidencija = new BindingSource(MainFrame.evidencijaSpomenika, null);
                spomeniciDataGridView.DataSource = sourceEvidencija;
            }
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
            Help.ShowHelp(this, "..\\..\\Resources\\Help.chm", HelpNavigator.Topic, "prikaz_spomenika.htm");
        }
    }
}
