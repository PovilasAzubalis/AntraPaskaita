namespace KeturioliktaUzduotis_SkaiciuMasyvoManipuliacija
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sugeneruokite 300 atsitiktinių skaičių nuo 0 iki 3000, atspausdinkite juos atskirtus tarpais
                        // ir suskaičiuokite kiek tarp jų yra didesnių už 150.
                        // Skaičiai didesni nei 275 turi būti atspausdinti skliausteliuose” [ ] “.
                        // Vienoje eilutėje atspausdinkite visus skaičius nuo 1 iki 3000,
                        // kurie dalijasi iš 77 be liekanos. Skaičius atskirkite kableliais.
                        // Po paskutinio skaičiaus kablelio neturi būti.

                        Random rnd = new Random();
                        int[] randomGeneratorius = new int[300];
                        int Daugiau150 = 0;
                        for (int i = 0; i < randomGeneratorius.Length; i++)
                        {
                                randomGeneratorius[i] = rnd.Next(1, 3000);

                                if (randomGeneratorius[i] > 150) Daugiau150++;

                                if (randomGeneratorius[i] > 275)
                                {
                                        Console.Write($"[{randomGeneratorius[i]}] ");
                                }
                                else
                                {
                                        Console.Write($"{randomGeneratorius[i]} ");
                                }
                        }

                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine($"Duomenu skaicius, kurie daugiau uz 150: {Daugiau150}");

                        Console.WriteLine();

                        string b = "";
                        for (int i = 0; i < randomGeneratorius.Length; i++)
                        {
                                if (randomGeneratorius[i] % 77 == 0)
                                {
                                       b = b + $"{randomGeneratorius[i]},";
                                       
                                }
                                
                        }
                        b = b.TrimEnd(',');
                        Console.WriteLine(b);
                        Console.WriteLine();
                }

        }
}
