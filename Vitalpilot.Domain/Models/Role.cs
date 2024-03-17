namespace Vitalpilot.Domain.Models
{
    public partial class Role : Base<Role>, IBase
    {
        public Role(string name,
            string? description)
        {
            this.Name = name;
            this.Description = description;
        }

        public override Role CreateNew()
        {
            return new Role(this.Name,
                this.Description);
        }

        public override void Update(Role entity)
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