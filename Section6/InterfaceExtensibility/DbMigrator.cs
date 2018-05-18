using System;

namespace InterfaceExtensibility
{
    public class DbMigrator
    {
        // THIS TALKS TO AN INTERFACE
        // THIS CLASS SHOULD BE CLOSED FOR MODIFICATION BUT OPEN FOR EXTENSIBILITY. 
        // OPEN FOR EXTENSION USING ILOGGER _LOGGER EXTENSION POINT
        
        // creating new classes that implenets the interface

        // create constructor to inject interface
        // dependency injection
        // specifing dependencies for the DbMigrator class
        private readonly ILogger _logger;

        // there is no coupling between DbMigrator here and that concrete class
        // dbMigrator does not care who the logger is. no coupling between this and conrete class
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
 
        public void Migrate()
        {
            // we are going to directly talk to logger
            _logger.LogInfo("Migration started at {0}" + DateTime.Now);

            // Details of migrating the database

            _logger.LogInfo("Migration finished at {0}" + DateTime.Now);            
        }
 
    }
}