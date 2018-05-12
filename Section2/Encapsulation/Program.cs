using System;

namespace Encapsulation
{



public class Person
{
    private DateTime _birthdate;
    // we will now declare fields private
    // now we cannot access _birthdate field outside of the person class
    // This is what we mean by information hiding
    // to set the birthdate we need a method

    public void SetBirthdate(DateTime birthdate)
    {
        // If we have any logic, we can implement here
        _birthdate = birthdate;
        // we set _birthdate to the value passed into this method
        // we need to set another method now
    }

    public DateTime GetBirthdate()
    {
        return _birthdate;
        // just returns _birthdate;
    }

    // now in our Main we can do person.SetBirthdate() to set it
    // we do it this way because their fields are their implentation
    // it should be hidden from the outside world
    // ***Objects should hide their implentation detail and reveal what they can do as opposed to how they do it***
    // Fields will now be declared as private and _name
    // We have an easier way than using two methods like above


}


    class ProgramEncapsulation
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var person = new Person();
            person.SetBirthdate(new DateTime(1982, 3, 1));
            System.Console.WriteLine(person.GetBirthdate());
        }
    }
}
