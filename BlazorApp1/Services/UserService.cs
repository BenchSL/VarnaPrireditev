using BlazorApp1.Models;
using BlazorApp1.Database;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public class UserService
    {
        public FormContext DbContext = new FormContext();

        public async Task<bool> LoginUser(string username, string pass)
        {
            await Task.Delay(0);

            User u1 = new();

            foreach(var i in DbContext.Users)
            {
                if(i.UserName == username & i.Password == pass)
                {
                    return true;
                }
            }

            return false;
        }

        public async Task<User> GetUser(string userName)
        {
            User u1 = new();

            foreach(var i in DbContext.Users)
            {
                if (i.UserName == userName)
                {
                    u1 = i;
                }
            }
            return await DbContext.Users.FindAsync(u1);
        }
       
    }
}
