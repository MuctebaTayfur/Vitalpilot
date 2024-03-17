namespace Vitalpilot.Domain.Models
{
    public partial class LabResult : Base<LabResult>, IBase
    {
        public LabResult(Guid patienceId,
            DateTime startDate,
            Guid? fileId,
            DateTime? endDate)
        {
            this.PatienceId = patienceId;
            this.FileId = fileId;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public override LabResult CreateNew()
        {
            return new LabResult(this.PatienceId,
                this.StartDate,
                this.FileId,
                this.EndDate);
        }

        public override void Update(LabResult entity)
        {
            this.PatienceId = entity.PatienceId;
            this.FileId = entity.FileId;
            this.StartDate = entity.StartDate;
            this.EndDate = entity.EndDate;
        }

        public override void Delete()
        {
            this.Deleted = true;
        }
    }
}