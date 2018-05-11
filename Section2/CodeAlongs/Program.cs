using System;

namespace CodeAlongs2
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

    public class Customer2
    {
        public int Id;
        public string Name;
        public readonly List<Order2> Orders2 = new List<Order2>();
        // this way it will alwyas be an empty list when initialized
        // this is a different approach, it is up to us. be consistent
        // readonly - will only be initialize a read only once when we declare it or in a constructor

        public Customer2(int id)
        {
            this.Id = id;
        }
        public Customer2(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            // ...
        }
    }

    public class Order2
    {

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


            // Constructor lesson

            // Customer customer = new Customer();
            // OR
            var customer = new Customer(1, "John");

            var order = new Order();
            customer.Orders.Add(order);

            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);

            // METHODS


            // var number = int.Parse("abc"); WON'T WORK
            // use TryParse
            int number;
            var result = int.TryParse("abc", out number);
            // TryParse returns a boolean to show if it was successful or not. Won't throw an exception

            // FIELDS

            var customer = new Customer2(1):
            customer.Orders.Add(new Order());

            System.Console.WriteLine(customer.Orders.Count);

        }

        static void UsePoints()
        {
            // code that may throw an exception goes in try block
            // if exception is thrown, the catch block is executed
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                System.Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
                point.Move(100, 200);
                System.Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
            }
            catch (Exception)
            {
                System.Console.WriteLine("An unexpected error occurred");
                
            }
        }

        static void UseParams()
        {
            // create instnce of calcualtor class
            var calcualtor = new Calcualtor();
            System.Console.WriteLine(calcualtor.Add(1, 2);
            // with params, we can pass in as many numbers as we want
            // don't need to pass in an integer array

        }
    }
}
