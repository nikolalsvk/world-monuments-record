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
    public partial class PrikazEtiketaSpomenikaFrame : Form
    {
        public static Etiketa izabranaEtiketa;
        public PrikazEtiketaSpomenikaFrame()
        {
            InitializeComponent();

            BindingSource sourcePostojece = new BindingSource(MainFrame.postojeceEtikete, null);
            postojeceEtiketeDataGridView.DataSource = sourcePostojece;


        }

        private void postojeceEtiketeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (postojeceEtiketeDataGridView.SelectedRows.Count > 0)
            {
                izabranaEtiketa = (Etiketa)postojeceEtiketeDataGridView.Rows[e.RowIndex].DataBoundItem;

                sifraEtiketeTextBox.Text = izabranaEtiketa.SifraEtikete;
                opisEiketeTextBox.Text = izabranaEtiketa.OpisEtikete;
                BojaButton.BackColor = izabranaEtiketa.BojaEtikete;
            }
        }

        private void resetWholeEtiketa()
        {
            sifraEtiketeTextBox.Text = "";
            opisEiketeTextBox.Text = "";
            BojaButton.BackColor = SystemColors.Control;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void postojeceEtiketeDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex != 0)
                return;

            Etiketa et = (Etiketa)postojeceEtiketeDataGridView.Rows[e.RowIndex].DataBoundItem;

            e.CellStyle.BackColor = et.BojaEtikete;
        }

        private void PrikazEtiketaSpomenikaFrame_Load(object sender, EventArgs e)
        {
            if (postojeceEtiketeDataGridView.SelectedRows.Count > 0)
            {
                izabranaEtiketa = (Etiketa)postojeceEtiketeDataGridView.SelectedRows[0].DataBoundItem;

                sifraEtiketeTextBox.Text = izabranaEtiketa.SifraEtikete;
                opisEiketeTextBox.Text = izabranaEtiketa.OpisEtikete;
                BojaButton.BackColor = izabranaEtiketa.BojaEtikete;
            }

            postojeceEtiketeDataGridView.Columns[0].HeaderText = "Šifra etikete";
            postojeceEtiketeDataGridView.Columns[1].Visible = false;
            postojeceEtiketeDataGridView.Columns[2].HeaderText = "Opis etikete";
        }


        private void izbrisiButton_Click(object sender, EventArgs e)
        {

            if (postojeceEtiketeDataGridView.Rows.Count > 0)
            {
                Etiketa et = (Etiketa)postojeceEtiketeDataGridView.SelectedRows[0].DataBoundItem;

                String dialogText = "Da li želite da obrišete etiketu sa šifrom " + et.SifraEtikete + " iz evidencije?";

                String spomenici = "";
                int brojSpomenika = 0;
                foreach (Spomenik s in MainFrame.evidencijaSpomenika)
                {
                    foreach (Etiketa etiketa in s.Etikete)
                    {
                        if (etiketa.SifraEtikete.Equals(et.SifraEtikete))
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
                            break;
                        }
                    }
                }

                if (brojSpomenika > 0)
                {
                    dialogText += " Etiketa će takođe biti obrisana iz spomenika: " + spomenici + ".";
                }
                else
                {
                    dialogText += " Etiketa nije vezana ni za jedan spomenik!";
                }

                DialogResult r = MessageBox.Show(dialogText,
                    "Brisanje etikete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r.Equals(DialogResult.Yes))
                {
                    MainFrame.postojeceEtikete.Remove(et);

                    foreach (Spomenik s in MainFrame.evidencijaSpomenika)
                    {
                        foreach (Etiketa etiketa in s.Etikete)
                        {
                            if (etiketa.SifraEtikete.Equals(et.SifraEtikete))
                            {
                                s.Etikete.Remove(etiketa);
                                break;
                            }
                        }
                    }
                    resetWholeEtiketa();
                    postojeceEtiketeDataGridView.ClearSelection();
                }
            }
            postojeceEtiketeDataGridView.Refresh();
            
        }

        private void izmeniButton_Click(object sender, EventArgs e)
        {
            UnosEtiketaSpomenikaFrame unosFrame = new UnosEtiketaSpomenikaFrame();
            UnosEtiketaSpomenikaFrame.et = izabranaEtiketa;
            UnosEtiketaSpomenikaFrame.izmenaEtikete = true;

            DialogResult r = unosFrame.ShowDialog();
        }

        private void dodajEtiketuButton_Click(object sender, EventArgs e)
        {
            UnosEtiketaSpomenikaFrame unosFrame = new UnosEtiketaSpomenikaFrame();
            UnosEtiketaSpomenikaFrame.et = new Etiketa();
            UnosEtiketaSpomenikaFrame.izmenaEtikete = false;

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
            Help.ShowHelp(this, "..\\..\\Resources\\Help.chm", HelpNavigator.Topic, "prikaz_etiketa.htm");
        }

        private void PrikazEtiketaSpomenikaFrame_Activated(object sender, EventArgs e)
        {
            if (postojeceEtiketeDataGridView.SelectedRows.Count > 0)
            {
                izabranaEtiketa = (Etiketa)postojeceEtiketeDataGridView.SelectedRows[0].DataBoundItem;

                sifraEtiketeTextBox.Text = izabranaEtiketa.SifraEtikete;
                opisEiketeTextBox.Text = izabranaEtiketa.OpisEtikete;
                BojaButton.BackColor = izabranaEtiketa.BojaEtikete;
            }
            else
            {

                resetWholeEtiketa();
            }
        }
    }
}
