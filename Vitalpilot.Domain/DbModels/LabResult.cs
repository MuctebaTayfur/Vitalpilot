using System.ComponentModel.DataAnnotations;

namespace Vitalpilot.Domain.Models
{
    public partial class LabResult
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
        public Guid PatienceId { get; private set; }
        public Guid? FileId { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime? EndDate { get; private set; }

        public Patience Patience { get; private set; } = null!;
        public File? File { get; private set; }
    }
}