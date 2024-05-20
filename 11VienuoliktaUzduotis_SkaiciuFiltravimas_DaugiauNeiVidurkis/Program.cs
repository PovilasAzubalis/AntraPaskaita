namespace VienuoliktaUzduotis_SkaiciuFiltravimas_DaugiauNeiVidurkis
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Parašykite programą, kurioje vartotojas įveda skaičių seriją į masyvą,
                        // o programa naudoja for ciklą ir if teiginį, kad atrinktų ir išvestų tik tuos skaičius,
                        // kurie yra didesni už vidutinę visų įvestų skaičių reikšmę.

                        Console.Write("Iveskite skaicius (pvz.: 2 20 40...):");
                        string ivestis = Console.ReadLine();
                        string[] splitIvestis = ivestis.Split(" ");
                        int[] skaiciai = new int[splitIvestis.Length];
                        int vidurkis;
                        int suma = 0;

                        for (int i = 0; i < splitIvestis.Length; i++)
                        {
                                skaiciai[i] = Convert.ToInt32(splitIvestis[i]);
                                suma += skaiciai[i];


                        }

                        vidurkis = suma / splitIvestis.Length;

                        for (int i = 0; i < skaiciai.Length; i++)
                        {
                                if (skaiciai[i] > vidurkis) Console.Write($"{skaiciai[i]} ");
                        }

                }
        }
}