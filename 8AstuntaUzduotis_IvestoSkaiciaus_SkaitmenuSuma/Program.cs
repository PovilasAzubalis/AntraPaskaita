namespace AstuntaUzduotis_IvestoSkaiciaus_SkaitmenuSuma
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurkite programą, kuri naudoja while ciklą,
                        // norint suskaičiuoti ir išvesti įvesto skaičiaus skaitmenų sumą.
                        // Programa turi paprašyti vartotojo įvesti skaičių ir tada apskaičiuoti
                        // bei išvesti skaitmenų sumą. Pvz., jei vartotojas įveda 123,
                        // programa turėtų išvesti 6 (1+2+3).

                        Console.Write("Iveskite sveikaji skaiciu: ");
                        string ivestis = Console.ReadLine();
                        int indeksas = 0;
                        int sudedamiNariai = 0;
                        while (indeksas < ivestis.Length)
                        {
                                sudedamiNariai += int.Parse(ivestis.Substring(indeksas, 1));
                                indeksas++;
                                       
                        }

                        Console.WriteLine(sudedamiNariai);

                }

        }
}