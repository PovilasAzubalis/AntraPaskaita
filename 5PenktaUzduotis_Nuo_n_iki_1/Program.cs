﻿namespace PenktaUzduotis_Nuo_n_iki_1
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
                        { }
                        if (n > 0)
                        {
                                for (int x = 1; n > x; n--)
                                {
                                        Console.WriteLine($"{n - 1}");
                                }
                        }
                        else if (n < 0)
                        {
                                for (int x = 1; n < x; n++)
                                {
                                        Console.WriteLine($"{n + 1}");
                                }
                        }
                }
        }
}