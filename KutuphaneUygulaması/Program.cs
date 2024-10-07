
namespace KutuphaneUygulaması
{
    internal static class Program
    {
        public static Dictionary<string,User> userList = new Dictionary<string,User>();
        public static User activeUser;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoadUserList();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginPage());
        }

        private static void LoadUserList()
        {
            User admin = new User()
            { 
                Id = Guid.NewGuid(), 
                Name = "Admin", 
                Surname = "SURNAME", 
                Password="123456*Admin", 
                Email="admin@mail.com",
                UserType = UserType.Admin
            };
            userList.Add("admin", admin);
        }

        public static void AddUser(string userName, User user)
        {
            userList.Add(userName, user);
        }
    }
}