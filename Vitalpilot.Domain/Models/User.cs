namespace Vitalpilot.Domain.Models
{
    public partial class User : Base<User>, IBase
    {
        public User(string userName,
            string emailAddress,
            string password,
            string? address,
            string? phoneNumber,
            Guid hospitalId)
        {
            this.UserName = userName;
            this.EmailAddress = emailAddress;
            this.Password = password;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.HospitalId = hospitalId;

            UserRoles = new HashSet<UserRole>();
        }

        public override User CreateNew()
        {
            return new User(this.UserName,
                this.EmailAddress,
                this.Password,
                this.Address,
                this.PhoneNumber,
                this.HospitalId);
        }

        public override void Update(User entity)
        {
            this.UserName = entity.UserName;
            this.Address = entity.Address;
            this.PhoneNumber = entity.PhoneNumber;
        }

        public override void Delete()
        {
            this.Deleted = true;
        }
    }
}