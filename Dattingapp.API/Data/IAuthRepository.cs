using System.Threading.Tasks;
using Dattingapp.API.Models;

namespace Dattingapp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         
         Task<User> Login(string Username, string password);

         Task<bool> UserExists(string username);
         
    }
}