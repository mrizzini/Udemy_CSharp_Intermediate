using System;

namespace Composition
{
    public class Installer
    {

        private readonly Logger _logger;

        // constructor
        // want to create an association with the logger class
        public Installer(Logger logger)
        {
            _logger = logger;
        }

        // method
        public void Install()
        {
            // we need to call the log method of the Logger class
            _logger.Log("We are installer...");
        }

    }
}