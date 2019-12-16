using System;

namespace ZWA.Domain.Core
{
    public interface IBaseEntity<TKey> where TKey : struct 
    {
        public TKey Id { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public TKey CreatedBy { get; set; }

        public DateTimeOffset ModifiedAt { get; set; }

        public TKey ModifiedBy { get; set; }

    }
}
