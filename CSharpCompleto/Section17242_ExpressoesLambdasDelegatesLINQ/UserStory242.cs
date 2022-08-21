using Section17242_ExpressoesLambdasDelegatesLINQ.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Section17242_ExpressoesLambdasDelegatesLINQ
{
    class UserStory242
    {
        static void Main()
        {
            string pathFile = Directory.GetCurrentDirectory() + @"..\..\..\..\src\employees.csv";
            string[] employes = File.ReadAllLines(pathFile);

            List<Employee> employesList = new List<Employee>();

            foreach(var line in employes)
            {               
                string[] employeeInput = line.Trim().Split(';');
                employesList
                    .Add(new Employee(employeeInput[0], employeeInput[1], double.Parse(employeeInput[2], CultureInfo.InvariantCulture)));
            }

            Console.Write("Show employee's emails that have salary greater than: $ ");
            var minimunSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var employesFilterSalary = employesList
                .Where(x => x.Salary > minimunSalary)
                .OrderBy(x => x.Email)
                .Select(x => x.Email)                
                .ToList();

            Console.WriteLine("\nShowing: ");
            foreach (var item in employesFilterSalary)
            {
                Console.WriteLine(item);
            }

            var employesFilterSum = employesList.Where(x => x.Name.StartsWith('M')).Select(x => x.Salary).Sum();
            
            Console.Write("\nShowing the sum of employes salaries that name start with 'M': $ " 
                + employesFilterSum.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
