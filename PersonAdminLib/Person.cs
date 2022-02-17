using System;
using System.Collections.Generic;
using System.Text;






namespace PersonAdminLib
{
    public class Person
    {

       

        public Person(string firstname, string surname)
        {
            Firstname = firstname;
            Surname = surname;
        }
        public string Firstname { get; }
        public string Surname { get; }

    }
    
}