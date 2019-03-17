using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQfeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) => x + y;

            Console.WriteLine(square(add(3,5)));

            IEnumerable<Employee> developers = new Employee[]
            {
                    new Employee { Id = 1, Name = "Nate" },
                    new Employee { Id = 2, Name = "Nicole" }
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex" }
            };

            //METHOD SYNTAX using extensions
            var query = developers.Where(e => e.Name.Length == 6)
                                    .OrderBy(e => e.Name);
            foreach (var employee in query)
            {
                Console.WriteLine(employee.Name);
            }

            //QUERY SYNTAX using keywords
            var query2 = from developer in developers
                         where developer.Name.Length == 5
                         orderby developer.Name
                         select developer;
            foreach (var employee in query2)
            {
                Console.WriteLine(employee.Name);
            }

            // 1) calling NameStartsWithA ..NAMED method
            //foreach (var employee in sales.Where(NameStartsWithA))
            //{
            //    Console.WriteLine(employee.Name);
            //}

            // 2) ANONYMOUS method example
            //foreach (var employee in developers.Where(
            //    delegate (Employee employee)
            //    {
            //        return employee.Name.StartsWith("N");
            //    }))
            //{
            //    Console.WriteLine(employee.Name);
            //}

            // 3) LAMBDA expression syntax
            //foreach (var employee in developers.Where(
            //            e => e.Name.StartsWith("N")))
            //{
            //    Console.WriteLine(employee.Name);
            //}

            //print developers who have 6 letters in their name and arrange in alphabetical order
            foreach (var employee in developers.Where(e => e.Name.Length == 4)
                                                .OrderBy(e => e.Name))
            {
                Console.WriteLine(employee.Name);
            }

            

            Console.ReadLine();
        }
        // 1) example of named method. called in the foreach loop written above 
        //private static bool NameStartsWithA(Employee employee)
        //{
        //    return employee.Name.StartsWith("A");
        //}
    }
}
