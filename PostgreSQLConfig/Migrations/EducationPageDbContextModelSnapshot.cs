﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PostgreSQLConfig;

#nullable disable

namespace PostgreSQLDb.Migrations
{
    [DbContext(typeof(EducationPageDbContext))]
    partial class EducationPageDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EducationPageWebAPI.Models.Article", b =>
                {
                    b.Property<string>("ArticleId")
                        .HasColumnType("text");

                    b.Property<string>("Annotation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ThemeId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ArticleId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            ArticleId = "a8b5a9da-d014-48ca-a138-cd4ee4d52795",
                            Annotation = "This article is made to test the db connection",
                            Name = "Init article",
                            Text = "This article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.\nThis article is very interesting, testing. This article is very interesting, testing.",
                            ThemeId = "1"
                        });
                });

            modelBuilder.Entity("Models.Models.Theme", b =>
                {
                    b.Property<string>("ThemeId")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ThemeId");

                    b.ToTable("Themes");

                    b.HasData(
                        new
                        {
                            ThemeId = "2",
                            Name = "Bonds"
                        },
                        new
                        {
                            ThemeId = "3",
                            Name = "Crypto"
                        },
                        new
                        {
                            ThemeId = "4",
                            Name = "ETF"
                        },
                        new
                        {
                            ThemeId = "5",
                            Name = "Goods"
                        },
                        new
                        {
                            ThemeId = "6",
                            Name = "Forex"
                        },
                        new
                        {
                            ThemeId = "7",
                            Name = "Futures"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
