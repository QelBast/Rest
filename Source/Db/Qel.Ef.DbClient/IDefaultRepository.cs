﻿namespace Qel.Ef.DbClient;

public interface IDefaultRepository<TEntity> 
    where TEntity : class
{
    Task<TEntity?> GetByIdAsync(long id);
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task AddAsync(TEntity entity);
    void Update(TEntity entity);
    void Remove(TEntity entity);
}
