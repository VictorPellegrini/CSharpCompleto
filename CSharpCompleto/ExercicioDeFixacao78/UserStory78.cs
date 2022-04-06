using System;
using System.Collections.Generic;

namespace Section0678_Listas
{
    public class UserStory78
    {
        static void Main()
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employees> employeesList = new List<Employees>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\r\nEmployee #" + (i + 1) + ":");

                Console.Write("Insert ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Insert name: ");
                string name = Console.ReadLine();

                Console.Write("Insert salary: $");
                double salary = double.Parse(Console.ReadLine());

                Employees employee = new Employees(id, name, salary);

                employeesList.Add(employee);
            }

            Console.Write("\r\nInsert the employee's ID that will have a salary increase: ");
            int idSalaryIncrease = int.Parse(Console.ReadLine());

            if (employeesList.Exists(x => x.Id == idSalaryIncrease) == true)
            {
                Console.Write("\r\nInsert the salary increase percent: ");
                double percent = double.Parse(Console.ReadLine());

                employeesList.Find(x => x.Id == idSalaryIncrease).SalaryIncrease(percent);
            }
            else
                Console.WriteLine("This employee does not exist");

            foreach (Employees employee in employeesList)
            {
                Console.WriteLine("\r\nEmployee: ");
                Console.WriteLine("- ID: " + employee.Id);
                Console.WriteLine("- Name: " + employee.Name);
                Console.WriteLine("- Salary: $" + employee.Salary.ToString("F2"));
            }
        }
    }
}