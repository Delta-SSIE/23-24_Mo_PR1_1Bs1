namespace oop_uvod
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Tvorba objektu ze Třídy Car;
            Car moje_auto = new Car();
            Car sousedovo_auto = new Car();

            //Výpis vlastností/položek objektu
            Console.WriteLine(sousedovo_auto.znacka);
            Console.WriteLine(moje_auto.color);

            //Volání metody u objektů dané třídy
            moje_auto.Jed();
            sousedovo_auto.Jed();

            //Změna hodnoty položky objektu
            moje_auto.color = "blue";
            Console.WriteLine(moje_auto.color);

            //Vytvoření objektu ze třídy ovoce
            Ovoce Jablko = new Ovoce();
            Jablko.Vypis();
            Jablko.barva = "zelená";
            Jablko.Vypis();

            Ovoce Hruska = new Ovoce();
            Hruska.tvar = "šišoid";
            Hruska.barva = "zelená";
            Hruska.nazev = "hruška";
            Hruska.Vypis();

            //Vytvoření objektu skrz konstruktor
            Ovoce Mango = new Ovoce("koule", "oranžová", "mango");
            Mango.Vypis();
        }


    }
}