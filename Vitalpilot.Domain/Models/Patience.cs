namespace Vitalpilot.Domain.Models
{
    public partial class Patience : Base<Patience>, IBase
    {
        public Patience(string firstName,
            string lastName,
            string? middleName,
            Guid userId,
            int status)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.UserId = userId;
            this.Status = status;

            Prescriptions = new HashSet<Prescription>();
            Appointments = new HashSet<Appointment>();
            PatienceNotes = new HashSet<PatienceNote>();
            LabResults = new HashSet<LabResult>();
            PatienceDiseases = new HashSet<PatienceDisease>();
            Surgeries = new HashSet<Surgery>();
        }

        public override Patience CreateNew()
        {
            return new Patience(this.FirstName,
                this.LastName,
                this.MiddleName,
                this.UserId,
                this.Status);
        }

        public override void Update(Patience entity)
        {
            this.Status = entity.Status;
        }

        public override void Delete()
        {
            this.Deleted = true;
        }
    }
}