using System;
using System.Collections.Generic;

namespace CodeAlongs2
{

    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
        // whenever you have a list of objects in your class, always initialize that to an empty list
        // that way it is initialized to an empty list whenver we create a customer

        // declaring constructor

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this() // this
        { // this() means when this constructor is called first it is going to call the constructor without any parameters. So the orders field will be initialized first then it will come here
            this.Id = id; 
        }

        public Customer (int id, string name)
            : this(id)
        { // first will call constructor that takes the id parameter
            // this.Id = id;
            this.Name = name;
        }

        // we only use constructors in classes in situations where we want to intiialize an object at its earliest date
    }


    
}