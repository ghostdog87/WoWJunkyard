using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WoWJunkyard.Data;
using WoWJunkyard.Data.Models;

namespace WoWJunkyard.Controllers
{
    public class CharactersController : ControllerBase
    {
        private readonly WoWDbContext _context;

        public CharactersController(WoWDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetCharacter(string characterName, string realm)
        {
            var apiKey = "USS5QIwmUuN0pouao4u871QlXFYTKX5g8C";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://EU.api.blizzard.com/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //var response = client.GetAsync("wow/character/Kazzak/chechok?locale=en_US&access_token=USS5QIwmUuN0pouao4u871QlXFYTKX5g8C").Result;
                var response = await client.GetAsync("wow/character/Kazzak/chechok?fields=items&locale=en_US&access_token=" + apiKey);
                string res = "";
                using (HttpContent content = response.Content)
                {
                    Task<string> result = content.ReadAsStringAsync();
                    res = result.Result;
                }
                return Content(res);
            }
        }
    }
}
