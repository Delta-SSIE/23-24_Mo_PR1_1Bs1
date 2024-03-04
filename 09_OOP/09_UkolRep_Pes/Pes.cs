using System;

public class Pes
{
	//Vlastnosti (položky datové)
	public string Jmeno;
	public int Nohy;
	public bool JeOckovany;

	//Metoda
	public string PredstavSe()
	{
		//Naplnění proměnné očkovani pomocí short-hand if.
		string ockovani = (JeOckovany) ? "očkovaný" : "neočkovaný";
        string text = $"Já jsem pes, jmenuju se {Jmeno}, mám {Nohy} nohy a jsem {ockovani}.";
		return text;
	}
}
