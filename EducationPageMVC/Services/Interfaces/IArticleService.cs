﻿using EducationPageWebAPI.Models;

namespace EducationPageMVC.Services.Interfaces
{
    public interface IArticleService
    {
        Task<IEnumerable<Article>> GetAll();
        Task<IEnumerable<Article>> GetAllArticlesByThemeId(int themeId);
    }
}
