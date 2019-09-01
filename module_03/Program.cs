using System;
using System.Collections.Generic;
//using module_03.Linq;
using System.Linq;

namespace module_03
{
    class Program
    {
        static void Main()
        {
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee { Id = 1, Name = "Scott" },
                new Employee { Id = 2, Name = "Chris" }
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex" }
            };

            var query = developers.Where(e => e.Name.Length == 5)
                .OrderBy(e => e.Name);

            var query2 = from developer in developers
                where developer.Name.Length == 5
                orderby developer.Name
                select developer.Name;


            foreach (var employee in query2)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
