namespace KetvirtaUzduotis_VisuSkaiciuSumaWhile
{
        public class Program
        {
                public static void Main(string[] args)

                {
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