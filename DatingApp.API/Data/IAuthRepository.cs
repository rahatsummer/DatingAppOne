using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
         Task<tblUser> Register(tblUser user, string password);

         Task<tblUser> Login(string username, string password);

         Task<bool> UserExist(string username);
    }
}