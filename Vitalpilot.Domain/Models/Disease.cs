namespace Vitalpilot.Domain.Models
{
    public partial class Disease : Base<Disease>, IBase
    {
        public Disease(string name,
            string? description)
        {
            this.Name = name;
            this.Description = description;

            this.PatienceDiseases = new HashSet<PatienceDisease>();
        }

        public override Disease CreateNew()
        {
            return new Disease(this.Name,
                this.Description);
        }

        public override void Update(Disease entity)
        {
            this.Name = entity.Name;
            this.Description = entity.Description;
        }

        public override void Delete()
        {
            this.Deleted = true;
        }
    }
}