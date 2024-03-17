namespace Vitalpilot.Domain.Models
{
    public partial class NoteType : Base<NoteType>, IBase
    {
        public NoteType(string name,
            string? description)
        {
            this.Name = name;
            this.Description = description;
        }

        public override NoteType CreateNew()
        {
            return new NoteType(this.Name,
                 this.Description);
        }

        public override void Update(NoteType entity)
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