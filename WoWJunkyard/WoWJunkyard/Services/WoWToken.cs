using System;
using System.Collections.Immutable;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WoWJunkyard.Services
{
    public class WoWToken
    {

        private const string ClientId = "31862b71351440cea1b783c37e872a6a";
        private const string ClientSecret = "T8LaE8jvwp1q6TCLMvB5zs7GRikaRRLb";

        public WoWToken()
        {
        }

        public async Task<AccessToken> GetToken()
        {

            using (var client = new HttpClient())
            {
                string pass = Convert.ToBase64String(Encoding.ASCII.GetBytes(ClientId + ":" + ClientSecret));

                client.BaseAddress = new Uri("https://eu.battle.net/oauth/token");

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", pass);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                string res = "";

                HttpContent content = new StringContent(res, Encoding.UTF8, "application/x-www-form-urlencoded");

                var post = await client.PostAsync("?grant_type=client_credentials", content);

                string responseBody = await post.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<AccessToken>(responseBody);
            }
        }
    }
}