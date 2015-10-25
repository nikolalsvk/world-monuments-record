using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektniZadatak_NikolaDjuza.Class
{
    [Serializable]
    public class Etiketa
    {
        public Etiketa()
        {
            this.SifraEtikete = null;
            this.OpisEtikete = null;
            this.BojaEtikete = Color.Empty;
        }

        public Etiketa(string sifra, Color boja, string opis) {
            this.SifraEtikete = sifra;
            this.BojaEtikete = boja;
            this.OpisEtikete = opis;
        }



        public string SifraEtikete { get; set; }

        public Color BojaEtikete { get; set; }

        public string OpisEtikete { get; set; }

    }
}
