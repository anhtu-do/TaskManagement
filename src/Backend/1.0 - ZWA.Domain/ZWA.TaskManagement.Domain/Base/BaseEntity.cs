using System;
using ZWA.Domain.Core;

namespace ZWA.TaskManagement.Domain.Base
{
    public class BaseEntity : IBaseEntity<Guid>
    {
        public Guid Id { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTimeOffset ModifiedAt { get; set; }

        public Guid ModifiedBy { get; set; }
    }
}
