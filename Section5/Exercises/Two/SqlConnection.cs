using System;

namespace Two
{
    public class SqlConnection : DbConnection
    {

        // need to create a constructor to take in dbconnection string
        private readonly string connectionString;

        public SqlConnection(string connectionString)
            :base(connectionString)
        {
            this.connectionString = connectionString;
        }

        // override Open and Close methods
        // if we don't do this, it won't run because we call this abstract in Dbconnection
        public override void Open()
        {
            System.Console.WriteLine("Opening SQL Database connection {0}", connectionString);
        }

        public override void Close()
        {
            System.Console.WriteLine($"Closing SQL Database connection {connectionString}");
        }

    }

}