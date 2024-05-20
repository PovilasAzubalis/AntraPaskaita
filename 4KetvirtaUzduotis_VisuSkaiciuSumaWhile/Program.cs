namespace KetvirtaUzduotis_VisuSkaiciuSumaWhile
{
        public class Program
        {
                public static void Main(string[] args)

                {
                        // Parašykite programą, kuri naudoja while ciklą, kad suskaičiuotų
                        // visų teigiamų skaičių, mažesnių nei nurodytas skaičius n suma.
                        // Programa turi paprašyti vartotojo įvesti skaičių n ir
                        // tada išvesti suskaičiuotą sumą.


                        string ivestis = Console.ReadLine();

                        if (int.TryParse(ivestis, out int n))
                        {
                                n = int.Parse(ivestis);
                        }
                        else
                        {
                                Console.WriteLine("Operacija negalima: IVESTIS NERA SVEIKAS SKAICIUS");
                                System.Environment.Exit(0);
                        }

                        int i = 1;
                        int sum = 0;
                        while (i < n)
                        {
                                sum += i;
                                i++;
                        }

                        Console.WriteLine($"Visu skaiciu suma: {sum}");
                }
        }
}