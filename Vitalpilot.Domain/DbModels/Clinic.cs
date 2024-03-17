using System.ComponentModel.DataAnnotations;

namespace Vitalpilot.Domain.Models
{
    public partial class Clinic
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
        public Guid HospitalId { get; private set; }
        public Guid Name { get; private set; }
        public string? Description { get; private set; }
        public bool IsActive { get; private set; }
        public string? HostpitalSection { get; private set; }

        public virtual ICollection<Doctor> Doctors { get; private set; }
        public Hospital Hospital { get; private set; }
    }
}