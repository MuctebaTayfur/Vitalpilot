using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vitalpilot.Domain.Models;

using System.ComponentModel.DataAnnotations;

namespace Vitalpilot.Domain.Models
{
    public partial class User
    {
        public Guid UniqueId { get; private set; }
        public long FriendlyId { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public Guid CreatedById { get; private set; }
        public string CreatedBy { get; private set; } = null!;
        public DateTime LastModifiedDate { get; private set; }
        public Guid LastModifiedById { get; private set; }
        public string LastModifiedBy { get; private set; } = null!;
        public bool Deleted { get; private set; }
        public byte[] RowVersion { get; private set; } = null!;
        public string UserName { get; private set; }
        public string EmailAddress { get; private set; }
        public string Password { get; private set; }
        public string? Address { get; private set; }
        public string? PhoneNumber { get; private set; }
        public Guid HospitalId { get; private set; }

        public virtual ICollection<UserRole> UserRoles { get; }
        public virtual ICollection<UserToken> UserTokens { get; }

        public Hospital Hospital { get; set; }
    }
}