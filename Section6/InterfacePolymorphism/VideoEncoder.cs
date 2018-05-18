using System;
using System.Collections.Generic;

// OCP - Open Closed Principle;
// Software entities should be open for extension and closed for modification


namespace InterfacePolymorphism
{

    public class VideoEncoder
    {
 
        private readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        // We don't want VideoEncoder to be tightly couple to a Mail
        // notification service. We want to use an interface to implement OCP
        // We are not talking about specific mail services
        // That way VideoEncoder does not care who implements this class
        // We can create new implentations of this with new classes without changing this code
        public void Encode(Video video)
        {
            // Video encoding logic...

            // A different method is going to be when we call the Send method at runtime depending on the type of notification channel
            // POLYMORPHISM!
            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
 
 
    }
}