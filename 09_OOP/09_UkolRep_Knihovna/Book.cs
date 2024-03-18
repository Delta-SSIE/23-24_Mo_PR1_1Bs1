using System;

public class Book
{
	public string nazev;
	public int rokvydani;
	public Author autor;
	public Book(string jmeno, int yearpubl, Author zad_autor)
	{
		nazev = jmeno;
		rokvydani = yearpubl;
		autor = zad_autor;
	}
}
