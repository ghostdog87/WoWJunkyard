using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace WoWJunkyard.Services
{
    public class AccessToken
    {
        [JsonProperty("access_token")]
        public string AccessTokenKey { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public string ExpiresIn { get; set; }
    }
}