using Abp.Domain.Entities;

namespace HttPete.Model
{
    public class WaitlistEntry : Entity, IEntity
    {
        public string Name { get; set; } = "John Doe";

        public string Email { get; set; } = "john.doe@httpete.dev";

        public string? ClientIp { get; set; }

        public DateTime SignUpDate { get; set; }

        public WaitlistEntry()
        {
            this.SignUpDate = DateTime.UtcNow;
        }

        public WaitlistEntry(WaitlistEntryDTO dto)
        {
            this.Name = dto.Name;
            this.Email = dto.Email;
            this.ClientIp = dto.ClientIp;
            this.SignUpDate = DateTime.UtcNow;
        }
    }
}