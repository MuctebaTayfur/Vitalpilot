using System.ComponentModel.DataAnnotations;

namespace Vitalpilot.Domain.Models
{
    public partial class Hospital
    {
        public Guid UniqueId { get; private set; }
        public long FriendlyId { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public Guid CreatedById { get; private set; }
        public string CreatedBy { get; private set; } = null!;
        public DateTime LastModifiedDate { get; private set; }
        public Guid LastModifiedById { get; private set; }
        public string LastModifiedBy { get; private set; } = null!;
        public bool Deleted { get; private set; }
        public byte[] RowVersion { get; private set; } = null!;

        public string Name { get; private set; }
        public string City { get; private set; }
        public string Address { get; private set; }
        public string PhoneNumber { get; private set; }
        public string? Website { get; private set; }

        public virtual ICollection<Clinic> Clinics { get; private set; }
        public virtual ICollection<User> Users { get; private set; }
    }
}