using BooksManagement.Domain.Interfaces.IReposiories;
using BooksManagement.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksManagement.Infra.Data.Repositorys
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //private readonly ApplicationDbContext _context;
        private DbSet<TEntity> _dbSet => _context.Set<TEntity>();

        protected DbContext _context { get; }

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _context.ChangeTracker.LazyLoadingEnabled = false;
        }

        public virtual void Add(TEntity obj)
        {
            _dbSet.Add(obj);
        }

        public virtual async Task AddAsync(TEntity obj)
        {
            await _dbSet.AddAsync(obj);
        }

        public virtual async Task UpdateAsync(TEntity obj)
        {
            await Task.Run(() => _dbSet.Update(obj));
        }

        public virtual async Task<TEntity> GetByIdAsync(long id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public void Remove(long id)
        {
            _dbSet.Remove(_dbSet.Find(id));
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
