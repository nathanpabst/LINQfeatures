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
            foreach (var employee in developers.Where(
                        e => e.Name.StartsWith("N")))
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
