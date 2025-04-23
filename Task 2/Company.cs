using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Company
    {
        private List<IEmployee> employee = new List<IEmployee>();

        // Метод для добавления книги в библиотеку
        public void AddBook(IEmployee book)
        {
            employee.Add(book);
        }

        // Метод для удаления книги из библиотеки
        public void RemoveBook(IEmployee book)
        {
            employee.Remove(book);
        }

        // Метод для отображения всех книг в библиотеке
        public void ShowAllBooks()
        {
            Console.WriteLine("Library contains:");
            foreach (var book in employee)
            {
                book.DisplayInfo();
            }
            Console.WriteLine();
        }
    }
}
