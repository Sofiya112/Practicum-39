using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum__39
{
    public class Library 
    {
       
            private List<IBook> books = new List<IBook>();

            // Метод для добавления книги в библиотеку
            public void AddBook(IBook book)
            {
                books.Add(book);
            }

            // Метод для удаления книги из библиотеки
            public void RemoveBook(IBook book)
            {
                books.Remove(book);
            }

            // Метод для отображения всех книг в библиотеке
            public void ShowAllBooks()
            {
                Console.WriteLine("Library contains:");
                foreach (var book in books)
                {
                    book.DisplayInfo();
                }
                Console.WriteLine();
            }
        

    }

}
