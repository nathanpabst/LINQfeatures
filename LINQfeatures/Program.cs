using System;
using System.Collections.Generic;
using System.Linq;

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

            Console.WriteLine(developers.Count());

            foreach (var person in developers)
            {
                Console.WriteLine(person.Name);
            }

            //alternate method without LINQ extension methods to iterate through the collection & print names
            //IEnumerator<Employee> enumerator = developers.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current.Name);
            //}

            Console.ReadLine();
        }
    }
}
