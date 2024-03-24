using EducationPageWebAPI.Models;
using Microsoft.EntityFrameworkCore;
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Article>().HasData(
                new Article(name: "Init article", 
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
