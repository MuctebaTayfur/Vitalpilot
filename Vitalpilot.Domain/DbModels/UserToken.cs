using System.ComponentModel.DataAnnotations;

namespace Vitalpilot.Domain.Models
{
    public partial class UserToken
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
        public string AccessTokenHash { get; private set; } = null!;
        public DateTimeOffset AccessTokenExpiresDateTime { get; private set; }
        public string RefreshTokenIdHash { get; private set; } = null!;
        public string RefreshTokenIdHashSource { get; private set; } = null!;
        public DateTimeOffset RefreshTokenExpiresDateTime { get; private set; }
        public Guid UserId { get; private set; }

        public User User { get; private set; } = null!;
    }
}