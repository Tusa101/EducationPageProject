using EducationPageWebAPI.Models;
using Models.Models;
using PostgreSQLData.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQLDb.Repository.IRepository
{
    public interface IThemeRepository : IRepository<Theme>
    {
        Task Update(Theme obj);
        Task<IEnumerable<object>> GetAllThemesWithArticles();
        Task<IEnumerable<object>> GetThemeWithArticles(string themeId);
    }
}
