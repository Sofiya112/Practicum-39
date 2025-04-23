using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            var company = new Company();

            // Создаем сотрудников
            var fullTimeEmployee = new FullTimeEmployee("Ivan Ivanov", "Software Engineer", 100000);
            var partTimeEmployee = new PartTimeEmployee("Maria Petrova", "Graphic Designer", 20);
            var contractor = new Contractor("Petr Sidorov", "Project Manager", "Contract 2025");

            // Добавляем сотрудников в компанию
            company.AddBook (fullTimeEmployee);
            company.AddBook(partTimeEmployee);
            company.AddBook(contractor);

            // Отображаем информацию о всех сотрудниках
            company.ShowAllBooks ();

            // Удаляем одного сотрудника
            company.RemoveBook (partTimeEmployee);

            Console.WriteLine("После увольнения работника, работающего неполный рабочий день:\n");
            company.ShowAllBooks();

            Console.ReadLine();
        }
    }
}
