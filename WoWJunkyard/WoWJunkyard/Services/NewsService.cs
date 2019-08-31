using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WoWJunkyard.Data;
using WoWJunkyard.Models.News;

namespace WoWJunkyard.Services
{
    public class NewsService : INewsService
    {
        private readonly WoWDbContext _context;

        public NewsService(WoWDbContext context)
        {
            _context = context;
        }

        public async Task<List<News>> GetAllNews()
        {
            return await _context.News.ToListAsync();
        }

        public async Task<News> GetNews(int? id)
        {
            return await _context.News.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<int> CreateNews(News news)
        {
            _context.Add(news);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> SaveNews()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<News> GetNewsByPostOn(DateTime postedOn)
        {
            return await _context.News.FirstOrDefaultAsync(x => x.PostedOn == postedOn);
        }


        public async Task<int> UpdateNews(News news)
        {
            _context.Update(news);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteNews(int? id)
        {
            var news = await _context.News.FindAsync(id);
            _context.News.Remove(news);
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> FindNews(int? id)
        {
            return await _context.News.AnyAsync(e => e.Id == id);
        }
    }
}