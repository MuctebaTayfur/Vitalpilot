namespace Vitalpilot.Domain.Models
{
    public partial class PatienceDisease : Base<PatienceDisease>, IBase
    {
        public PatienceDisease(Guid diseaseId,
             Guid patienceId)
        {
            this.PatienceId = patienceId;
            this.DiseaseId = diseaseId;
        }

        public override PatienceDisease CreateNew()
        {
            return new PatienceDisease(this.DiseaseId,
                this.PatienceId);
        }

        public override void Update(PatienceDisease entity)
        {
            this.PatienceId = entity.PatienceId;
            this.DiseaseId = entity.DiseaseId;
        }

        public override void Delete()
        {
            this.Deleted = true;
        }
    }
}