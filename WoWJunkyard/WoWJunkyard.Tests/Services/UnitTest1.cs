using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using WoWJunkyard.Data;
using WoWJunkyard.Models.News;
using WoWJunkyard.Services;
using Xunit;

namespace WoWJunkyard.Tests.Services
{
    public class UnitTest1
    {
        //Task<List<News>> GetAllNews();
        //Task<News> GetNews(int? id);
        //Task<int> CreateNews(News news);
        //Task<int> SaveNews();
        //Task<News> GetNewsByPostOn(DateTime postedOn);
        //Task<int> UpdateNews(News news);
        //Task<int> DeleteNews(int? id);
        //Task<bool> FindNews(int? id);

        [Fact]
        public async void TestGetAllNews_TestWithData_ShouldReturnAllNews()
        {
            var options = new DbContextOptionsBuilder<WoWDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var context = new WoWDbContext(options);
            SeedData(context);

            var newsService = new NewsService(context);

            var expectedData = GetTestData();

            var actualData = await newsService.GetAllNews();

            Assert.Equal(expectedData.Count, actualData.Count);

            foreach (var actualNews in actualData)
            {
                Assert.True(expectedData.Any(news =>
                    actualNews.Description == news.Description
                    && actualNews.Image == news.Image
                    && actualNews.PostedOn == news.PostedOn
                    && actualNews.Title == news.Title),
                    "GetAllNews does not return correct news!");
            }
        }

        [Fact]
        public async void TestGetAllNews_TestWithoutData_ShouldReturnEmptyList()
        {
            var options = new DbContextOptionsBuilder<WoWDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var context = new WoWDbContext(options);

            var newsService = new NewsService(context);

            var actualData = await newsService.GetAllNews();

            Assert.True(actualData.Count == 0, "List should be empty");
        }

        [Fact]
        public async void TestGetNewsById_TestWithData_ShouldReturnNewsById()
        {
            var options = new DbContextOptionsBuilder<WoWDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var context = new WoWDbContext(options);
            SeedData(context);

            var newsService = new NewsService(context);

            var expectedData = GetTestData().Find(x=>x.Id == 1);

            var actualData = await newsService.GetNews(1);

            var actualDataJson = JsonConvert.SerializeObject(actualData);
            var expectedDataJson = JsonConvert.SerializeObject(expectedData);
            Assert.Equal(expectedDataJson, actualDataJson);
        }

        [Fact]
        public async void TestGetNewsById_TestWithoutData_ShouldReturnError()
        {
            var options = new DbContextOptionsBuilder<WoWDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var context = new WoWDbContext(options);

            var newsService = new NewsService(context);


            var actualData = await newsService.GetNews(1);

            Assert.True(actualData == null);
        }

        [Fact]
        public async void TestCreateNews_TestWithCorrectData_ShouldReturnCorrectResult()
        {
            var options = new DbContextOptionsBuilder<WoWDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var context = new WoWDbContext(options);

            var newsService = new NewsService(context);


            var actualData = await newsService.CreateNews(new News()
            {
                Description = "<b>testing description</b>",
                Image = "\\img\\news\\1.jpg",
                PostedOn = new DateTime(),
                Title = "goshko"
            });

            Assert.True(actualData == 1);
        }


        [Fact]
        public async void TestSaveNews_TestWithData_ShouldReturnCorrectResult()
        {
            var options = new DbContextOptionsBuilder<WoWDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var context = new WoWDbContext(options);
            SeedData(context);

            var newsService = new NewsService(context);

            var news = await newsService.GetNews(1);
            news.Title = "stefchno";
            await newsService.SaveNews();

            var actualData = await newsService.GetNews(1);

            Assert.True(actualData.Title == "stefchno");
        }

        [Fact]
        public async void TestGetNewsByID_TestWithData_ShouldReturnNotEqual()
        {
            var options = new DbContextOptionsBuilder<WoWDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var context = new WoWDbContext(options);
            SeedData(context);

            var newsService = new NewsService(context);

            var expectedData = GetTestData().Find(x => x.Id == 1);

            var actualData = await newsService.GetNews(2);

            var actualDataJson = JsonConvert.SerializeObject(actualData);
            var expectedDataJson = JsonConvert.SerializeObject(expectedData);
            Assert.NotEqual(expectedDataJson, actualDataJson);
        }

        [Fact]
        public async void TestGetNewsByID_TestWithNonExistantID_ShouldReturnNull()
        {
            var options = new DbContextOptionsBuilder<WoWDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var context = new WoWDbContext(options);
            SeedData(context);

            var newsService = new NewsService(context);

            var actualData = await newsService.GetNews(3);

            Assert.Null(actualData);
        }

        [Fact]
        public async void TestDeleteNewsByID_TestWithData_ShouldReturnTrue()
        {
            var options = new DbContextOptionsBuilder<WoWDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var context = new WoWDbContext(options);
            SeedData(context);

            var newsService = new NewsService(context);

            var actualData = await newsService.DeleteNews(1);

            Assert.Equal(1,actualData);
        }

        private void SeedData(WoWDbContext context)
        {
            context.News.AddRange(GetTestData());
            context.SaveChanges();
        }

        private List<News> GetTestData()
        {
            return new List<News>
            {
                new News()
                {
                    Id = 1,
                    Description = "<b>testing description</b>",
                    Image = "\\img\\news\\1.jpg",
                    PostedOn = new DateTime(),
                    Title = "goshko"
                },
                new News()
                {
                    Id = 2,
                    Description = "<b>testing another description</b>",
                    Image = "\\img\\news\\2.jpg",
                    PostedOn = new DateTime(),
                    Title = "goshko2"
                }
            };
        }
    }
}
