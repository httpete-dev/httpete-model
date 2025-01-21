namespace HttPete.Model
{
    public class WaitlistEntryDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string? ClientIp { get; set; }

        public WaitlistEntryDTO(string name, string email, string? ip)
        {
            this.Name = name;
            this.Email = email;
            this.ClientIp = ip;
        }
    }
}