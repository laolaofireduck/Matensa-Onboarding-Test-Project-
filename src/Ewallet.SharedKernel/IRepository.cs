﻿using System.Security.Principal;
namespace Ewallet.SharedKernel;

public interface IRepository<T, TId, TIdType> where T : AggregateRoot<TId, TIdType>
    where TId : AggregateRootId<TIdType>
{
    Task<IEnumerable<T>> GetAll(int? skip, int?Take);
    Task<T> Get(TId id);
    Task<T> Add(T entity);
    Task<T> Update(T entity);
    Task<T> Delete(TId id);
}
