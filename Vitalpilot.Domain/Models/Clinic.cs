namespace Vitalpilot.Domain.Models
{
    public partial class Clinic : Base<Clinic>, IBase
    {
        public Clinic(Guid hospitalId,
            string name,
            bool isActive,
            string? description)
        {
            this.HospitalId = hospitalId;
            this.Name = name;
            this.Description = description;
            this.IsActive = isActive;

            Doctors = new HashSet<Doctor>();
            Appointments = new HashSet<Appointment>();
        }

        public override Clinic CreateNew()
        {
            return new Clinic(this.HospitalId,
                this.Name,
                this.IsActive,
                this.Description);
        }

        public override void Update(Clinic entity)
        {
            this.HospitalId = entity.HospitalId;
            this.Name = entity.Name;
            this.Description = entity.Description;
            this.IsActive = entity.IsActive;
        }

        public override void Delete()
        {
            this.Deleted = true;
        }
    }
}