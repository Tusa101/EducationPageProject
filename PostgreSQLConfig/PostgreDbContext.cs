using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQLConfig
{
    public class PostgreDbContext:DbContext, IUnitOfWork
    {
        protected PostgreDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
