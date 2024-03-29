﻿using BooksManagement.Infra.CrossCutting.IoT;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BooksManagement.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
