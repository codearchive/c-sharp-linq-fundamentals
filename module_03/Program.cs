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
                new Employee { Id = 1, Name= "Scott" },
                new Employee { Id = 2, Name= "Chris" }
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex" }
            };

            Console.WriteLine(sales.Count());
            IEnumerator<Employee> enumerator = developers.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (enumerator.Current != null) Console.WriteLine(enumerator.Current.Name);
            }
        }        
    }
}
