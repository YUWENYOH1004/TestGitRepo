using System;
namespace Library2025
{
	public class Book
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public int YearPublished { get; set }

		public Book(string title, string author, int yearpublished)
		{
			Title = title;
			Author = author;
			YearPublished = yearpublished;
		}

        public override string ToString()
        {
			return $"{Title} by {Author} ({YearPublished})";
        }
    }
}

