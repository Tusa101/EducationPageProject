using EducationPageWebAPI.Models;
using PostgreSQLConfig;
using PostgreSQLData.Repository;
using PostgreSQLData.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQLDb.Repository
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        private readonly EducationPageDbContext _db;
        public ArticleRepository(EducationPageDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task Update(Article obj)
        {
            _db.Articles.Update(obj);
        }
    }
}
