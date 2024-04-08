using EducationPageWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQLConfig
{
    public class EducationPageDbContext : DbContext
    {
        public EducationPageDbContext(DbContextOptions<EducationPageDbContext> options) : base(options)
        {
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Theme> Themes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Theme Stocks = new Theme(id: "1", name: "Stocks");
            modelBuilder.Entity<Theme>().HasData(
                //new Theme(id: 1, name: "Stocks"),
                new Theme(id: "2", name: "Bonds"),
                new Theme(id: "3", name: "Crypto"),
                new Theme(id: "4", name: "ETF"),
                new Theme(id: "5", name: "Goods"),
                new Theme(id: "6", name: "Forex"),
                new Theme(id: "7", name: "Futures")
                );
            modelBuilder.Entity<Article>().HasData(
                new Article(name: "Init article", 
                            themeId: Stocks.ThemeId,
                            annotation: "This article is made to test the db connection", 
                            text: "This article is very interesting, testing. This article is very interesting, testing.\n" +
                            "This article is very interesting, testing. This article is very interesting, testing.\n" +
                            "This article is very interesting, testing. This article is very interesting, testing.\n" +
                            "This article is very interesting, testing. This article is very interesting, testing.\n" +
                            "This article is very interesting, testing. This article is very interesting, testing.\n" +
                            "This article is very interesting, testing. This article is very interesting, testing.")
                );
            
        }
    }
}
