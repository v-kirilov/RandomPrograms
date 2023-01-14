namespace Login_Task.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Username = "admin", EmailAddress = "jason.admin@email.com", Password = "123", GivenName = "Jason", Surname = "Bryant", Role = "Administrator" },
            new UserModel() { Username = "seller", EmailAddress = "elyse.seller@email.com", Password = "321", GivenName = "Elyse", Surname = "Lambert", Role = "Seller" },
        };
    }
}
