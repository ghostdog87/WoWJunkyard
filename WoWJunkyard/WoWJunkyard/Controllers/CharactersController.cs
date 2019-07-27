using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharprWowApi;
using WoWJunkyard.Data;
using WoWJunkyard.Data.Models;
using WoWJunkyard.Services;

namespace WoWJunkyard.Controllers
{
    public class CharactersController : ControllerBase
    {
        private readonly WoWDbContext _context;

        public CharactersController(WoWDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> GetCharacter(string characterName, string realm)
        {
            
            WoWToken wowToken = new WoWToken();

            var apiKey = await wowToken.GetToken();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://EU.api.blizzard.com/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("wow/character/Kazzak/chechok?fields=items&locale=en_US&access_token=" + apiKey.AccessTokenKey);
                string res = "";
                using (HttpContent content = response.Content)
                {
                    Task<string> result = content.ReadAsStringAsync();
                    res = result.Result;
                }
                return Content(res);
            }

            //var client = new WowClient(Region.EU, Locale.en_GB, apiKey);

            //var characterOne = await client.GetCharacterAsync("Durvoto", CharacterOptions.None, "Kazzak");

            //return Content(characterOne.ToString());
        }
    }
}
