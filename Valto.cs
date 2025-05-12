using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKonzol
{
    internal class Valto
    {
        public int ValtoAzonosito { get; set; }
        public string ValtoNev { get; set; }
        public Valto(int id, string nev)
        {
            ValtoAzonosito = id;
            ValtoNev = nev;
        }
    }
}
