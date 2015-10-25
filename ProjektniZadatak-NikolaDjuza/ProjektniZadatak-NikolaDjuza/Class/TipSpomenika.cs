using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProjektniZadatak_NikolaDjuza.Class
{
    [Serializable]
    public class TipSpomenika : INotifyPropertyChanged
    {
        public TipSpomenika(string sifra, string ime, string opis, Image ikonica)
        {
            this.SifraTipaSpomenika = sifra;
            this.ImeTipa = ime;
            this.Opis = opis;
            this.Ikonica = ikonica;
        }

        public TipSpomenika()
        {
            this.SifraTipaSpomenika = null;
            this.ImeTipa = null;
            this.Opis = null;
            this.Ikonica = null;
        }

        public override string ToString()
        {
            return this.ImeTipa;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property. 
        // The CallerMemberName attribute that is applied to the optional propertyName 
        // parameter causes the property name of the caller to be substituted as an argument. 
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string SifraTipaSpomenika { get; set; }

        public string ImeTipa { get; set; }

        public string Opis { get; set; }

        public System.Drawing.Image Ikonica { get; set; }
    }
}
