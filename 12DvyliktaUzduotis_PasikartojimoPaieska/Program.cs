namespace VienuoliktaUzduotis_SkaiciuFiltravimas_DaugiauNeiVidurkis
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Parašykite programą, kuri paprašo vartotojo įvesti tekstą.
                        // Naudokite for ciklą, kad suskaičiuotumėte ir išvestumėte kiekvienos raidės
                        // (A-Z, nepaisant didžiosios ar mažosios raidės) pasikartojimo skaičių tekste.
                        // Norėdami tai padaryti, galite naudoti 26 elementų masyvą,
                        // kur kiekvienas indeksas atitinka raidę (pvz., 0 atitinka A, 1 - B ir t.t.),
                        // o reikšmė masyve atitinka raidės pasikartojimo skaičių.

                        Console.WriteLine("Iveskite teksta: ");

                        string ivestis = Console.ReadLine(); 
                        ivestis.ToLower();
                        string[] IvestisArr = new string[ivestis.Length];
                        
                        for (int i = 0; i < ivestis.Length; i++)
                        {
                                IvestisArr[i] = ivestis.Substring(i, 1);
                        }


                        string[] abecele = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p",
                                "q","r","s","t","u","v","w","x","y","z" };

                        int[] pasikartojamumas = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                0, 0, 0, 0, 0, 0};


                        for (int i = 0; i < ivestis.Length; i++)
                        {
                                if(IvestisArr[i] == abecele    
                        }
                        Console.WriteLine($"{IvestisArr.ToString()}");
                        Console.WriteLine($"{pasikartojamumas}");


                }
        }
}