namespace Vitalpilot.Domain.Models
{
    public partial class Doctor : Base<Doctor>, IBase
    {
        public Doctor(string firstName,
            string? middleName,
            string lastName,
            string title,
            Guid clinicId,
            Guid userId)

        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Title = title;
            this.ClinicId = clinicId;
            this.UserId = userId;

            Appointments = new List<Appointment>();
            Surgeries = new List<Surgery>();
        }

        public override Doctor CreateNew()
        {
            return new Doctor(this.FirstName,
                this.MiddleName,
                this.LastName,
                this.Title,
                this.ClinicId,
                this.UserId
            );
        }

        public override void Update(Doctor entity)
        {
            this.FirstName = entity.FirstName;
            this.MiddleName = entity.MiddleName;
            this.LastName = entity.LastName;
            this.Title = entity.Title;
            this.ClinicId = entity.ClinicId;
            this.UserId = entity.UserId;
        }

        public override void Delete()
        {
            this.Deleted = true;
        }
    }
}