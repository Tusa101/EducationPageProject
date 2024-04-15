using EducationPageMVC.Services;
using EducationPageMVC.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient<IArticleService, ArticleService>(c => c.BaseAddress = new Uri("http://localhost:5002"));
builder.Services.AddHttpClient<IThemeService, ThemeService>(c => c.BaseAddress = new Uri("http://localhost:5002"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
