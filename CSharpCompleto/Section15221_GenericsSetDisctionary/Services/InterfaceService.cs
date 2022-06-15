using Section15221_GenericsSetDisctionary.Entities;
using System;
using System.Collections.Generic;

namespace Section15221_GenericsSetDisctionary.Services
{
    public static class InterfaceService
    {
        public static HashSet<Students> InsertStudents(char course, HashSet<Students> listStudents)
        {
            Console.Write($"\nHow many students for course {course}? ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantity; i++)
            {
                Console.Write($"Id student {i}: ");
                int id = int.Parse(Console.ReadLine());

                listStudents.Add(new Students(id));
            }

            return listStudents;
        }
    }
}
