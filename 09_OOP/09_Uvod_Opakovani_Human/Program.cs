namespace OOP_opakovani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarace nového objektu
            Human pepa = new Human("Pepa", 25);
            Human lukas = new Human("Lukáš", 31);

            //Volání metody daného objektu
            pepa.PredstavSe();
            lukas.PredstavSe();

            //Změna vlastnost
            pepa.PocetKoncetin = 0;
            pepa.PredstavSe();

            Console.WriteLine(pepa.MuzeChodit());
            Console.WriteLine(lukas.MuzeChodit());
        }
    }
}