using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektniZadatak_NikolaDjuza.Class
{
    [Serializable]
    public class Spomenik
    {
        public Spomenik()
        {
            Etikete = new BindingList<Etiketa>();
            Tip = null;
            SpomenikPostavljenNaMapu = false;
        }

        public string SifraSpomenika { get; set; }

        public string Ime { get; set; }

        public string Opis { get; set; }

        public TipSpomenika Tip { get; set; }

        public KlimaSpomenika Klima { get; set; }

        public bool EkoloskiUgrozen { get; set; }

        public bool StanisteUgrozenih { get; set; }

        public bool NaseljenRegion { get; set; }

        public TuristickiStatusSpomenika TuristickiStatus { get; set; }

        public decimal GodisnjiPrihod { get; set; }

        public string DatumOtkrivanja { get; set; }

        public BindingList<Etiketa> Etikete { get; set; }

        public Image SlikaSpomenika { get; set; }

        public bool SpomenikPostavljenNaMapu { get; set; }

        public Point PozicijaNaMapi { get; set; }

    }
}
