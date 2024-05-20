namespace SeptintaUzduotis_PirminiaiSkaiciai_dalyba_Is_11
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Parašykite programą kuri prašo įvesti intervalą NUO/IKI
                        // ir jame atspausdina pirminius skaičius,
                        // skaičius kurie dalinasi iš 11 be liekanos

                        Console.Write("Iveskite intervalo pradzia (> 0):");
                        ushort.TryParse(Console.ReadLine(), out ushort pradzia);
                        Console.Write("Iveskite intervalo pabaiga:");
                        ushort.TryParse(Console.ReadLine(), out ushort pabaiga);
                        int[] skaiciai = Enumerable.Range(pradzia, pabaiga + 1).ToArray();

                        int dalinamasIs11 = 0;
                        for (int i = 0; i < skaiciai.Length; i++)
                        {
                                if (skaiciai[i] % 11 == 0 && skaiciai[i] / 11 != 0) dalinamasIs11++;
                        }




                        // tikslumo didinimas pridedant daugiau pirminiu skaiciu
                        for (int i = 0; i < skaiciai.Length; i++)
                        {
                                if (skaiciai[i] % 2 == 0 && skaiciai[i] != 2) skaiciai[i] = 0;
                                if (skaiciai[i] % 3 == 0 && skaiciai[i] != 3) skaiciai[i] = 0;
                                if (skaiciai[i] % 5 == 0 && skaiciai[i] != 5) skaiciai[i] = 0;
                                if (skaiciai[i] % 7 == 0 && skaiciai[i] != 7) skaiciai[i] = 0;
                                if (skaiciai[i] % 11 == 0 && skaiciai[i] != 11) skaiciai[i] = 0;
                                if (skaiciai[i] % 13 == 0 && skaiciai[i] != 13) skaiciai[i] = 0;
                                if (skaiciai[i] % 17 == 0 && skaiciai[i] != 17) skaiciai[i] = 0;
                                if (skaiciai[i] % 19 == 0 && skaiciai[i] != 19) skaiciai[i] = 0;
                                if (skaiciai[i] % 23 == 0 && skaiciai[i] != 23) skaiciai[i] = 0;
                                if (skaiciai[i] % 29 == 0 && skaiciai[i] != 29) skaiciai[i] = 0;

                        }

                        foreach (int pirminiai in skaiciai)
                        {
                                if (pirminiai != 0) Console.Write($"{pirminiai} ");
                        }
                        
                        Console.WriteLine($"Skaiciai, kurie dalijasi is 11: {dalinamasIs11}");

                }

        }
}