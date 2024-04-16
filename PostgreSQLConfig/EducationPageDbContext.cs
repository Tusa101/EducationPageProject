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
        public DbSet<Tags> Tags { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Theme>().HasData(
                new Theme(id: "1", name: "Stocks", imagePath: "/images/Stocks.png", tagsIds: new List<string> { "c4e86988-5252-432d-97e4-84709e91b1e9", "dd44442e-a4e2-4cab-893f-8923a6f2764b", "29f5cd84-6506-4f5c-b436-3acb8235f21f" }),
                new Theme(id: "2", name: "Bonds", imagePath: "/images/Bonds.png", tagsIds: new List<string> { "c4e86988-5252-432d-97e4-84709e91b1e9", "7566fcc3-7682-47a5-b006-cff520ceacb7" }),
                new Theme(id: "3", name: "Crypto", imagePath: "/images/Crypto.png", tagsIds: new List<string> { "c4e86988-5252-432d-97e4-84709e91b1e9" }),
                new Theme(id: "4", name: "ETF", imagePath: "/images/ETF.png", tagsIds: new List<string> { "8b202bfb-d2a8-4a20-9ac2-eb004f35f09c", "fd2437cb-62ec-42c4-82f9-1866c30527b6" }),
                new Theme(id: "5", name: "Goods", imagePath: "/images/Goods.png", tagsIds: new List<string> { "c4e86988-5252-432d-97e4-84709e91b1e9" }),
                new Theme(id: "6", name: "Forex", imagePath: "/images/Forex.png", tagsIds: new List<string> { "c4e86988-5252-432d-97e4-84709e91b1e9" }),
                new Theme(id: "7", name: "Futures", imagePath: "/images/Futures.png", tagsIds: new List<string> { "c4e86988-5252-432d-97e4-84709e91b1e9" }),
                new Theme(id: "8", name: "TechAnalysis", imagePath: "/images/TechAnalysis.png", tagsIds: new List<string> { "a9155ab2-ba76-486a-9779-a90a5b6f6ab4" })
                );

            //modelBuilder.Entity<Article>().HasData(
            //    new Article(name: "Init article", 
            //                themeId: "1",
            //                inThemePostionNumber: 1,
            //                annotation: "This article is made to test the db connection", 
            //                text: "This article is very interesting, testing. This article is very interesting, testing.\n" +
            //                "This article is very interesting, testing. This article is very interesting, testing.\n" +
            //                "This article is very interesting, testing. This article is very interesting, testing.\n" +
            //                "This article is very interesting, testing. This article is very interesting, testing.\n" +
            //                "This article is very interesting, testing. This article is very interesting, testing.\n" +
            //                "This article is very interesting, testing. This article is very interesting, testing.")
            //    );
            modelBuilder.Entity<Tags>().HasData(
                new Tags(tagId: "c4e86988-5252-432d-97e4-84709e91b1e9", 
                        value:"акции"),
                new Tags(tagId: "7566fcc3-7682-47a5-b006-cff520ceacb7",
                        value: "облигации"),
                new Tags(tagId: "fd2437cb-62ec-42c4-82f9-1866c30527b6",
                        value: "фонды"),
                new Tags(tagId: "8b202bfb-d2a8-4a20-9ac2-eb004f35f09c",
                        value: "ETF"),
                new Tags(tagId: "a9155ab2-ba76-486a-9779-a90a5b6f6ab4",
                        value: "ТехАнализ"),
                new Tags(tagId: "dd44442e-a4e2-4cab-893f-8923a6f2764b",
                        value: "биржа"),
                new Tags(tagId: "29f5cd84-6506-4f5c-b436-3acb8235f21f",
                        value: "депозитарии")
                );
        }
    }
}
