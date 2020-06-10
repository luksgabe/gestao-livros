using AutoMapper;
using BooksManagement.App.Application;
using BooksManagement.App.AutoMapper;
using BooksManagement.App.Interfaces;
using BooksManagement.Domain.Interfaces;
using BooksManagement.Domain.Interfaces.IServices;
using BooksManagement.Domain.Services;
using BooksManagement.Infra.Data.Context;
using BooksManagement.Infra.Data.UoW;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BooksManagement.Infra.CrossCutting.IoT
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            AddAutoMapperSetup(services);

            services.AddScoped<IAuthorApp, AuthorApp>();
            services.AddScoped<IGenreApp, GenreApp>();
            services.AddScoped<IBookApp, BookApp>();

            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IGenreService, GenreService>();
            services.AddScoped<IBookService, BookService>();

            services.AddScoped<IUnityOfWork, UnityOfWork>();
            services.AddScoped<ApplicationDbContext>();
        }


        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            var mappingConfig = AutoMapperConfig.RegisterMappings();
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
