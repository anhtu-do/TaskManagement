using System;

namespace ZWA.TaskManagement.Domain.Base
{
    public class BaseEntity 
    {
        public Guid Id { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTimeOffset ModifiedAt { get; set; }

        public Guid ModifiedBy { get; set; }
    }
}
