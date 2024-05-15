namespace dicnost_poly_abs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal zvire = new Animal();
            zvire.Name = "Adolf";

            Dog pes = new Dog();
            pes.Name = "Alik";
            pes.Breed = "Akita";

            pes.Sleep();
            zvire.Sleep();

            pes.Information();
            zvire.Information();

        }
    }
}