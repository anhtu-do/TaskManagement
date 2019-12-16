namespace ZWA.Domain.Core
{
    public interface IAggregateRoot<TKey> where TKey : struct
    {
        public TKey Id { get; set; }
    }
}
