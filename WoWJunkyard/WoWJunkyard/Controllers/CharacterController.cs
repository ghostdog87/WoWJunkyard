using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WoWJunkyard.Data;
using WoWJunkyard.Data.Models;
using WoWJunkyard.Models.Character;
using WoWJunkyard.Services;
using WoWJunkyard.Views.Models;
using WoWJunkyard.Views.Models.Enums;
using WoWJunkyard.Views.Models.Lists;
using WoWJunkyard.Views.ViewModels;

namespace WoWJunkyard.Controllers
{
    public class CharacterController : Controller
    {
        private readonly WoWDbContext _context;
        private readonly IMapper _mapper;
        private readonly IWoWClient _wowClient;


        public CharacterController(WoWDbContext context, IMapper mapper, IWoWClient wowClient)
        {
            this._context = context;
            this._mapper = mapper;
            this._wowClient = wowClient;
        }

        [HttpGet("/Characters")]
        public async Task<ActionResult> CharactersList(string characterName, string realm)
        {
            
            var characterApi = await _wowClient.GetCharacterAsync(realm, characterName);

            ViewBag.Realms = new RealmList().RealmNames;
            ViewBag.Races = new RaceList().RaceNames;
            ViewBag.Classes = new ClassList().ClassNames;

            if (characterApi.StatusCode == HttpStatusCode.NotFound)
            {
                return View(new List<CharacterListViewModel>());
            }

            using (HttpContent content = characterApi.Content)
            {
                var inputModel = new CharacterInputModel();

                string jsonResult = await content.ReadAsStringAsync();
                inputModel = CharacterInputModel.FromJson(jsonResult);

                var character = _mapper.Map<Character>(inputModel);

                _context.Characters.Add(character);
                await _context.SaveChangesAsync();
            }

            var characters = _context.Characters
                .Where(x => x.Name == characterName)
                .ToList();

            var result = _mapper.Map<List<CharacterListViewModel>>(characters);

            return View(result);
            
        }


        public async Task<ActionResult> Character(int id,string realm,string characterName)
        {
            var characterApi = await _wowClient.GetCharacterItemsAsync(realm, characterName);

            using (HttpContent content = characterApi.Content)
            {
                var inputModel = new CharacterItemsInputModel();

                string jsonResult = await content.ReadAsStringAsync();
                inputModel = CharacterItemsInputModel.FromJson(jsonResult);

                var characterItems = _mapper.Map<List<EquippedItem>>(inputModel.EquippedItems);

                var character = await _context.Characters
                    .Where(x => x.Id == id)
                    .Include(x => x.EquippedItems)
                    .FirstAsync();

                if (characterItems != null)
                {
                    character.EquippedItems.AddRange(characterItems);
                }

                await _context.SaveChangesAsync();

                return View(character);
            }
        }
    }
}
