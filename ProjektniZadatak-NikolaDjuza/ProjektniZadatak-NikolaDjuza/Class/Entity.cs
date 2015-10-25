using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektniZadatak_NikolaDjuza.Class
{
    class Entity
    {
        protected Entity()
        {
            Sifra = Guid.NewGuid();
        }

        public Guid Sifra { get; set; }
    }
}
