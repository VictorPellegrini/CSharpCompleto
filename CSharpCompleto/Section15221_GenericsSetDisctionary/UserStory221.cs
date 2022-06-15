using Section15221_GenericsSetDisctionary.Entities;
using Section15221_GenericsSetDisctionary.Services;
using System;
using System.Collections.Generic;

namespace Section15221_GenericsSetDisctionary
{
    public class UserStory221
    {
        private static void Main()
        {
            Console.WriteLine("Hey Alex!");

            HashSet<User> listStudents = new HashSet<User>();

            listStudents = InterfaceService.InsertStudents('A', listStudents);
            listStudents = InterfaceService.InsertStudents('B', listStudents);
            listStudents = InterfaceService.InsertStudents('C', listStudents);

            Console.WriteLine("\nTotal students: " + listStudents.Count);
        }
    }
}
