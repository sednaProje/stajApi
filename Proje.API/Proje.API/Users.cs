namespace Proje.API
{
    public class Users
    {
        public int ID { get; set; }
        public string Token { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
    }
}
