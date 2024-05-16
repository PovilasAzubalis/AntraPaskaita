namespace SestaUzduotis_3Kartotiniai
{
        public class Program
        {
                public static void Main(string[] args)
                {

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