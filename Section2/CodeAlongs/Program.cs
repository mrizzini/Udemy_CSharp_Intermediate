using System;

namespace CodeAlongs
{

    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            System.Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
           var person = new Person();
           person.Name = str;

           return person;
        }
        // if we want to use this Parse method, we would have to use it on an object because it is an instance method
        // BUT INSTEAD we can declare this as static so we do not have to create a new person
    }

    class ProgramCodeAlongs2
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // create objects in Main

            // var person = new Person();
            var person = Person.Parse("John"); 
            // person.Name = "Josh";
            person.Introduce("Mosh");
        }
    }
}
