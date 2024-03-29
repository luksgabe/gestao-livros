﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksManagement.Domain.Interfaces.IReposiories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        Task AddAsync(TEntity obj);
        Task<TEntity> GetByIdAsync(long id);
        IQueryable<TEntity> GetAll();
        Task UpdateAsync(TEntity obj);
        void Remove(long id);
        int SaveChanges();
    }
}
