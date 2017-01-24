namespace MyAppStore.Site.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Account { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }
    }
}