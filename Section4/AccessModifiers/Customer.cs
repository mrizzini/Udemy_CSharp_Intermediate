using System;

namespace AccessModifiers
{
   public class Customer
    {
        // define a couple of properties
        public int Id { get; set; }
        public string Name { get; set; }

        // method
        public void Promote()
        {
            var rating = CalculateRating();
            if (rating == 0)
            {
                System.Console.WriteLine("Promoted to Level 1");
            }
            else
            {
                System.Console.WriteLine("Promoted to Level 2");
            }
        }

        // this is about implentation, the customer does not need to see this. They only need to see Id, Name, and Promote
        // So make it private. So if make any changes to this, we
        // only need to change it when we call it in the Promote method
        public int CalculateRating()
        {
            return 0;
        }

    }

}