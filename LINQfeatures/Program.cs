using System;
using System.Collections.Generic;

namespace LINQfeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> developers = new Employee[]
            {
                    new Employee { Id = 1, Name = "Nate" },
                    new Employee { Id = 2, Name = "Nicole" }
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex" }
            };

            foreach (var person in developers)
            {
                Console.WriteLine(person.Name);
            }

            Console.ReadLine();
        }
    }
}
