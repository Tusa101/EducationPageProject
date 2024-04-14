using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.DependencyInjection;
using PostgreSQLConfig;
using PostgreSQLConfig.DbInitializer;
using PostgreSQLData.Repository;
using PostgreSQLData.Repository.IRepository;
using PostgreSQLDb.Repository;
using PostgreSQLDb.Repository.IRepository;
using System.Threading;
using System.Web.Http;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        // Register Web API routing support before anything else
        //GlobalConfiguration.Configure(WebApiConfig.Register);
        // Add services to the container.

        builder.Services.AddControllers();
        var a = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<EducationPageDbContext>(options =>
        {
            options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"), builder =>
            {
                builder.MigrationsHistoryTable(HistoryRepository.DefaultTableName, "public");
                builder.CommandTimeout((int)TimeSpan.FromMinutes(3).TotalSeconds);
                builder.EnableRetryOnFailure(2);
                builder.MigrationsAssembly(typeof(EducationPageDbContext).Assembly.FullName);
            });

        });
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        
        builder.Services.AddScoped<IDbInitializer, DbInitializer>();
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        builder.Services.AddScoped<IArticleRepository, ArticleRepository>();
        builder.Services.AddScoped<IThemeRepository, ThemeRepository>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
        app.UseAuthorization();
        SeedDatabase();
        //app.MapControllers();

        app.Run();

        void SeedDatabase()
        {
            using (var scope = app.Services.CreateScope())
            {
                var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
                dbInitializer.Initialize();
            }
        }
    }
    
}