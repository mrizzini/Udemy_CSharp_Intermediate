using System;

namespace Two
{
    public abstract class DbConnection
    {
        // Constructor that takes in string
        public DbConnection(string connectionString)
        {
            // checks if string is empty or null
            if (connectionString == "" || connectionString == null)
            {
                throw new InvalidOperationException("Canot be empty or null");
            }
            // if it is not null, assign 
            this.connectionString = connectionString;

            // creates fictional timespan when class is created
            this.timeout = TimeSpan.FromMinutes(1).Add(TimeSpan.FromMinutes(2));
            
            // checks timespan and throws exception if too long
            if (timeout > new TimeSpan(0, 4, 0))
            {
                throw new InvalidOperationException("Timed out. Took too long"); 
            }
        }

        // ConnectionString : string
        // sets up read only connection string
        private string connectionString;
        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            // set
            // {
            //     connectionString = value;
            // }
        }

        // Timeout : TimeSpan
        // sets up read only timeout
        private TimeSpan timeout;
        public TimeSpan Timeout
        {
            get
            {
                return timeout;
            }
            // set
            // {
            //     timeout = new TimeSpan(2);
            // }
        }

        // sets up methods that will be implemented in derived classes
        public abstract void Open(); 
        public abstract void Close(); 
         
    }

}