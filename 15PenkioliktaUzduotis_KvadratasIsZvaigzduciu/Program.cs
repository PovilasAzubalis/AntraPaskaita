namespace KeturioliktaUzduotis_SkaiciuMasyvoManipuliacija
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Nupieškite kvadratą iš “*”, kurio kraštines sudaro 25“*”
                        // pasibandyti tusciaviduri 

                        int krastine = 25;
                        for (int i = 1; i <= krastine; i++)
                        {
                                for (int j = 1; j <= krastine; j++)
                                {
                                        if (j <= i)
                                                Console.Write(" * ");
                                        else
                                                Console.Write(" * ");
                                }
                                Console.WriteLine();
                        }
                }



        }
}