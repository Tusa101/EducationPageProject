using EducationPageWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Models.Models;

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
            
            modelBuilder.Entity<Theme>().HasData(
                new Theme(id: "1", name: "Stocks", imagePath: "/images/Stocks.png"),
                new Theme(id: "2", name: "Bonds", imagePath: "/images/Bonds.png"),
                new Theme(id: "3", name: "Crypto", imagePath: "/images/Crypto.png"),
                new Theme(id: "4", name: "ETF", imagePath: "/images/ETF.png"),
                new Theme(id: "5", name: "Goods", imagePath: "/images/Goods.png"),
                new Theme(id: "6", name: "Forex", imagePath: "/images/Forex.png"),
                new Theme(id: "7", name: "Futures", imagePath: "/images/Futures.png"),
                new Theme(id: "8", name: "TechAnalysis", imagePath: "/images/TechAnalysis.png")
                );
            modelBuilder.Entity<Article>().HasData(
                new Article(name: "Init article", 
                            themeId: "1",
                            inThemePostionNumber: 1,
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
