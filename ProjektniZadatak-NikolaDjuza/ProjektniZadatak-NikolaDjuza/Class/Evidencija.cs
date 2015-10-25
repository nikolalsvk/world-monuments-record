using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektniZadatak_NikolaDjuza.Class
{
    [Serializable]
    class Evidencija
    {
        public Evidencija() {
            EvidencijaSpomenika = new BindingList<Spomenik>();
        }

        public static BindingList<Spomenik> EvidencijaSpomenika { get; set; }
    }
}
