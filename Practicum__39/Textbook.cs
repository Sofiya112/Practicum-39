using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum__39
{
    class Textbook : IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Subject { get; set; }
        public Textbook(string title, string author, int year, string subject)
        {
            Title = title;
            Author = author;
            Year = year;
            Subject = subject;
        }
        public void DisplayInfo() //Вывод
        {
            Console.WriteLine($"[Научная литература] {Title}, автор{Author}, год ({Year}), Предмет: {Subject}");
        }
    }
}
