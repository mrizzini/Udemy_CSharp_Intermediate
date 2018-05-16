using System;

namespace Two
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate sequel database connection
            var sql = new SqlConnection("sql_connection.test");

            // instantiate oracle database connection
            var oracle = new OracleConnection("oracle_connection.test");

            // instantiate dbCommand, sending in either sql or oracle and an instruction
            // polymorphism - depending on what we send, implentation will be different
            var dbCommand = new DbCommand(oracle, "instruction to database");
            
            // run execute command which will run Open and Close and print the instruction
            dbCommand.Execute();
        }
    }
}
