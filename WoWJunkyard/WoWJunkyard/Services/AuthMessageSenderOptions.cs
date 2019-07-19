namespace WoWJunkyard.Services
{
    public class AuthMessageSenderOptions : IAuthMessageSenderOptions
    {
        public string SendGridUser { get; set; }
        public string SendGridKey { get; set; }
    }
}