namespace Extensibility
{

    public class DbMigrator
        {
        private readonly Ilogger _logger;
        public DbMigrator(Ilogger logger)
        {
            _logger = logger;
        } 
            public void Migrate()
            {
            _logger.LogInfo("Migration started at {0}" + DateTime.Now);

            _logger.LogInfo("Migration Finished at {0}" + DateTime.Now);    

            }
        }
    
}
