namespace Vitalpilot.Domain.Models
{
    public partial class Prescription : Base<Prescription>, IBase
    {
        public Prescription(Guid patienceId,
            Guid appointmentId,
            string? description)
        {
            this.PatienceId = patienceId;
            this.AppointmentId = appointmentId;
            this.Description = description;
        }

        public override Prescription CreateNew()
        {
            return new Prescription(this.PatienceId,
                this.AppointmentId,
                this.Description);
        }

        public override void Update(Prescription entity)
        {
            this.PatienceId = entity.PatienceId;
            this.AppointmentId = entity.AppointmentId;
            this.Description = entity.Description;
        }

        public override void Delete()
        {
            this.Deleted = true;
        }
    }
}