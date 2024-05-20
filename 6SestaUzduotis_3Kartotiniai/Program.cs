namespace SestaUzduotis_3Kartotiniai
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurkite programą, kuri naudoja while ciklą norint rasti ir
                        // išvesti pirmus 10 skaičių nuo 1 iki 100, kurie dalijasi iš 3 be liekanos.
                        // Programa turi išvesti šiuos skaičius vieną po kito,
                        // kiekvieną naujoje eilutėje.

                        int x = 3;
                        int n = 100;
                        while (n > 0)
                        {
                                int kartotinis = n % x;
                                if (kartotinis == 0) Console.WriteLine($"{n}");
                                n--;
                        }

                }

        }
}