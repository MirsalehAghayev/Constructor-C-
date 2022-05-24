using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework999
{
     class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public bool IsAbult;
        public Person(string name, string surname, int age )
        {
            IsAbult = false;
            Name = name;
            Surname = surname;
            Age = age;
            if (Age > 18)
            {
                IsAbult |= true;
                Console.WriteLine(IsAbult);
            }
            else 
            {
                Console.WriteLine(IsAbult);
            }
        }
    }

   
}
