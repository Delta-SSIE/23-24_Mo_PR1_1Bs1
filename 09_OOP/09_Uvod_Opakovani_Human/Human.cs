using System;

public class Human
{
    //Vlastnosti/Atributy/Položky
    public string Jmeno;
    public int PocetKoncetin = 4;
    public int Vek;

    //Konstruktor
    public Human(string name, int vek)
	{
        Jmeno = name;
        Vek = vek;
	}

    //Metody

    public void PredstavSe()
    {
        Console.WriteLine($"Ahoj, já jsem {Jmeno} a je mi {Vek} let! A mimochodem mám {PocetKoncetin} končetin!");
    }

    public bool MuzeChodit()
    {
        if (PocetKoncetin <= 1)
        {
            return false;
        } else
        {
            return true;
        }
    }

	

}
