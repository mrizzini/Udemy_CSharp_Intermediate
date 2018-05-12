using System;

namespace Properties
{


    class ProgramProperties
    {
        static void Main(string[] args)
        {


            var person = new Person(new DateTime(1982, 3, 1));
            // person.Birthdate = new DateTime(1982, 3, 1);
            System.Console.WriteLine(person.Age);
            

        }
    }
}
