using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum__39
{
    class FictionBook : IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public FictionBook(string title, string author, int year, string genre)
        {
            Title = title;
            Author = author;
            Year = year;
            Genre = genre;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"[Художественная литература] {Title}, автор: {Author}, год: ({Year}), жанр: {Genre}");
        }
    }
}
