using EducationPageWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQLData.Repository.IRepository
{
    public interface IArticleRepository : IRepository<Article>
    {
        void Update(Article obj);
    }
}
