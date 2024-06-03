namespace Adresar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tvorba adresáře
            //relativní cesta od .exe souboru
            Directory.CreateDirectory(@"adresar");
            //absolutní cesta k adresáři
            Directory.CreateDirectory(@"C:\Users\mottja\Desktop\adresar");

            if (!Directory.Exists(@"slozka"))
            {
                Directory.CreateDirectory(@"slozka");
            }
        }
    }
}