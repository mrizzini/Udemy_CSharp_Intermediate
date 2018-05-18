using System;

// OCP - Open Closed Principle;
// Software entities should be open for extension and closed for modification
namespace InterfacePolymorphism
{

    // create concrete class that implements
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending SMS...");
        }
    }
}