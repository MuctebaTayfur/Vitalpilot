namespace Vitalpilot.Domain.Models
{
    public partial class Clinic : Base<Clinic>, IBase
    {
        public Clinic(Guid hospitalId,
            Guid name,
            bool isActive,
            string? description,
            string? hostpitalSection)
        {
            this.HospitalId = hospitalId;
            this.Name = name;
            this.Description = description;
            this.IsActive = isActive;
            this.HostpitalSection = hostpitalSection;

            Doctors = new HashSet<Doctor>();
        }

        public override Clinic CreateNew()
        {
            return new Clinic(this.HospitalId,
                this.Name,
                this.IsActive,
                this.Description,
                this.HostpitalSection);
        }

        public override void Update(Clinic entity)
        {
            this.HospitalId = entity.HospitalId;
            this.Name = entity.Name;
            this.Description = entity.Description;
            this.IsActive = entity.IsActive;
            this.HostpitalSection = entity.HostpitalSection;
        }

        public override void Delete()
        {
            this.Deleted = true;
        }
    }
}