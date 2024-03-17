namespace Vitalpilot.Domain.Models
{
    public partial class Appointment : Base<Appointment>, IBase
    {
        public Appointment(DateTime appointmentDate,
            Guid patienceId,
            Guid doctorId,
            int status,
            string? patienceHistory)
        {
            this.AppointmentDate = appointmentDate;
            this.PatienceId = patienceId;
            this.DoctorId = doctorId;
            this.Status = status;
            this.PatienceHistory = patienceHistory;
        }

        public override Appointment CreateNew()
        {
            return new Appointment(this.AppointmentDate,
                this.PatienceId,
                this.DoctorId,
                this.Status,
                this.PatienceHistory);
        }

        public override void Update(Appointment entity)
        {
            this.AppointmentDate = entity.AppointmentDate;
            this.PatienceId = entity.PatienceId;
            this.DoctorId = entity.DoctorId;
            this.Status = entity.Status;
            this.PatienceHistory = entity.PatienceHistory;
        }

        public override void Delete()
        {
            this.Deleted = true;
        }
    }
}