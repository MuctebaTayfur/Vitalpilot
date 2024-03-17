namespace Vitalpilot.Domain.Models
{
    public partial class UserRole : Base<UserRole>, IBase
    {
        public UserRole(Guid userId,
            Guid RoleId)
        {
            this.UserId = userId;
            this.RoleId = RoleId;
        }

        public override UserRole CreateNew()
        {
            return new UserRole(this.UserId,
                this.RoleId);
        }

        public override void Update(UserRole entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            this.Deleted = true;
        }
    }
}