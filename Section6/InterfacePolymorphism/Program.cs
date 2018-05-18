using System;

namespace InterfacePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            // Encode method takes video object
            encoder.RegistrationNotificationChannel(new MailNotificationChannel());
            encoder.RegistrationNotificationChannel(new SmsNotificationChannel());
            encoder.Encode(new Video());
        }
    }
}
