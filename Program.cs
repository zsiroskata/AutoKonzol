using AutoKonzol;
using System.Text;

List<Auto> kocsik= new();
using (StreamReader sr = new StreamReader(path: @"..\..\..\src\carsData.csv", encoding: Encoding.UTF8))
{
    sr.ReadLine();
    int sorszam = 1;
    while (!sr.EndOfStream)
    {
        Auto auto = new Auto(sr.ReadLine());
        auto.Sorszam = sorszam++;
        kocsik.Add(auto);
    }
    sr.Close();
}

Console.Write("6. feladat - ");
var hatos = kocsik.Where(x => x.Gyarto.GyartoNev == "Rolls-Royce" &&  x.Karosszeria.KarosszeriaNev == "Sedan" && x.HengerekSzama == 8);
Console.WriteLine($"8 hengeres, Rolls-Royce sedanok száma az adott időszakban: {hatos.Count()} db ");

Console.Write("7. feladat - ");
var hetes = kocsik.OrderByDescending(x => x.Ar).Take(1);
Console.WriteLine("A legdrágább autó");
foreach (var item in hetes)
{
    Console.WriteLine($"{item.ToString()}\tÁra (HUF): {Math.Round( item.huf())}");
}

Console.Write("8. feladat - ");
var nyolcas = kocsik.Where(x => x.Gyarto.GyartoNev == "Aston Martin" 
            || x.Gyarto.GyartoNev == "Ferrari" 
            || x.Gyarto.GyartoNev == "McLaren"
            || x.Gyarto.GyartoNev == "Mercedes-Benz"
            || x.Gyarto.GyartoNev == "Porsche"
            );

Console.WriteLine("Adatok fájlba írása");

using (StreamWriter sw = new StreamWriter(path: @"..\..\..\src\forma-1.txt "))
{
    foreach (var item in nyolcas)
    {
        sw.WriteLine($"{item.Azonosito}; {item.Gyarto.GyartoNev}; {item.Model}; {item.Evjarat}; {item.KilometeroraAllas}");
    }
    sw.Close();
}

