﻿namespace DevintaUzduotis_TemperaturuVidurkioSkaiciavimas
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Parašykite programą, kuri leidžia vartotojui įvesti
                        // temperatūras kelias dienas.
                        // Masyvas turi būti naudojamas temperatūroms saugoti.
                        // Po to, kai visos temperatūros įvestos,
                        // programa turi naudoti for ciklą, kad apskaičiuotų
                        // ir išvestų temperatūrų vidurkį.


                        Console.WriteLine("Iveskite kiek temperaturu ivedinesite:");
                        int n = 0;
                        string ivestis = Console.ReadLine();
                        bool success = int.TryParse(ivestis, out int result1);
                        if (success == true)
                        {
                                n = int.Parse(ivestis);
                        }
                        else
                        {
                                Console.WriteLine("Operacija negalima: IVESTIS NERA SVEIKAS SKAICIUS");
                                System.Environment.Exit(0);
                        }

                        int[] Temp = new int[n];
                        int sum = 0;
                        int m = 0;
                        int index = 0;
                        foreach (int i in Temp)
                        {
                                string x = Console.ReadLine();
                                bool success2 = int.TryParse(x, out int result2);
                                if (success2 == true)
                                {
                                        m = result2;
                                }
                                else
                                {
                                        Console.WriteLine("Operacija negalima: IVESTIS NERA SVEIKAS SKAICIUS");
                                }

                                Temp[index] = m;
                                sum += m;
                                index++;
                        }

                        Console.WriteLine($"Ivestu temperaturu vidurkis yra: {sum / n}");
                }
        }
}