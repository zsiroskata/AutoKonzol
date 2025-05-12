using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKonzol
{
    internal class Gyarto
    {
        public int GyartoAzonosito { get; set; }
        public string GyartoNev { get; set; }

        public Gyarto(int id, string nev)
        {
            GyartoAzonosito = id;
            GyartoNev = nev;
        }
    }
}
