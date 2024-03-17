namespace Vitalpilot.Domain.Models
{
    public partial class PatienceNote : Base<PatienceNote>, IBase
    {
        public PatienceNote(Guid patiencId,
            Guid noteTypeId,
            string noteText)
        {
            this.PatiencId = patiencId;
            this.NoteTypeId = noteTypeId;
            this.NoteText = noteText;
        }

        public override PatienceNote CreateNew()
        {
            return new PatienceNote(this.PatiencId,
                this.NoteTypeId,
                this.NoteText);
        }

        public override void Update(PatienceNote entity)
        {
            this.PatiencId = entity.PatiencId;
            this.NoteTypeId = entity.NoteTypeId;
            this.NoteText = entity.NoteText;
        }

        public override void Delete()
        {
            this.Deleted = true;
        }
    }
}