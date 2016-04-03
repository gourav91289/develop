namespace com.boutique.Entity.Model
{
    public class Settings
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Key { get; set; }
        public string LoggedUserId { get; set; }
        public Boutique boutique { get; set; }
    }
}
