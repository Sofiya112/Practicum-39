using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class PartTimeEmployee : IEmployee
    {
        public string Name { get; }
        public string Position { get; }
        public decimal HourlyRate { get; }

        public PartTimeEmployee(string name, string position, decimal hourlyRate)
        {
            Name = name;
            Position = position;
            HourlyRate = hourlyRate;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Частичный сотрудник: {Name}, Должность: {Position}, Почасовая ставка: {HourlyRate:C}");
        }
    }
}
