using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WoWJunkyard.Models.News;

namespace WoWJunkyard.Services
{
    public interface INewsService
    {
        Task<List<News>> GetAllNews();

        Task<News> GetNews(int? id);

        Task<int> CreateNews(News news);

        Task<int> SaveNews();

        Task<News> GetNewsByPostOn(DateTime postedOn);

        Task<int> UpdateNews(News news);

        Task<int> DeleteNews(int? id);

        Task<bool> FindNews(int? id);
    }
}