namespace ShopAdmin.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _user;

        public UserAccountService() 
        {
            _user= new List<UserAccount>
            {
                new UserAccount { UserName = "admin",Password = "1234", Role = "Administrator" },
                new UserAccount { UserName = "user", Password = "1234", Role = "User" }
             };   
        }
        public UserAccount? GetByUserName(string userName) 
        {
      
            return _user.FirstOrDefault(x => x.UserName == userName);
        }
        
    }
}
