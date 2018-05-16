using System;

namespace Two
{
    public class OracleConnection : DbConnection
    {

        // need to create a constructor to take in dbconnection string
        private readonly string connectionString;

        public OracleConnection(string connectionString)
            :base(connectionString)
        {
            this.connectionString = connectionString;  

        }
        // override open and close methods
        // if we don't do this, it won't run because we call this abstract in Dbconnection
        public override void Open()
        {
            System.Console.WriteLine("Opening Oracle Database connection {0}", connectionString);
        }

        public override void Close()
        {
            System.Console.WriteLine($"Closing Oracle Database connection {connectionString}");
        }

    }

}