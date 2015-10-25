using ProjektniZadatak_NikolaDjuza.Class;
using ProjektniZadatak_NikolaDjuza.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektniZadatak_NikolaDjuza
{
    // TODO 2. Poraditi na slici spomenika, kad se brise da li se preuzima slika tipa itd.
    // TODO 3. Da li se refreshuje stablo i slike u stablu prilikom povratka u MainFrame
    public partial class MainFrame : Form
    {
        public static String TIP = "tip";

        public static BindingList<TipSpomenika> postojeciTipovi;
        public static BindingList<Etiketa> postojeceEtikete;
        public static BindingList<Spomenik> evidencijaSpomenika;
        private static TreeNode draggedLeaf;
        private static Rectangle mouseDownSelectionWindow;
        private static Point offsetEkrana;

        private static ContextMenu markerContextMenu;
        private static ContextMenuStrip spomenikContextMenu;
        //private static ContextMenu tipSpomenikaContextMenu;

        private static ToolTip markerToolTip;

        private static BindingList<PictureBox> pbList;

        public static bool tutorijalMode;
        public static int tutorijalStep;

        public MainFrame()
        {
            InitializeComponent();

            // tipovi
            postojeciTipovi = new BindingList<TipSpomenika>();
            postojeciTipovi.Add(new TipSpomenika("1", "Neolitski", "Veoma star", global::ProjektniZadatak_NikolaDjuza.Properties.Resources._default));
            postojeciTipovi.Add(new TipSpomenika("2", "Srednje-vekovni", "Odlicno asdasdasdasd\nsacuvan", global::ProjektniZadatak_NikolaDjuza.Properties.Resources._default));
            postojeciTipovi.Add(new TipSpomenika("3", "Moderni", "Naucno znacajan", global::ProjektniZadatak_NikolaDjuza.Properties.Resources.plus_empty));

            // etikete
            postojeceEtikete = new BindingList<Etiketa>();
            postojeceEtikete.Add(new Etiketa("1", Color.Blue, "Super"));
            postojeceEtikete.Add(new Etiketa("2", Color.Red, "Friendly"));
            postojeceEtikete.Add(new Etiketa("3", Color.BlueViolet, "Nice"));

            evidencijaSpomenika = new BindingList<Spomenik>();

            pbList = new BindingList<PictureBox>();

            // ucitavanje default fajla sa evidencijom spomenika
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"spomenici.bin");
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                BinaryFormatter bFormatter = new BinaryFormatter();
                evidencijaSpomenika = (BindingList<Spomenik>)bFormatter.Deserialize(stream);
                stream.Close();
            }

            path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"tipovi.bin");
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                BinaryFormatter bFormatter = new BinaryFormatter();
                postojeciTipovi = (BindingList<TipSpomenika>)bFormatter.Deserialize(stream);
                stream.Close();
            }

            path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"etikete.bin");
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                BinaryFormatter bFormatter = new BinaryFormatter();
                postojeceEtikete = (BindingList<Etiketa>)bFormatter.Deserialize(stream);
                stream.Close();
            }

            ImageList treeViewImageList = new ImageList();
            spomeniciTreeView.ImageList = treeViewImageList;

            // ucitavanje sadrzaja u treeView
            ucitajTipoveUTreeView();
            spomeniciTreeView.ExpandAll();

            mouseDownSelectionWindow = Rectangle.Empty;

            // kontekstni meni markera
            markerContextMenu = new ContextMenu();
            MenuItem obrisiMarker = new MenuItem("Obriši spomenik sa mape");
            MenuItem izmeniMarker = new MenuItem("Izmeni spomenik");

            obrisiMarker.Click += obrisiMarker_Click;
            izmeniMarker.Click += izmeniMarker_Click;

            markerContextMenu.MenuItems.Add(obrisiMarker);
            markerContextMenu.MenuItems.Add(izmeniMarker);

            // kontekstni meni lista u stablu
            spomenikContextMenu = new ContextMenuStrip();


            // iscrtavanje markera na mapi
            iscrtajMarkereNaMapi();
        }

        private void iscrtajMarkereNaMapi()
        {
            offsetEkrana = SystemInformation.WorkingArea.Location;
            for (int i = 0; i < evidencijaSpomenika.Count; i++)
            {
                if (evidencijaSpomenika[i].SpomenikPostavljenNaMapu)
                {
                    Spomenik s = evidencijaSpomenika[i];
                    PictureBox pb = setMarkerPoint(evidencijaSpomenika[i].PozicijaNaMapi);
                    mapPanel.Controls.Add(pb);
                    pb.BringToFront();

                    // setovanje PictureBox taga
                    TreeNode root = findRoot(s.Tip.ImeTipa);
                    foreach (TreeNode node in root.Nodes)
                    {
                        if (((Spomenik)node.Tag).SifraSpomenika.Equals(s.SifraSpomenika))
                        {
                            node.Tag = s;
                            pb.Tag = node;
                        }
                    }
                }
            }
        }

        void obrisiSpomenik_Click(object sender, EventArgs e)
        {

        }

        // izmena markera na mapi
        void izmeniMarker_Click(object sender, EventArgs e)
        {
            if (tutorijalMode)
            {
                return;
            }
            PictureBox pb = (PictureBox)markerContextMenu.SourceControl;
            TreeNode t = (TreeNode)pb.Tag;
            Spomenik s = (Spomenik)t.Tag;
            int indexSpomenikaUEvidenciji = -1;

            for (int i = 0; i < evidencijaSpomenika.Count; i++)
            {
                if (s.Ime.Equals(evidencijaSpomenika[i].Ime))
                {
                    indexSpomenikaUEvidenciji = i;
                    break;
                }
            }

            UnosSpomenikFrame noviSpomenik = new UnosSpomenikFrame();
            UnosSpomenikFrame.noviSpomenik = s;
            UnosSpomenikFrame.izmenaSpomenika = true;
            DialogResult r = noviSpomenik.ShowDialog();

            s = evidencijaSpomenika[indexSpomenikaUEvidenciji];
            TreeNode root = findRoot(s.Tip.ImeTipa);
            for (int i = 0; i < root.Nodes.Count; i++)
            {
                if (((Spomenik)root.Nodes[i].Tag).SifraSpomenika.Equals(s.SifraSpomenika))
                {
                    root.Nodes[i].Tag = s;
                    root.Nodes[i].Text = s.Ime;
                    // brisanje prethodne slika iz ImageList-a i dodavanje nove
                    spomeniciTreeView.ImageList.Images.RemoveByKey(s.SifraSpomenika);
                    spomeniciTreeView.ImageList.Images.Add(s.SifraSpomenika, s.SlikaSpomenika);
                    root.Nodes[i].SelectedImageIndex = spomeniciTreeView.ImageList.Images.IndexOfKey(s.SifraSpomenika);
                    root.Nodes[i].ImageIndex = spomeniciTreeView.ImageList.Images.IndexOfKey(s.SifraSpomenika);
                }
            }
            //spomeniciTreeView.ExpandAll();
            loadWholeSpomenik(s);
        }

        void obrisiMarker_Click(object sender, EventArgs e)
        {
            if (tutorijalMode && tutorijalStep != 3)
            {
                return;
            }
            PictureBox pb = (PictureBox)markerContextMenu.SourceControl;
            TreeNode t = (TreeNode)pb.Tag;
            t.BackColor = Color.White;
            Spomenik s = (Spomenik)t.Tag;
            if (!tutorijalMode)
            {
                s.PozicijaNaMapi = Point.Empty;
            }
            s.SpomenikPostavljenNaMapu = false;

            updateEvidencijaSpomenika(s);

            pb.Dispose();
            pbList.Remove(pb);

            resetWholeSpomenik();
            if (!tutorijalMode)
            {
                ucitajTipoveUTreeView();
            }
            else
            {
                if (tutorijalStep == 3)
                {
                    tutorijalStep = 4;
                    tutorijalTextBox.Text = "Svaka čast! Upravo znate kako da manipulišete spomenikom na mapi!"
                                        + " Kliknite na \"Završi tutorijal\"";
                }

            }
            spomeniciTreeView.SelectedNode = null;
        }

        private void ucitajSlikeUTreeView()
        {
            TreeNode root = null;
            for (int i = 0; i < evidencijaSpomenika.Count; i++)
            {
                root = findRoot(evidencijaSpomenika[i].Tip.ImeTipa);
                root.ImageIndex = spomeniciTreeView.ImageList.Images.IndexOfKey(
                    evidencijaSpomenika[i].Tip.SifraTipaSpomenika + TIP);
                root.SelectedImageIndex = spomeniciTreeView.ImageList.Images.IndexOfKey(
                    evidencijaSpomenika[i].Tip.SifraTipaSpomenika + TIP);
                if (root != null)
                {
                    for (int j = 0; j < root.Nodes.Count; j++)
                    {
                        if (((Spomenik)root.Nodes[j].Tag).SifraSpomenika.
                            Equals(evidencijaSpomenika[i].SifraSpomenika))
                        {
                            //while (spomeniciTreeView.ImageList.Images.ContainsKey(evidencijaSpomenika[i].SifraSpomenika))
                            //{
                            //    spomeniciTreeView.ImageList.Images.RemoveByKey(evidencijaSpomenika[i].SifraSpomenika);
                            //}
                            // dodavanje slike u ImageList sa sifrom kao kljucem
                            spomeniciTreeView.ImageList.Images.Add(evidencijaSpomenika[i].SifraSpomenika
                                , evidencijaSpomenika[i].SlikaSpomenika);
                            // setovanje indexa slike za TreeNode
                            root.Nodes[j].ImageIndex = spomeniciTreeView.ImageList.Images.IndexOfKey(
                                evidencijaSpomenika[i].SifraSpomenika);
                            root.Nodes[j].SelectedImageIndex = spomeniciTreeView.ImageList.Images.IndexOfKey(
                                evidencijaSpomenika[i].SifraSpomenika);
                            break;
                        }
                    }
                }
                spomeniciTreeView.ExpandAll();
            }
        }

        private void ucitajTipoveUTreeView()
        {
            spomeniciTreeView.Nodes.Clear();
            // dodavanje tipova u treeView
            for (int i = 0; i < postojeciTipovi.Count; i++)
            {
                TreeNode root = new TreeNode(postojeciTipovi[i].ImeTipa);
                root.Tag = postojeciTipovi[i];

                spomeniciTreeView.ImageList.Images.Add(postojeciTipovi[i].SifraTipaSpomenika + TIP
                    , postojeciTipovi[i].Ikonica);
                root.ImageIndex = spomeniciTreeView.ImageList.Images.IndexOfKey(
                    postojeciTipovi[i].SifraTipaSpomenika + TIP);
                root.SelectedImageIndex = spomeniciTreeView.ImageList.Images.IndexOfKey(
                    postojeciTipovi[i].SifraTipaSpomenika + TIP);

                spomeniciTreeView.Nodes.Add(root);
            }

            ucitajSpomenikeUTreeView();
        }

        private void ucitajSpomenikeUTreeView()
        {
            TreeNode root = null;
            TreeNode newLeaf = null;

            if (evidencijaSpomenika != null)
            {
                for (int i = 0; i < evidencijaSpomenika.Count; i++)
                {
                    root = findRoot(evidencijaSpomenika[i].Tip.ImeTipa);
                    if (root != null)
                    {
                        newLeaf = new TreeNode(evidencijaSpomenika[i].Ime);
                        newLeaf.Tag = evidencijaSpomenika[i];
                        if (evidencijaSpomenika[i].SpomenikPostavljenNaMapu)
                        {
                            newLeaf.BackColor = Color.AntiqueWhite;
                        }
                        else
                        {
                            newLeaf.BackColor = Color.White;
                        }
                        root.Nodes.Add(newLeaf);
                    }
                }
            }

            ucitajSlikeUTreeView();
        }

        private TreeNode findRoot(string nazivTipa)
        {
            TreeNode root = null;
            for (int i = 0; i < spomeniciTreeView.Nodes.Count; i++)
            {
                if (spomeniciTreeView.Nodes[i].Text == nazivTipa)
                {
                    root = spomeniciTreeView.Nodes[i];
                    break;
                }
            }
            return root;
        }

        private void loadWholeSpomenik(Spomenik izabranSpomenik)
        {
            if (MainFrame.evidencijaSpomenika.Count > 0)
            {
                BindingSource source = new BindingSource(izabranSpomenik.Etikete, null);
                EtiketeDataGridView.DataSource = source;

                EtiketeDataGridView.Columns[1].Visible = false;
                EtiketeDataGridView.Columns[0].HeaderText = "Sifra etikete";
                EtiketeDataGridView.Columns[2].Visible = false;
                EtiketeDataGridView.ClearSelection();
            }

            if (izabranSpomenik != null)
            {
                IdSpomenikaTextBox.Text = izabranSpomenik.SifraSpomenika;
                ImeSpomenikaTextBox.Text = izabranSpomenik.Ime;
                //PrihodTextBox.Text = Convert.ToString(izabranSpomenik.GodisnjiPrihod);
                KlimaComboBox.SelectedIndex = (int)izabranSpomenik.Klima;
                TuristickiStatusComboBox.SelectedIndex = (int)izabranSpomenik.TuristickiStatus;
                //OpisSpomenikaTextBox.Text = izabranSpomenik.Opis;
                //datumMaskedTextBox.Text = izabranSpomenik.DatumOtkrivanja;
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
            //PrihodTextBox.Text = "";
            KlimaComboBox.SelectedIndex = -1;
            TuristickiStatusComboBox.SelectedIndex = -1;
            //OpisSpomenikaTextBox.Text = "";
            //datumMaskedTextBox.Text = "";
            UgrozeneVrsteCheckBox.Checked = false;
            UgrozenostCheckBox.Checked = false;
            NaseljenCheckBox.Checked = false;
            TipSpomenikaTextBox.Text = "";

            SlikaSpomenikaBox.Image = Resources._default;

            EtiketeDataGridView.DataSource = null;
            EtiketeDataGridView.Refresh();

        }

        private void unosNovogSpomenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosSpomenikFrame.noviSpomenik = new Spomenik();
            UnosSpomenikFrame noviSpomenikFrame = new UnosSpomenikFrame();
            UnosSpomenikFrame.izmenaSpomenika = false;
            DialogResult r = noviSpomenikFrame.ShowDialog();
            if (r.Equals(DialogResult.OK))
            {
                Spomenik novi = evidencijaSpomenika.Last();
                TreeNode root = findRoot(novi.Tip.ImeTipa);
                TreeNode newLeaf = root.Nodes.Add(novi.Ime);
                newLeaf.Tag = novi;
                spomeniciTreeView.ExpandAll();
            }
            else
            {

            }
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alfa verzija\n\rBuild 1.0.0.0", "Info", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void prikazSpomenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikazSpomenikaFrame tabela = new PrikazSpomenikaFrame();
            DialogResult r = tabela.ShowDialog();
            if (r.Equals(DialogResult.OK))
            {

            }
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            ToolTip sledeciStepTip = new ToolTip();
            sledeciStepTip.SetToolTip(previousStepButton, "Klikom se vraćate na prethodni korak tutorijala.");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void izmenaSpomenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Binary File (*.bin)|*.bin";
            saveDialog.Title = "Sacuvajte spomenike";
            DialogResult r = saveDialog.ShowDialog();

            if (r.Equals(DialogResult.OK))
            {
                using (Stream stream = File.Open(saveDialog.FileName, FileMode.Create))
                {
                    BinaryFormatter bFormatter = new BinaryFormatter();
                    bFormatter.Serialize(stream, evidencijaSpomenika);
                    stream.Close();
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Binary File (*.bin)|*.bin";
            openDialog.Title = "Ucitavanje fajla sa spomenicima";
            DialogResult r = openDialog.ShowDialog();

            if (r.Equals(DialogResult.OK))
            {
                using (Stream stream = File.Open(openDialog.FileName, FileMode.Open))
                {
                    BinaryFormatter bFormatter = new BinaryFormatter();
                    evidencijaSpomenika = (BindingList<Spomenik>)bFormatter.Deserialize(stream);
                    stream.Close();
                }
            }
        }

        public static TipSpomenika getTipFromDataGridView(DataGridView dgw)
        {
            int selectedRowIndex = dgw.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgw.Rows[selectedRowIndex];
            return (TipSpomenika)row.DataBoundItem;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void unosTipovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosTipSpomenikaFrame unosTip = new UnosTipSpomenikaFrame();
            for (int i = 0; i < postojeciTipovi.Count; i++)
            {
                spomeniciTreeView.ImageList.Images.RemoveByKey(postojeciTipovi[i].SifraTipaSpomenika + TIP);
                spomeniciTreeView.ImageList.Images.Add(postojeciTipovi[i].SifraTipaSpomenika + TIP,
                    postojeciTipovi[i].Ikonica);
            }
            ucitajTipoveUTreeView();
            DialogResult r = unosTip.ShowDialog();
        }

        private void prikazTipovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikazTipSpomenikaFrame.samoPrikazi = true;
            PrikazTipSpomenikaFrame prikaziTip = new PrikazTipSpomenikaFrame();

            DialogResult r = prikaziTip.ShowDialog();
            PrikazTipSpomenikaFrame.samoPrikazi = false;
        }

        private void unosEtiketaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosEtiketaSpomenikaFrame unosEtiketa = new UnosEtiketaSpomenikaFrame();
            DialogResult r = unosEtiketa.ShowDialog();
        }

        private void prikazEtiketaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikazEtiketaSpomenikaFrame prikazEtiketa = new PrikazEtiketaSpomenikaFrame();
            DialogResult r = prikazEtiketa.ShowDialog();
        }

        private void spomeniciTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count == 0 && e.Node.Tag != null && e.Node.Tag is Spomenik)
            {
                if (tutorijalMode)
                {
                    if (e.Node == spomeniciTreeView.Nodes[0].Nodes[0])
                    {
                        Spomenik izabranSpomenik = (Spomenik)e.Node.Tag;
                        loadWholeSpomenik(izabranSpomenik);
                        for (int i = 0; i < pbList.Count; i++)
                        {
                            if (((Spomenik)((TreeNode)pbList[i].Tag).Tag).SifraSpomenika.
                                Equals(izabranSpomenik.SifraSpomenika))
                            {
                                pbList[i].BringToFront();

                                deselectMapMarkers();

                                pbList[i].BorderStyle = BorderStyle.Fixed3D;

                                if (tutorijalStep == 1)
                                {
                                    tutorijalStep = 2;
                                    tutorijalTextBox.Text = "Savršeno! Ako pređete mišem preko spomenika na mapi"
                                        + " pojaviće se detalji o spomeniku.";
                                }

                                return;
                            }
                        }

                        deselectMapMarkers();
                    }
                }
                else
                {
                    Spomenik izabranSpomenik = (Spomenik)e.Node.Tag;
                    loadWholeSpomenik(izabranSpomenik);
                    for (int i = 0; i < pbList.Count; i++)
                    {
                        if (((Spomenik)((TreeNode)pbList[i].Tag).Tag).SifraSpomenika.
                            Equals(izabranSpomenik.SifraSpomenika))
                        {
                            pbList[i].BringToFront();

                            deselectMapMarkers();

                            pbList[i].BorderStyle = BorderStyle.Fixed3D;

                            return;
                        }
                    }

                    deselectMapMarkers();
                }
            }
        }

        private void spomeniciTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            draggedLeaf = spomeniciTreeView.GetNodeAt(e.Location);
            if (draggedLeaf != null && draggedLeaf.Tag is Spomenik)
            {
                spomeniciTreeView.SelectedNode = draggedLeaf;
                if (tutorijalMode)
                {
                    if (draggedLeaf.GetNodeCount(true) == 0 && !((Spomenik)draggedLeaf.Tag).SpomenikPostavljenNaMapu
                        && tutorijalStep == 0 && draggedLeaf == spomeniciTreeView.Nodes[0].Nodes[0])
                    {
                        Size dragSize = SystemInformation.DragSize;
                        mouseDownSelectionWindow = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                    }
                }
                else
                {
                    if (draggedLeaf.GetNodeCount(true) == 0 && !((Spomenik)draggedLeaf.Tag).SpomenikPostavljenNaMapu)
                    {
                        Size dragSize = SystemInformation.DragSize;
                        mouseDownSelectionWindow = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                    }
                    else
                    {
                        mouseDownSelectionWindow = Rectangle.Empty;
                    }
                }
            }
        }

        private void spomeniciTreeView_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && draggedLeaf != null)
            {
                if ((mouseDownSelectionWindow != Rectangle.Empty) && (!mouseDownSelectionWindow.Contains(e.X, e.Y)))
                {
                    offsetEkrana = SystemInformation.WorkingArea.Location;
                    DragDropEffects dropEffect = spomeniciTreeView.DoDragDrop(draggedLeaf, DragDropEffects.Copy);
                }
            }
        }

        private void mapPanel_DragEnter(object sender, DragEventArgs e)
        {
            Type testTip = new TreeNode().GetType();

            //PictureBox pictureb = (PictureBox)((Panel)sender).GetChildAtPoint(new Point(e.X, e.Y));
            //if (pictureb != null)
            //{
            //    e.Effect = DragDropEffects.None;
            //}
            //pictureb = (PictureBox)((Panel)sender).GetChildAtPoint(new Point(e.X + 15, e.Y));
            //if (pictureb != null)
            //{
            //    e.Effect = DragDropEffects.None;
            //}
            //pictureb = (PictureBox)((Panel)sender).GetChildAtPoint(new Point(e.X - 45, e.Y));
            //if (pictureb != null)
            //{
            //    e.Effect = DragDropEffects.None;
            //}
            //pictureb = (PictureBox)((Panel)sender).GetChildAtPoint(new Point(e.X, e.Y));
            //if (pictureb != null)
            //{
            //    e.Effect = DragDropEffects.None;
            //}
            //pictureb = (PictureBox)((Panel)sender).GetChildAtPoint(new Point(e.X, e.Y - 60));

            //if (pictureb != null)
            //{
            //    e.Effect = DragDropEffects.None;
            //}

            if ((e.Data.GetDataPresent(testTip)) && (((Panel)sender).Tag == null))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void mapPanel_DragDrop(object sender, DragEventArgs e)
        {
            Type testTip = new TreeNode().GetType();
            TreeNode movedLeaf;
            mouseDownSelectionWindow = Rectangle.Empty;


            if (e.Data.GetDataPresent(testTip))
            {
                movedLeaf = (TreeNode)e.Data.GetData(testTip);
                Spomenik s = (Spomenik)movedLeaf.Tag;
                Point point = mapPanel.PointToClient(new Point(e.X - 15, e.Y - 30));

                PictureBox pb = setMarkerPoint(point);

                pb.Tag = movedLeaf;

                movedLeaf.BackColor = Color.AntiqueWhite;

                s.PozicijaNaMapi = pb.Location;
                s.SpomenikPostavljenNaMapu = true;

                if (!tutorijalMode)
                {
                    updateEvidencijaSpomenika(s);
                }
                else
                {
                    tutorijalStep = 1;
                    previousStepButton.Enabled = true;
                    spomeniciTreeView.SelectedNode = null;
                    pbxRight.Visible = false;
                    tutorijalTextBox.Text = "Odlično! Spomenik je postavljen na mapu. Ako kliknete na isti spomenik u stablu"
                        + " isti će se selektovati na mapi.";
                }
                movedLeaf.Tag = s;

                mapPanel.Controls.Add(pb);
                pb.BringToFront();
            }
        }

        private PictureBox setMarkerPoint(Point point)
        {
            PictureBox pb = new PictureBox();
            pb.Image = Resources.google_maps_marker_for_residencelamontagne_hi;
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Size = new Size(30, 30);
            pb.Location = point;
            pb.MouseEnter += markerImageBox_MouseEnter;
            pb.Click += markerImageBox_Click;
            pb.MouseDown += pb_MouseDown;
            pb.DragEnter += pb_DragEnter;
            pb.DragOver += pb_DragOver;
            ((Control)pb).AllowDrop = true;
            pb.ContextMenu = markerContextMenu;
            pbList.Add(pb);

            return pb;
        }

        void pb_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        void pb_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        bool mouseRightClick = false;

        void pb_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                mouseRightClick = true;
            }
            else
            {
                mouseRightClick = false;
            }
        }

        private void markerImageBox_MouseEnter(object sender, EventArgs e)
        {
            markerToolTip = new ToolTip();
            PictureBox pb = (PictureBox)sender;
            TreeNode leaf = (TreeNode)pb.Tag;
            Spomenik s = (Spomenik)leaf.Tag;

            markerToolTip.SetToolTip((PictureBox)sender, "Ime spomenika: " + s.Ime +
                "\nOpis: " + s.Opis);

            if (tutorijalMode && tutorijalStep == 2)
            {
                tutorijalStep = 3;
                tutorijalTextBox.Text = "Savršeno! Spomenik možete ukloniti sa mape ako kliknete"
                                        + " desni klik na spomenik na mapi i kliknete na obriši spomenik sa mape.";
            }
        }

        private void markerImageBox_Click(object sender, EventArgs e)
        {
            if (mouseRightClick)
            {
                mouseRightClick = false;
                return;
            }

            PictureBox pb = (PictureBox)sender;
            TreeNode leaf = (TreeNode)pb.Tag;

            TreeNode root = findRoot(((Spomenik)leaf.Tag).Tip.ImeTipa);
            for (int i = 0; i < root.Nodes.Count; i++)
            {
                if (root.Nodes[i].Tag is Spomenik)
                {
                    if (((Spomenik)root.Nodes[i].Tag).SifraSpomenika
                        .Equals(((Spomenik)leaf.Tag).SifraSpomenika))
                    {
                        spomeniciTreeView.SelectedNode = root.Nodes[i];
                        break;
                    }
                }
            }

            loadWholeSpomenik((Spomenik)leaf.Tag);
            pb.BringToFront();

            deselectMapMarkers();

            pb.BorderStyle = BorderStyle.Fixed3D;

            return;
        }

        private void markerImageBox_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void updateEvidencijaSpomenika(Spomenik s)
        {
            for (int i = 0; i < evidencijaSpomenika.Count; i++)
            {
                if (evidencijaSpomenika[i].Ime.Equals(s.Ime))
                {
                    evidencijaSpomenika[i] = s;
                    break;
                }
            }
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

        private void EtiketeDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex != 0)
                return;

            DataGridView dg = (DataGridView)sender;

            Etiketa et = (Etiketa)dg.Rows[e.RowIndex].DataBoundItem;

            e.CellStyle.BackColor = et.BojaEtikete;
        }

        private void MainFrame_Activated(object sender, EventArgs e)
        {
            if (tutorijalMode)
            {
                if (tutorijalStep == 0)
                {
                    previousStepButton.Enabled = false;
                }
                else
                {
                    previousStepButton.Enabled = true;
                }
            }
            else
            {
                ucitajTipoveUTreeView();
                spomeniciTreeView.ExpandAll();
            }
        }

        private void mapPanel_Click(object sender, EventArgs e)
        {
            deselectMapMarkers();
        }

        private void deselectMapMarkers()
        {
            for (int i = 0; i < pbList.Count; i++)
            {
                if (pbList[i].BorderStyle == BorderStyle.Fixed3D)
                {
                    pbList[i].BorderStyle = BorderStyle.None;
                }
            }
        }

        private void MainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"spomenici.bin");
            using (Stream stream = File.Open(path, FileMode.Create))
            {
                BinaryFormatter bFormatter = new BinaryFormatter();
                bFormatter.Serialize(stream, evidencijaSpomenika);
                stream.Close();
            }

            path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"tipovi.bin");
            using (Stream stream = File.Open(path, FileMode.Create))
            {
                BinaryFormatter bFormatter = new BinaryFormatter();
                bFormatter.Serialize(stream, postojeciTipovi);
                stream.Close();
            }

            path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"etikete.bin");
            using (Stream stream = File.Open(path, FileMode.Create))
            {
                BinaryFormatter bFormatter = new BinaryFormatter();
                bFormatter.Serialize(stream, postojeceEtikete);
                stream.Close();
            }
        }

        private void spomeniciTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count == 0 && e.Node.Tag != null && e.Node.Tag is Spomenik)
            {
                Spomenik izabranSpomenik = (Spomenik)e.Node.Tag;
                loadWholeSpomenik(izabranSpomenik);
                for (int i = 0; i < pbList.Count; i++)
                {
                    if (((Spomenik)((TreeNode)pbList[i].Tag).Tag).SifraSpomenika.
                        Equals(izabranSpomenik.SifraSpomenika))
                    {
                        pbList[i].BringToFront();

                        deselectMapMarkers();

                        pbList[i].BorderStyle = BorderStyle.Fixed3D;

                        return;
                    }
                }

                deselectMapMarkers();
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

        private void prikaziHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "..\\..\\Resources\\Help.chm");
        }

        private void EtiketeDataGridView_MouseLeave(object sender, EventArgs e)
        {
            EtiketeDataGridView.ClearSelection();
        }

        private void tutorijalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tutorijalMode = true;

            tutorijalPanel.Visible = true;
            pbxRight.Visible = true;
            menuStrip1.Enabled = false;
            previousStepButton.Enabled = false;

            // uklanjanje svih podataka iz prikaza
            spomeniciTreeView.Nodes.Clear();
            for (int i = pbList.Count - 1; i > -1; i--)
            {
                mapPanel.Controls.Remove(pbList[i]);
            }

            pbList.Clear();

            // i postavljanje novih
            for (int i = 0; i < 3; i++)
            {
                Spomenik s = initializeSpomenik(i);
                spomeniciTreeView.Nodes.Add("Test tip " + i);
                spomeniciTreeView.Nodes[i].Nodes.Add("Test spomenik " + i);
                spomeniciTreeView.Nodes[i].Nodes[0].Tag = s;
            }

            spomeniciTreeView.ExpandAll();

            spomeniciTreeView.Nodes[0].Nodes[0].BackColor = Color.Red;
            tutorijalStep = 0;
            tutorijalTextBox.Text = "Prevucite spomenik oznacen crvenom bojom na mapu"
            + " tako sto ćete kliknuti na njega i prevući ga na neko mesto na mapi.";
        }

        // inicijalizacija spomenika za tutorijal
        private Spomenik initializeSpomenik(int i)
        {
            Spomenik s = new Spomenik();
            s.SifraSpomenika = "sifra " + i;
            s.Ime = "Test spomenik " + i;
            s.GodisnjiPrihod = 100 * i;
            s.Klima = (KlimaSpomenika)i;
            s.TuristickiStatus = (TuristickiStatusSpomenika)i;
            s.Opis = "test test opis";
            s.DatumOtkrivanja = "12/12/1212";
            s.Tip = new TipSpomenika();
            s.Tip.ImeTipa = "Test tip " + i;

            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tutorijalMode = false;
            tutorijalStep = 0;

            tutorijalPanel.Visible = false;
            pbxRight.Visible = false;
            menuStrip1.Enabled = true;

            for (int i = pbList.Count - 1; i > -1; i--)
            {
                mapPanel.Controls.Remove(pbList[i]);
            }

            // uklanjanje svih podataka iz prikaza
            spomeniciTreeView.Nodes.Clear();
            ucitajTipoveUTreeView();
            spomeniciTreeView.ExpandAll();
            iscrtajMarkereNaMapi();
        }

        private void previousStepButton_Click(object sender, EventArgs e)
        {
            tutorijalStep--;

            if (tutorijalStep == 0)
            {
                pbxRight.Visible = true;
                previousStepButton.Enabled = false;
                for (int i = pbList.Count - 1; i > -1; i--)
                {
                    mapPanel.Controls.Remove(pbList[i]);
                }
                pbList.Clear();

                spomeniciTreeView.SelectedNode = null;
                spomeniciTreeView.Nodes[0].Nodes[0].BackColor = Color.Red;
                ((Spomenik)spomeniciTreeView.Nodes[0].Nodes[0].Tag).SpomenikPostavljenNaMapu = false;
                tutorijalStep = 0;
                tutorijalTextBox.Text = "Prevucite spomenik označen crvenom bojom na mapu"
                + " tako sto ćete kliknuti na njega i prevući ga na neko mesto na mapi.";
            }
            else if (tutorijalStep == 1)
            {
                deselectMapMarkers();
                spomeniciTreeView.SelectedNode = null;
                pbxRight.Visible = false;
                tutorijalTextBox.Text = "Odlično! Spomenik je postavljen na mapu. Ako kliknete na isti spomenik u stablu"
                    + " isti će se selektovati na mapi.";
            }
            else if (tutorijalStep == 2)
            {
                tutorijalTextBox.Text = "Savršeno! Ako pređete mišem preko spomenika na mapi"
                                        + " pojaviće se detalji o spomeniku.";
            }
            else if (tutorijalStep == 3)
            {
                PictureBox pb = setMarkerPoint(((Spomenik)spomeniciTreeView.Nodes[0].Nodes[0].Tag).PozicijaNaMapi);
                pb.Tag = spomeniciTreeView.Nodes[0].Nodes[0];
                mapPanel.Controls.Add(pb);
                pb.BringToFront();
                tutorijalTextBox.Text = "Savršeno! Spomenik možete ukloniti sa mape ako kliknete"
                                        + " desni klik na spomenik na mapi i kliknete na obriši spomenik sa mape.";
            }


        }
    }
}
