using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class FullTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public FullTimeEmployee(string name, string position, decimal salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Full-Time Employee: {Name}, Position: {Position}, Salary: {Salary:C}");
        }
    }
}
