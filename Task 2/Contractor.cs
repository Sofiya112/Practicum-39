using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Contractor : IEmployee
    {
        public string Name { get; }
        public string Position { get; }
        public string Contract { get; }
        public Contractor(string name, string position, string contract)
        {
            Name = name;
            Position = position;
            Contract = contract;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Частичный сотрудник: {Name}, Должность: {Position}, Договор: {Contract:C}");
        }
    }
}
