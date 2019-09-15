using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace module_05
{
    class Program
    {
        static void Main()
        {
            var cars = ProcessFile("fuel.csv");

            var query = cars.OrderByDescending(c => c.Combined)
                            .ThenBy(c => c.Name)
                            .FirstOrDefault(c => c.Manufacturer == "BMW" && c.Year == 2016); // [or .Last()] returns value or null

            Console.WriteLine(query.Name);

            //foreach (var car in query.Take(10))
            //{
            //    Console.WriteLine($"{car.Name} : {car.Combined}");
            //}
        }

        private static List<Car> ProcessFile(string path)
        {
            return File.ReadAllLines(path)
                       .Skip(1)
                       .Where(line => line.Length > 1)
                       .Select(Car.ParseFromCsv)
                       .ToList();
        }
    }
}
