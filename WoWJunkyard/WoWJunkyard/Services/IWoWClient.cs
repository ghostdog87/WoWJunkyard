using System.Net.Http;
using System.Threading.Tasks;

namespace WoWJunkyard.Services
{
    public interface IWoWClient
    {
        Task<HttpResponseMessage> GetCharacterAsync(string realm, string characterName);

        Task<HttpResponseMessage> GetCharacterItemsAsync(string realm, string characterName);

        Task<HttpResponseMessage> GetCharacterMythicPlusAsync(string realm, string characterName);
    }
}