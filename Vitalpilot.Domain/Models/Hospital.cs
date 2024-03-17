namespace Vitalpilot.Domain.Models
{
    public partial class Hospital : Base<Hospital>, IBase
    {
        public Hospital(string name,
            string city,
            string address,
            string phoneNumber,
            string? website)
        {
            this.Name = name;
            this.City = city;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Website = website;
        }

        public override Hospital CreateNew()
        {
            return new Hospital(this.Name,
                this.City,
                this.Address,
                this.PhoneNumber,
                this.Website);
        }

        public override void Update(Hospital entity)
        {
            this.Name = entity.Name;
            this.City = entity.City;
            this.Address = entity.Address;
            this.PhoneNumber = entity.PhoneNumber;
            this.Website = entity.Website;
        }

        public override void Delete()
        {
            this.Deleted = true;
        }
    }
}