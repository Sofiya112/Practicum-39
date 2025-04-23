using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum__39
{
    class NonFictionBook : IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Topic { get; set; }

        public NonFictionBook(string title, string author, int year, string topic) //Конструктор
        {
            Title = title;
            Author = author;
            Year = year;
            Topic = topic;
        }
        public void DisplayInfo() //Вывод
        {
            Console.WriteLine($"[Научная литература] {Title}, автор{Author}, год ({Year}), тема: {Topic}");
        }

    }
}
