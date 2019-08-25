using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WoWJunkyard.Data;
using WoWJunkyard.Models.News;
using WoWJunkyard.Views.Models;
using WoWJunkyard.Views.ViewModels;

namespace WoWJunkyard.Controllers
{
    public class NewsController : Controller
    {
        private readonly WoWDbContext _context;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _hostingEnvironment;

        public NewsController(WoWDbContext context, IMapper mapper, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _mapper = mapper;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: News
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.News.ToListAsync());
        }

        // GET: News/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .FirstOrDefaultAsync(m => m.Id == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // GET: News/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: News/Create
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,PostedOn,Image")] NewsViewModel news)
        {
            if (ModelState.IsValid)
            {
                var newsResult = _mapper.Map<News>(news);
                newsResult.PostedOn = DateTime.UtcNow;

                _context.Add(newsResult);
                await _context.SaveChangesAsync();

                var currentNews = await _context.News.FirstOrDefaultAsync(x => x.PostedOn == newsResult.PostedOn);
                var currentId = currentNews.Id;

                //set images start
                string webRootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;

                if (files.Count > 0)
                {
                    var uploads = Path.Combine(webRootPath, @"img\news");
                    var extension = Path.GetExtension(files[0].FileName);

                    using (var filesStream = new FileStream(Path.Combine(uploads, currentId + extension), FileMode.Create))
                    {
                        files[0].CopyTo(filesStream);
                    }
                    newsResult.Image = @"\img\news\" + currentId + extension;
                }
                else
                {
                    return View(news);
                }
                //set images end

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(news);
        }

        // GET: News/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News.FindAsync(id);
            if (news == null)
            {
                return NotFound();
            }

            var newsResult = _mapper.Map<NewsViewModel>(news);

            return View(newsResult);
        }

        // POST: News/Edit/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,PostedOn,Image")] NewsViewModel news)
        {
            if (id != news.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var newsResult = _mapper.Map<News>(news);
                    newsResult.PostedOn = DateTime.UtcNow;

                    _context.Update(newsResult);
                    await _context.SaveChangesAsync();

                    var currentNews = await _context.News.FirstOrDefaultAsync(x => x.PostedOn == newsResult.PostedOn);
                    var currentId = currentNews.Id;

                    //set images start
                    string webRootPath = _hostingEnvironment.WebRootPath;
                    var files = HttpContext.Request.Form.Files;

                    if (files.Count > 0)
                    {
                        var uploads = Path.Combine(webRootPath, @"img\news");
                        var extension = Path.GetExtension(files[0].FileName);
                        System.IO.File.Delete(webRootPath+@"\img\news\" + currentId + extension);

                        using (var filesStream = new FileStream(Path.Combine(uploads, currentId + extension), FileMode.Create))
                        {
                            files[0].CopyTo(filesStream);
                        }
                        
                        newsResult.Image = @"\img\news\" + currentId + extension;
                    }
                    else
                    {
                        return View(news);
                    }
                    //set images end

                    await _context.SaveChangesAsync();
                    //return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsExists(news.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(news);
        }

        // GET: News/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .FirstOrDefaultAsync(m => m.Id == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // POST: News/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var news = await _context.News.FindAsync(id);
            _context.News.Remove(news);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewsExists(int id)
        {
            return _context.News.Any(e => e.Id == id);
        }
    }
}
