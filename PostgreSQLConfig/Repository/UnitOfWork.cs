using PostgreSQLConfig;
using PostgreSQLData.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQLData.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EducationPageDbContext _educationPageDbContext;
        public UnitOfWork(EducationPageDbContext educationPageDbContext)
        {
            _educationPageDbContext = educationPageDbContext;
        }
        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _educationPageDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
