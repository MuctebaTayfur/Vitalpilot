namespace Vitalpilot.Domain.Models
{
    public partial class Surgery : Base<Surgery>, IBase
    {
        public Surgery(Guid doctorId,
            Guid patienceId,
            DateTime startDate,
            DateTime? endDate,
            string? description)
        {
            this.DoctorId = doctorId;
            this.PatienceId = patienceId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Description = description;
        }

        public override Surgery CreateNew()
        {
            return new Surgery(this.DoctorId,
                this.PatienceId,
                this.StartDate,
                this.EndDate,
                this.Description);
        }

        public override void Update(Surgery entity)
        {
            this.DoctorId = entity.DoctorId;
            this.PatienceId = entity.PatienceId;
            this.StartDate = entity.StartDate;
            this.EndDate = entity.EndDate;
            this.Description = entity.Description;
        }

        public override void Delete()
        {
            this.Deleted = true;
        }
    }
}