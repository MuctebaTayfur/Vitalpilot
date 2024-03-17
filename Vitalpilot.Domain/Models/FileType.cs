namespace Vitalpilot.Domain.Models
{
    public partial class FileType : Base<FileType>, IBase
    {
        public FileType(string name,
            string? description)
        {
            this.Name = name;
            this.Description = description;
        }

        public override FileType CreateNew()
        {
            return new FileType(this.Name,
                this.Description);
        }

        public override void Update(FileType entity)
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