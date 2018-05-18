using System;

// OCP - Open Closed Principle;
// Software entities should be open for extension and closed for modification
namespace InterfacePolymorphism
{

    // we created concrete classes as SmsNotification and MailNotification
    // So we have one interface with two implentations

    public interface INotificationChannel
    {
        void Send(Message message);
    }


}