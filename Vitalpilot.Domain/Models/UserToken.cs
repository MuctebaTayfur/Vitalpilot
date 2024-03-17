namespace Vitalpilot.Domain.Models
{
    public partial class UserToken : Base<UserToken>, IBase
    {
        public UserToken(string accessTokenHash,
            DateTimeOffset accessTokenExpiresDateTime,
            string refreshTokenIdHash,
            string refreshTokenIdHashSource,
            DateTimeOffset refreshTokenExpiresDateTime,
            Guid userId)
        {
            this.AccessTokenHash = accessTokenHash;
            this.AccessTokenExpiresDateTime = accessTokenExpiresDateTime;
            this.RefreshTokenIdHash = refreshTokenIdHash;
            this.RefreshTokenIdHashSource = refreshTokenIdHashSource;
            this.RefreshTokenExpiresDateTime = refreshTokenExpiresDateTime;
            this.UserId = userId;
        }

        public override UserToken CreateNew()
        {
            return new UserToken(this.AccessTokenHash,
                this.AccessTokenExpiresDateTime,
                this.RefreshTokenIdHash,
                this.RefreshTokenIdHashSource,
                this.RefreshTokenExpiresDateTime,
                this.UserId);
        }

        public override void Update(UserToken entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            this.Deleted = true;
        }
    }
}