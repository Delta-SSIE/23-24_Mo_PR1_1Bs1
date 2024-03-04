using System;

public class Ovoce
{
    //Položky
    public string tvar;
    public string barva;
    public string nazev;

    //Konstruktor
    public Ovoce(string zad_tvar = "koule", string zad_barva = "červená", string zad_nazev = "jablko")
    {
        tvar = zad_tvar;
        barva = zad_barva;
        nazev = zad_nazev;
    }
    
    //Metody
    public void Vypis()
    {
        Console.WriteLine($"Ovoce má tvar {tvar} a barvu {barva}. Tomuto ovoci se říká {nazev}");
    }
}
