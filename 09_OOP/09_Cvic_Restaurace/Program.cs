namespace Restaurace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant res = new Restaurant("U Dvora");
            res.foodlist = new Food[] {
            new Food("Jehněčí",160,"Masové"),
            new Food("Kuřecí",100,"Masové"),
            new Food("Hovězí",120,"Masové"),
            new Food("Lilek",100,"Vegetarianské"),
            new Food("Tofu",120,"Veganské"),
            new Food("Kotleta",180,"Masové"),
            new Food("Brokolice",80,"Vegetarianské"),
            new Food("Květák",130,"Vegetarianské"),
            new Food("Seitan",150,"Veganské")
            };

            res.VypisJidlo();
            res.PridejJidlo();
            res.OdeberJidlo();
            Console.WriteLine();
            res.VypisJidlo();

        }
    }
}