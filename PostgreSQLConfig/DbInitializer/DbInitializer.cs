using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQLConfig.DbInitializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly EducationPageDbContext _db;
        private readonly ILogger<DbInitializer> _logger;
        public DbInitializer(ILogger<DbInitializer> logger, EducationPageDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        public void Initialize()
        {
            //migrations if they are not applied
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception e) 
            {
                _logger.LogError($"Exception happened in DbInitializer. Exception:{e.Message}");
            }
            return;
        }
    }
}
