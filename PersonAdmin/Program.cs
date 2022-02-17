using System;
using System.Reflection;
using PersonAdminLib;

namespace PersonAdmin
{

    class Program
    {
       static void Main(String[] args)
        {
            Console.WriteLine($"My first C# Program:{ Assembly.GetExecutingAssembly().GetName().Version})");

            var person = new Person("Hesham", "Ouda");

            Console.WriteLine($"Name: {person.Firstname} {person.Surname}");

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();


        }
    }
}