using System;
namespace Library2025
{
	public class EBook:Book
	{
		public double FileSizeMB { get; set; }
		public EBook(string title, string author, int yearpublished, double filesize): base(title, author, yearpublished)
		{
			FileSizeMB = filesize;
		}

        public override string ToString()
        {
            return $"{base.ToString()} FileSize: {FileSizeMB}";
        }
    }
}

