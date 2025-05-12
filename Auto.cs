using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKonzol
{
    internal class Auto
    {
        public int Sorszam { get; set; }
        public int Azonosito { get; set; }
        public int Evjarat { get; set; }
        public Gyarto Gyarto { get; set; }
        public string Model { get; set; }
        public int KilometeroraAllas { get; set; }
        public Karosszeria Karosszeria { get; set;}
        public int HengerekSzama { get; set; }
        public Valto Valto { get; set; }
        public string KulsoSzin { get; set; }
        public string BelsoSzin { get; set; }
        public int SzemelyekSzama { get; set; }
        public int Ajtok { get; set; }
        public double FogyasztasVarosban { get; set; }
        public double FogyasztasAutopalyan { get; set; }
        public int Ar { get; set; }
    

        public Auto(string sor)
        {
            var s = sor.Split(";");
            Azonosito = int.Parse(s[0]);
            Evjarat = int.Parse(s[1]);
            Gyarto = new(int.Parse(s[2]), s[3]);
            Model = s[4];
            KilometeroraAllas = int.Parse(s[5]);
            Karosszeria = new(int.Parse(s[6]), s[7]);
            HengerekSzama = int.Parse(s[8]);
            Valto = new(int.Parse(s[9]), s[10]);
            KulsoSzin = s[11];
            BelsoSzin = s[12];
            SzemelyekSzama = int.Parse(s[13]);
            Ajtok = int.Parse(s[14]);
            FogyasztasVarosban = Convert.ToDouble(s[15]);
            FogyasztasAutopalyan = Convert.ToDouble(s[16]);
            Ar = int.Parse(s[17]); 
        }
        public double huf()
        {
            return Ar * 248.02;
        }
        public override string ToString()
        {
            double atlagFogyasztas = (FogyasztasVarosban + FogyasztasAutopalyan) / 2;
            return $"{Sorszam}. autó\n" +
                $"\tGyártó: {Gyarto.GyartoNev} - {Model}\n" +
                $"\tFogyasztás: {atlagFogyasztas} l/100km\n" +
                $"\tKilométeróra állás: {KilometeroraAllas} km\n" +
                $"\tVáltó típus: {Valto.ValtoNev}\n" +
                $"\tÁra (CAD): {Ar}\n";
        }
    }
}
