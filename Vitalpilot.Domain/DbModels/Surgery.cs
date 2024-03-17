using System.ComponentModel.DataAnnotations;

namespace Vitalpilot.Domain.Models
{
    public partial class Surgery
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
        public Guid DoctorId { get; private set; }
        public Guid PatienceId { get; private set; }
        public string? Description { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime? EndDate { get; private set; }
        public bool? Status { get; private set; }

        public Doctor Doctor { get; set; }
        public Patience Patience { get; set; }
    }
}