﻿using BooksManagement.Domain.Entities;
using BooksManagement.Domain.Interfaces.IReposiories;
using BooksManagement.Infra.Data.Context;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BooksManagement.Infra.Data.Repositorys
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(ApplicationDbContext context) : base(context)
        {
            context.ChangeTracker.LazyLoadingEnabled = true;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            DbSet<Book> books = _context.Set<Book>();
            return await books.ToListAsync();
        }


        public Book LastBookCreatedAsync()
        {
            var idMax = GetAll().Max(p => p.Id);
            return GetAll().FirstOrDefault(p => p.Id == idMax);
        }
    }
}