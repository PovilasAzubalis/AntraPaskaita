namespace DesimtaUzduotis_MaksimaliosMinimaliosReiksmesRadimas
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurkite programą, kuri paprašo vartotojo įvesti skaičių seriją
                        // į masyvą. Naudokite for ciklą, kad rastumėte didžiausią ir mažiausią
                        // skaičius masyve. Panaudokite if sąlyginius teiginius, kad
                        // nustatytumėte, kuris skaičius yra didžiausias, o kuris - mažiausias,
                        // ir išveskite juos į ekraną.

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