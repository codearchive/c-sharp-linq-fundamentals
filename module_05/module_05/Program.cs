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

            foreach (var car in cars)
            {
                Console.WriteLine(car.Name);
            }
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
