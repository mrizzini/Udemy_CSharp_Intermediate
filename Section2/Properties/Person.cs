using System;

namespace Properties
{


            // Properties help us achieve the get set with less code
            // Property - a class member that encapsulates a getter/setter for accessing a field
            // To create a getter/setter with less code
            // Properties are in PaschalClass

    public class Person
    {
        public Person (DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        // Auto Impleneted Property
        public DateTime Birthdate { get; private set; }
        // this will create a private field and implements the get and set methods for us
        // private set means it is read only. so we need to create a constructor and set it in there

        public int Age
        {
            get 
            {
                // we need some logic for Age so we do it like this
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
            // we don't do a set because we don't want this to be "settable"
            // so if we don't want it settable we dont declare a set method
        }

        // instead of typing public string Name {get; set;}
        // type prop then tab
        public string Name { get; set; }


        // Declare auto impleneted properties at the top of the class
        // Then the constructor 
        // Then calculated properties on bottom

    }

}    
    
