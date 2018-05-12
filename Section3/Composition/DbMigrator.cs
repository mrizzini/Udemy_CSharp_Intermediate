using System;

namespace Composition
{
    public class DbMigrator
    {

        private readonly Logger _logger;

        // constructor
        // want to create an association with the logger class
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        // method
        public void Migrate()
        {
            // we need to call the log method of the Logger class
            _logger.Log("We are migrating...");
        }

    }

}