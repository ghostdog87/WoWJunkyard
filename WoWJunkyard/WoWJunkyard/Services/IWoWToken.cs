using System.Threading.Tasks;

namespace WoWJunkyard.Services
{
    public interface IWoWToken
    {
        Task<AccessToken> GetTokenAsync();
    }
}