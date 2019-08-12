﻿using System;
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
using WoWJunkyard.Services;
using WoWJunkyard.Views.Models;
using WoWJunkyard.Views.Models.Enums;
using WoWJunkyard.Views.Models.Lists;

namespace WoWJunkyard.Controllers
{
    public class CharacterController : Controller
    {
        private readonly WoWDbContext _context;
        private readonly IWoWToken _woWToken;
        private readonly IMapper _mapper;


        public CharacterController(WoWDbContext context, IWoWToken woWToken,IMapper mapper)
        {
            this._context = context;
            this._woWToken = woWToken;
            this._mapper = mapper;
        }

        [HttpGet("/Characters")]
        public async Task<ActionResult> CharactersList(string characterName, string realm)
        {
            
            var apiKey = await _woWToken.GetTokenAsync();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://EU.api.blizzard.com/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var apiString = "wow/character/" + realm + "/" + characterName +
                                "?fields=items&locale=en_US&access_token=" + apiKey.AccessTokenKey;

                var response = await client.GetAsync(apiString);

                ViewBag.Realms = new RealmList().RealmNames;
                ViewBag.Races = new RaceList().RaceNames;
                ViewBag.Classes = new ClassList().ClassNames;

                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    return View(new List<CharacterListViewModel>());
                }

                using (HttpContent content = response.Content)
                {
                    CharacterInputModel inputModel = new CharacterInputModel();

                    string jsonResult = await content.ReadAsStringAsync();
                    inputModel = CharacterInputModel.FromJson(jsonResult);



                    inputModel.Items.ItemInfo.Add(inputModel.Items.Chest);
                    inputModel.Items.ItemInfo.Add(inputModel.Items.Head);
                    inputModel.Items.ItemInfo.Add(inputModel.Items.Back);
                    inputModel.Items.ItemInfo.Add(inputModel.Items.Feet);
                    inputModel.Items.ItemInfo.Add(inputModel.Items.Finger1);
                    inputModel.Items.ItemInfo.Add(inputModel.Items.Finger2);
                    inputModel.Items.ItemInfo.Add(inputModel.Items.Hands);
                    inputModel.Items.ItemInfo.Add(inputModel.Items.Legs);
                    inputModel.Items.ItemInfo.Add(inputModel.Items.MainHand);
                    inputModel.Items.ItemInfo.Add(inputModel.Items.Neck);
                    //inputModel.Items.ItemInfo.Add(inputModel.Items.OffHand);
                    inputModel.Items.ItemInfo.Add(inputModel.Items.Shoulder);
                    inputModel.Items.ItemInfo.Add(inputModel.Items.Trinket1);
                    inputModel.Items.ItemInfo.Add(inputModel.Items.Trinket2);
                    inputModel.Items.ItemInfo.Add(inputModel.Items.Waist);
                    inputModel.Items.ItemInfo.Add(inputModel.Items.Wrist);

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
        }


        [HttpGet("/Character/{id}")]
        public async Task<ActionResult> Character(int id)
        {
            var character = await _context.Characters
                .Where(x => x.Id == id)
                .Include(x => x.Items)
                .Include(x => x.Items.ItemInfos)
                .FirstAsync();

            ;
            return View(character);
        }
    }
}
