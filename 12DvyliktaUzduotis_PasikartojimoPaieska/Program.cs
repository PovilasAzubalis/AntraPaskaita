namespace DvyliktaUzduotis_PasikartojimoPaieska
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Parašykite programą, kuri paprašo vartotojo įvesti tekstą.
                        // Naudokite for ciklą, kad suskaičiuotumėte ir išvestumėte kiekvienos raidės
                        // (A-Z, nepaisant didžiosios ar mažosios raidės) pasikartojimo skaičių tekste.
                        // Norėdami tai padaryti, galite naudoti 26 elementų masyvą,
                        // kur kiekvienas indeksas atitinka raidę (pvz., 0 atitinka A, 1 - B ir t.t.),
                        // o reikšmė masyve atitinka raidės pasikartojimo skaičių.

                        Console.WriteLine("Iveskite teksta: ");

                        string ivestis = Console.ReadLine();
                        Console.WriteLine();
                        ivestis = ivestis.ToLower();
                        ivestis = ivestis.Replace(" ", string.Empty);

                        // Tikrinimas po viena simboli is ivesties ir naikinant.
                        while (ivestis.Length > 0)
                        {
                                Console.Write($"{ ivestis[0]}:");
                                int pasikartojamumas = 0;
                                for (int i = 0; i < ivestis.Length; i++)
                                {
                                        if (ivestis[0] == ivestis[i]) pasikartojamumas++;
                                }
                                Console.WriteLine(pasikartojamumas);
                                ivestis = ivestis.Replace(ivestis[0].ToString(), string.Empty);
                        }
                }
        }
}