using System;
using System.Threading.Tasks;

namespace ZWA.Application.Core
{
    public interface IUnitOfWork : IDisposable
    {
        public int AffectedRecords { get; set; }

        public bool IsCommittedSuccessfully { get; }

        Task<int> CommitAsync();
    }
}
