using System;
namespace Library2025
{
	public class PrintedBook:Book
	{
		public int PageCount { get; set; }

		public PrintedBook(string title, string author, int yearpublished, int pagecount): base(title, author, yearpublished)
		{
			PageCount = pagecount;
		}

        public override string ToString()
        {
            return $"{base.ToString()} PageCount: {PageCount}";
        }
    }
}

