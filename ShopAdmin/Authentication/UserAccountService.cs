using DAL;
using Entities;

namespace ShopAdmin.Authentication
{
    public class UserAccountService
    {
        //private List<UserAccount> _user = new List<UserAccount>();

        //public async Task<List<EntBusinessOwner>> AuthenticateUser(string username, string role)
        //{
        //    List<EntBusinessOwner> authenticatedUsers = await DalBusinessOwner.Authenticate(username, role);
        //    return authenticatedUsers;
        //}
        public async Task<Entities.UserAccount>? GetByUserName(string _userName, int _password)
        
        {
         
           var ua=await DalBusinessOwner.Authenticate(_userName, _password);
            return ua;
                //_user.FirstOrDefault(x => x.UserName == userName);
          }

    }
}
