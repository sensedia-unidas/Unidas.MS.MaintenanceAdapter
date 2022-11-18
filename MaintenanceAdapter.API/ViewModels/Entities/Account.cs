namespace MaintenanceAdapter.API.ViewModels.Entities

{
    public class Account
    {
        public Account(string password, string username)
        {
            Password = password;
            Username = username;
        }

        public string Password { get; set; }

        public string Username { get; set; }
    }
}
