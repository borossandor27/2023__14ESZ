using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_13_DataGridView
{
    class Orszag
    {
        public string OrszagNev;
        public string Fovaros;
        public double Terulet;

        public Orszag(string orszagNev, string fovaros, double terulet)
        {
            OrszagNev = orszagNev;
            Fovaros = fovaros;
            Terulet = terulet;
        }
    }
}
