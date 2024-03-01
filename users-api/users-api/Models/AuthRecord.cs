namespace users_api.Models
{
    public class AuthRecord
    {
        public int AuthRecordId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
