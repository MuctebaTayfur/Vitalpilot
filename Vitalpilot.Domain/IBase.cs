using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitalpilot.Domain
{
    public interface IBase
    {
        public Guid UniqueId { get; }
        public long FriendlyId { get; }
        public DateTime CreatedDate { get; }
        public Guid CreatedById { get; }
        public string CreatedBy { get; }
        public DateTime LastModifiedDate { get; }
        public Guid LastModifiedById { get; }
        public string LastModifiedBy { get; }
        public bool Deleted { get; }
        public byte[] RowVersion { get; }
    }
}