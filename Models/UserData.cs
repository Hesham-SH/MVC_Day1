namespace MVC_Day1.Models
{
    public static class UserData
    {
        public static List<UserModel> users = new List<UserModel>();

        public static void AddUser(UserModel User)
        {
            users.Add(User);
        }

        public static List<UserModel> GetUsers()
        {
            return users;
        }

    }
}
