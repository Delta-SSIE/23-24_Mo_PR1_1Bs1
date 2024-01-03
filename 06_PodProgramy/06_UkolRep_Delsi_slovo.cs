namespace delsi_slovo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej první slovo: ");
            string slovo1 = Console.ReadLine();

            Console.Write("Zadej druhé slovo: ");
            string slovo2 = Console.ReadLine();

            //Metoda DelsiSlovo vrací hodnotu stringu, která se uloží do proměné delsiSlovo.
            string delsiSlovo = DelsiSlovo(slovo1, slovo2);
            Console.WriteLine($"Když porovnáme {slovo1} a {slovo2}, pak delší je {delsiSlovo}.");
        }

        static string DelsiSlovo(string s1, string s2)
        {
           
            if (s1.Length > s2.Length)
            {
                //Vrácení parametru s1
                return s1;
            }
            else
            {
                //Vrácení parametru s2
                return s2;
            }
        }
    }
}