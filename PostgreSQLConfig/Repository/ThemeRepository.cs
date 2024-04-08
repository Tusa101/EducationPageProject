using EducationPageWebAPI.Models;
using Models.Models;
using PostgreSQLData.Repository.IRepository;
using PostgreSQLData.Repository;
using PostgreSQLDb.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PostgreSQLConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace PostgreSQLDb.Repository
{
    public class ThemeRepository : Repository<Theme>, IThemeRepository
    {
        private readonly EducationPageDbContext _db;
        private readonly IArticleRepository _articleRepository;
        public ThemeRepository(EducationPageDbContext db, IArticleRepository articleRepository) : base(db)
        {
            _db = db;
            _articleRepository = articleRepository;
        }

        public async Task<IEnumerable<object>> GetAllThemesWithArticles()
        {
            var themesWithArticles = _db.Themes.Join(_db.Articles,
                        t => t.ThemeId,
                        a => a.ThemeId,
                        (t, a) => new
                        {
                            ThemeId = t.ThemeId,
                            ThemeName = t.Name,
                            ArticleId = a.ArticleId,
                            ArticleName = a.Name,
                            ArticleAnnotation = a.Annotation,
                            ArticleText = a.Text
                        });
            return themesWithArticles;
        }

        public async Task<IEnumerable<object>> GetThemeWithArticles(string themeId)
        {
            var themeWithArticles = _db.Themes.Where(th=>th.ThemeId == themeId).Join(_db.Articles,
                        t => t.ThemeId,
                        a => a.ThemeId,
                        (t, a) => new
                        {
                            ThemeId = t.ThemeId,
                            ThemeName = t.Name,
                            ArticleId = a.ArticleId,
                            ArticleName = a.Name,
                            ArticleAnnotation = a.Annotation,
                            ArticleText = a.Text
                        });
            return await themeWithArticles.ToListAsync();
        }

        public async Task Update(Theme obj)
        {
            var theme = _db.Themes.Where(t => t.ThemeId == obj.ThemeId).FirstOrDefault();
            if (theme != null)
            {
                theme.Name = obj.Name;
                _db.Themes.Update(theme);
                await _db.SaveChangesAsync();
            }
        }
    }
}
