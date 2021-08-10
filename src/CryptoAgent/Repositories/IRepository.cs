﻿using System.Threading.Tasks;

namespace Bit.CryptoAgent.Repositories
{
    public interface IRepository<TItem, TId>
    {
        Task CreateAsync(TItem item);
        Task<TItem> ReadAsync(TId id);
        Task UpdateAsync(TItem item);
        Task DeleteAsync(TId id);
    }
}
