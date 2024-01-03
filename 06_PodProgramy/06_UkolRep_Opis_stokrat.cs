namespace opis_stokrat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //metoda "Opisvetu" dostane dva argumenty - int a string
            Opisvetu(10, "Nauč se programovat!");
        }

        //Metoda očekává dva parametry (int a string)
        static void Opisvetu(int n, string veta)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(veta);
            }
        }
    }
}