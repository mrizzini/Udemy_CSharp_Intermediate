using System;

namespace InterfaceExtensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Extensibility
            // Instead of changin the code in the existing classes, simply add in new classes that change the behvaior of the system
            // Everytime we want to change the behavior of our software we create new classes
            // We can write automated or unit tests for only our new classes
            // Minimal or 0 impact on current classes
            // Costly though, not every change should be made like this
            
            
            // You can do this by an interface


            // INSTANCE OF DBMIRGRATOR
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            // OR CAN DO NEW FILE LOGGER
            // var dbMigrator = new DbMigrator(new FileLogger());
            dbMigrator.Migrate();

        }
    }
}
