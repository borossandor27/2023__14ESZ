using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarsashaz
{
    class Lako
    {
        public ulong lakoid;
        public string lakonev;
        public int szulev;
        public ulong epuletid;

        public Lako(ulong lakoid, string lakonev, int szulev, ulong epuletid)
        {
            this.lakoid = lakoid;
            this.lakonev = lakonev;
            this.szulev = szulev;
            this.epuletid = epuletid;
        }
        public override string ToString()
        {
            return this.lakonev;
        }
    }
}
