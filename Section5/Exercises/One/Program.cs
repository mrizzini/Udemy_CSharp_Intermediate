using System;

namespace One
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // var dbConnection = new DbConnection("connection_string.test");
            // System.Console.WriteLine(dbConnection.ConnectionString);

            var sql = new SqlConnection("sql_connection.test");
            // System.Console.WriteLine(sql.ConnectionString);
            sql.Open();

            var oracle = new OracleConnection("oracle_connection.test");
            // System.Console.WriteLine(oracle.ConnectionString);
            oracle.Open();

            sql.Close();
            oracle.Close();

            // System.Console.WriteLine(sql.Timeout); 
            // System.Console.WriteLine(new TimeSpan(0, 4, 0));
        }
    }
}
