namespace TryliktaUzduotis_AugaluMasyvoManipuliacija
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurkite masyvą su dešimties augalų pavadinimais.
                        // kiekvieną uždavinio augalą atskiroje eilutėje.
                        // uždavinio kiekvieną augalą pradedant nuo paskutinio, ir baigiant pirmuoju. (atvirkščias ciklas).
                        // kiek uždavinio masyve yra žodžių trumpesnių nei 5 simboliai, ir kiek ilgesnių nei 7 simboliai.
                        // kiek uždavinio masyve yra žodžių ilgesnių nei 5 simboliai bet trumpesnių nei 10 simboliai.

                        string[] Augalai = { "1.Pusis", "2.Egle", "3.Kukmedis",
                                "4.Maumedis","5.Bukas","6.azuolas", "7.Oak",
                                "8.Liepa","9.Uosis", "10.Klevas"};

                        foreach(string kiekvienasAugalas in Augalai)
                        {
                                Console.WriteLine(kiekvienasAugalas);
                        }

                        Console.WriteLine();
                        

                        foreach (string kiekvienasAugalas in Augalai.Reverse())
                        {
                                Console.WriteLine(kiekvienasAugalas);
                        }

                        int MaziauPenki = 0;
                        int DaugiauSeptyni = 0;
                        for (int i = 0; i < Augalai.Length; i++)
                        {
                                
                                if (Augalai[i].Length < 7) MaziauPenki++;
                                if (Augalai[i].Length > 9) DaugiauSeptyni++;
                        }

                        Console.WriteLine();
                        Console.WriteLine($"Pavadinimai, kurie trumpesni nei 5 simboliai : {MaziauPenki}");
                        Console.WriteLine($"Pavadinimai, kurie ilgesni nei 7 simboliai : {DaugiauSeptyni}");

                        int specifinisIlgis = 0;
                        for (int i = 0; i < Augalai.Length; i++)
                        {

                                if (Augalai[i].Length > 7 && Augalai[i].Length < 12 ) specifinisIlgis++;
                        }

                        Console.WriteLine();
                        Console.WriteLine($"Zodziai patenkantys i nustatytus rezius (5 - 10): {specifinisIlgis}");
                }
        }
}