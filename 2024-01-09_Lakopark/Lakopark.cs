using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_01_09_Lakopark
{
    class Lakopark
    {
        readonly int lakoparkId;
        string lakoparkNeve;
        int utcakSzama;
        int telkekSzama;
        int[,] hazak; //--- utca és telek érték alapján az emeletszámot adja vissza

       
        public string LakoparkNeve { get => lakoparkNeve; set => lakoparkNeve = value; }
        public int UtcakSzama { get => utcakSzama; set => utcakSzama = value; }
        public int TelkekSzama { get => telkekSzama; set => telkekSzama = value; }
        public int[,] Hazak { get => hazak; set => hazak = value; }

        public Image getNevadoKep()
        {
            return Image.FromFile( $"Kepek{Path.DirectorySeparatorChar}{this.lakoparkNeve}.jpg");
        }
        public Image getHazKep(int utca, int telek)
        {
            Image HazKep;
            switch (Hazak[utca, telek])
            {
                case 1:
                    HazKep = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}Haz1.jpg");
                    break;
                case 2:
                    HazKep = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}Haz2.jpg");
                    break;
                case 3:
                    HazKep = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}Haz3.jpg");
                    break;
                default:
                    HazKep = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}kereszt.jpg");
                    break;
            }
            return HazKep;
        }
        public int LakoparkId => lakoparkId;

        public Lakopark(int lakoparkId, string lakoparkNeve, int utcakSzama, int telkekSzama)
        {
            this.lakoparkId = lakoparkId;
            LakoparkNeve = lakoparkNeve;
            UtcakSzama = utcakSzama;
            TelkekSzama = telkekSzama;
            this.hazak = new int[utcakSzama, telkekSzama];
        }

        internal void HazAdat(int utcaSzam, int hazSzam, int emelet)
        {
            this.hazak[utcaSzam - 1, hazSzam - 1] = emelet;
        }
    }
}
