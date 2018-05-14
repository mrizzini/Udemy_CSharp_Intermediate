using System;

namespace AccessModifiers
{

     // make a class derives from Customer class
    public class GoldCustomer : Customer
    {
       public void OfferVoucher()
       {
        //    this.CalculateRating(); 
        // CAN'T USE THIS BECAUSE CALCULATERATING IS PRIVATE
       }
    }
    class ProgramAcessModifiers
    {
        static void Main(string[] args)
        {
            // we want our objects to have limited visibility from outside
            // lots of magic in the inside
            // Isolating changes - the more a class reveals the more risky it comes when we change it
            
            // PUBLIC
            
            // Accessibly everywhere
            // If it is NOT part of implenetation, it is fine to have it public
            // Only for the public interface

            // PRIVATE

            // Only accessible from the class
            // If it involves implentation detail, it should be private
            // Other classes should not know about it

            // PROTECTED

            // Accessible only from the class and its derived classes
            // But any classes derived from the original class will still be able to see the method and that breaks encapsulation, which is about hiding the details
            // Avoid if you can and use private instead

            // INTERNAL

            // Accessible only from the same assembly
            // Often use with classes, not its members

            // PROTECTED INTERNAL

            // Accessible only from the same assembly or any derived class
            // Hard to understand, unlikely to need it


            // CODE ALONG

            // create an instance of customer
            var customer = new Customer();
            // we want to minimize public interface of the class
            // 

        }
    }
}
