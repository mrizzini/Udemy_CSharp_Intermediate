using System;

namespace Composition
{
    class ProgramComposition
    {
        static void Main(string[] args)
        {
            // Composition:
            // A kind of relationship between two classes that allows one to contain the other
            // Has-a relationship
            // Car has an Engine

            // Benefits:
            // -Code re-use
            // -Flexibility
            // -A means to designing loose-coupling

            // We have a DbMigrator class that requires logging
            // We have an Installer class that requires logging
            // Logging is common between the two
            // We can create a Logger class to log messages in a text file
            // Both the classes have a relationship (composition) to Logger

            // The related class is simply a private field in the composite class


            // create a DbMigrator
            // need to pass a logger object
            var dbMigrator = new DbMigrator(new Logger());

            //  can do the new Logger() way or can create a logger var
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
