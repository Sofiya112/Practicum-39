using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum__39
{
    class Program
    {

            static void Main(string[] args)
            {
                var library = new Library();

                // Создаем несколько книг
                var fiction = new FictionBook("1984", "George Orwell", 1949, "Антиутопия");
                var nonfiction = new NonFictionBook("Сапиенс", "Yuval Noah Harari", 2011, "История");
                var textbook = new Textbook("C# Программирование", "John Smith", 2020, "Информатика");

                // Добавляем книги в библиотеку
                library.AddBook(fiction);
                library.AddBook(nonfiction);
                library.AddBook(textbook);

                // Отображаем все книги в библиотеке
                library.ShowAllBooks();

                // Удаляем одну книгу из библиотеки
                library.RemoveBook(nonfiction);

                Console.WriteLine("После удаления книги:\n");

                // Отображаем книги после удаления
                library.ShowAllBooks();
            Console.ReadLine();
            }

    }
}
