using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKonzol
{
    internal class Karosszeria
    {
        public int KarosszeriaAzonosito { get; set; }
        public string KarosszeriaNev { get; set; }
        public Karosszeria(int id, string nev)
        {
            KarosszeriaAzonosito = id;
            KarosszeriaNev = nev;
        }
    }
}
