using Microsoft.Extensions.DependencyInjection;
using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Data.Concrete;
using ProgrammersBlog.Data.Concrete.EntityFramework.Contexts;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollecion)
        {
            serviceCollecion.AddDbContext<ProgrammersBlogContext>();
            serviceCollecion.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollecion.AddScoped<ICategoryService, CategoryManager>();
            serviceCollecion.AddScoped<IArticleService, ArticleManager>();
            return serviceCollecion;

        }
    }
}
