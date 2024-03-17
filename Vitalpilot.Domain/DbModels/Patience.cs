using System.ComponentModel.DataAnnotations;

namespace Vitalpilot.Domain.Models
{
    public partial class Patience
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
        public string FirstName { get; private set; }
        public string? MiddleName { get; private set; }
        public string LastName { get; private set; }
        public Guid UserId { get; private set; }
        public int Status { get; private set; }

        public virtual User User { get; private set; }
        public virtual ICollection<Prescription> Prescriptions { get; private set; }
        public virtual ICollection<Surgery> Surgeries { get; private set; }
        public virtual ICollection<Appointment> Appointments { get; private set; }
        public virtual ICollection<PatienceNote> PatienceNotes { get; private set; }
        public virtual ICollection<LabResult> LabResults { get; private set; }
        public virtual ICollection<PatienceDisease> PatienceDiseases { get; private set; }
    }
}