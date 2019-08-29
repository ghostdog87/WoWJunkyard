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
using WoWJunkyard.Views.ViewModels;
using WoWJunkyard.Views.ViewModels.ViewBags;

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
            ViewBag.Realms = new RealmList().RealmNames;
            ViewBag.Races = new RaceList().RaceNames;
            ViewBag.Classes = new ClassList().ClassNames;
            ViewBag.Factions = new FactionList().FactionNames;

            if (!string.IsNullOrEmpty(characterName) && (characterName.Length < 2 || characterName.Length > 12))
            {
                ModelState.AddModelError("", "Character name must be between 2 and 12 characters!");
                return View(new List<CharacterListViewModel>());
            }

            var characterExistInRealm = await
                _context.Characters.Where(x => x.Name == characterName && x.Realm == realm).ToListAsync();

            if (characterExistInRealm.Count > 0)
            {
                var characterList = _mapper.Map<List<CharacterListViewModel>>(characterExistInRealm);

                return View(characterList);
            }

            if (realm == "Realm")
            {
                var characterExist = await
                    _context.Characters.Where(x => x.Name == characterName).ToListAsync();

                if (characterExist.Count > 0)
                {
                    var characterList = _mapper.Map<List<CharacterListViewModel>>(characterExist);

                    return View(characterList);
                }
            }

            var characterApi = await _wowClient.GetCharacterAsync(realm, characterName);

            if (characterApi.StatusCode == HttpStatusCode.NotFound)
            {
                return View(new List<CharacterListViewModel>());
            }

            using (HttpContent content = characterApi.Content)
            {
                string jsonResult = await content.ReadAsStringAsync();
                var inputModel = CharacterInputModel.FromJson(jsonResult);
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

                string jsonResult = await content.ReadAsStringAsync();
                var inputModel = CharacterItemsInputModel.FromJson(jsonResult);

                var characterItems = _mapper.Map<List<EquippedItem>>(inputModel.EquippedItems);

                var character = await _context.Characters
                    .Where(x => x.Id == id)
                    .Include(x => x.EquippedItems)
                    .FirstOrDefaultAsync();

                if (characterItems != null)
                {
                    foreach (var characterItem in characterItems)
                    {
                        var item = await _context.EquippedItems
                            .Include(x => x.Item)
                            .Include(x => x.Slot)
                            .FirstOrDefaultAsync(x =>
                                x.Item.ItemIdNumber == characterItem.Item.ItemIdNumber);

                        if (item != null)
                        {
                            var slot = await _context.EquippedItems
                                .Include(x => x.Slot)
                                .FirstOrDefaultAsync(x => x.Slot.Name == item.Slot.Name);

                            if (slot != null)
                            {
                                item.Slot = slot.Slot;
                            }
                        }

                        character.EquippedItems.Add(item ?? characterItem);
                    }

                    await _context.SaveChangesAsync();
                }

                return View(character);
            }
        }
    }
}
