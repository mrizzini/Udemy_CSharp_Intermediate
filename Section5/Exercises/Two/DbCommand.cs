using System;

namespace Two
{
    public class DbCommand
    {
 
         // Constructor that takes in the connection
        public DbCommand(DbConnection connection, string instruction)
        {
            // checks if connection is null
            if (connection == null)
            {
                throw new InvalidOperationException("Connection cannot be null");
            }

            // if it is not null, assign 
            this.connection = connection;

            if (instruction == null || instruction == "")
            {
                
                    throw new InvalidOperationException("Connection cannot be empty or null");
            }

            // if instruction passed in is not null or empty, assign 
            this.instruction = instruction;
        }
            
            // sets up read only connection 
            private DbConnection connection;
            public DbConnection Connection
            {
                get
                {
                    return connection;
                }
            }

            private string instruction;
            public string Instruction { get; }

            public void Execute()
            {
                // this will go to either SqlConnection or OracleConnection depending on what was passed in
                connection.Open();
                System.Console.WriteLine("Running instruction: {0}", instruction);
                connection.Close();
            } 
    }   
}
