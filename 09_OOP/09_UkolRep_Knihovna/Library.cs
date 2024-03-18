using System;

public class Library
{
	public string name;
	public string location;
	public Book[] books;
	public Library(string nazev, string lokace)
	{
		name = nazev;
		location = lokace;
		books = new Book[0];
	}

	public void AddBook(Book kniha)
	{
		Array.Resize(ref this.books, books.Length + 1);
		this.books[this.books.Length-1] = kniha;
	}

	public void VypisKnihyRok(int rok)
	{
		foreach (Book kniha in books)
		{
			if(kniha.rokvydani == rok)
			{
				Console.WriteLine($"{kniha.nazev} byla vydána roku {kniha.rokvydani} a její autor se jmenuje {kniha.autor.jmeno} a narodil se {kniha.autor.roknarozeni}");
			}
		}
	}
}
