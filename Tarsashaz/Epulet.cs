using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarsashaz
{
    class Epulet
    {
        public ulong epuletid;
        public string utcanev;
        public int hazszam;
        public List<Lako> lakok = new List<Lako>();

        public Epulet(ulong epuletid, string utcanev, int hazszam)
        {
            this.epuletid = epuletid;
            this.utcanev = utcanev;
            this.hazszam = hazszam;
        }
        public override string ToString()
        {
            return $"{utcanev} {hazszam}. ({lakok.Count})";
        }
    }
}
