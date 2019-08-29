using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WoWJunkyard.Services
{
    public class WoWClient : IWoWClient
    {
        private readonly IWoWToken _woWToken;

        public WoWClient(IWoWToken woWToken)
        {
            this._woWToken = woWToken;
        }

        public async Task<HttpResponseMessage> GetCharacterAsync(string realm,string characterName)
        {
            var apiKey = await _woWToken.GetTokenAsync();
            var realmToLower = realm?.ToLower();
            var characterNameToLower = characterName?.ToLower();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://EU.api.blizzard.com/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var apiString = "wow/character/" + realmToLower + "/" + characterNameToLower +
                                "?locale=en_US&access_token=" + apiKey.AccessTokenKey;

                var response = await client.GetAsync(apiString);

                return response;
            }
        }

        public async Task<HttpResponseMessage> GetCharacterItemsAsync(string realm, string characterName)
        {
            var apiKey = await _woWToken.GetTokenAsync();
            var realmToLower = realm?.ToLower();
            var characterNameToLower = characterName?.ToLower();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://EU.api.blizzard.com/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var apiString = "profile/wow/character/" + realmToLower + "/" + characterNameToLower +
                                "/equipment?namespace=profile-eu&locale=en_US&access_token=" + apiKey.AccessTokenKey;

                var response = await client.GetAsync(apiString);

                return response;
            }
        }
        public async Task<HttpResponseMessage> GetCharacterMythicPlusAsync(string realm, string characterName)
        {
            var apiKey = await _woWToken.GetTokenAsync();
            var realmToLower = realm?.ToLower();
            var characterNameToLower = characterName?.ToLower();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://EU.api.blizzard.com/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var apiString = "profile/wow/character/" + realmToLower + "/" + characterNameToLower +
                                "/mythic-keystone-profile/season/3?namespace=profile-eu&locale=en_US&access_token=" + apiKey.AccessTokenKey;
                var response = await client.GetAsync(apiString);

                return response;
            }
        }
    }
}