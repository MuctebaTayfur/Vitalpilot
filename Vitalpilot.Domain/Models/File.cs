namespace Vitalpilot.Domain.Models
{
    public partial class File : Base<File>, IBase
    {
        public File(Guid fileTypeId,
            string? fileUrl,
            string? fileExtension)
        {
            this.FileTypeId = fileTypeId;
            this.FileUrl = fileUrl;
            this.FileExtension = fileExtension;
        }

        public override File CreateNew()
        {
            return new File(this.FileTypeId,
                this.FileUrl,
                this.FileExtension);
        }

        public override void Update(File entity)
        {
            this.FileTypeId = entity.FileTypeId;
            this.FileUrl = entity.FileUrl;
            this.FileExtension = entity.FileExtension;
        }

        public override void Delete()
        {
            this.Deleted = true;
        }
    }
}