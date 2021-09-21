using Microsoft.Extensions.DependencyInjection;
using MVC_PersonManagment.Data.Abstractions;
using MVC_PersonManagment.Data.EF.BaseRepository;
using MVC_PersonManagment.Data.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_PersonManagment.Data.EF.Extensions
{
    public static class RepositoryExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IPersonRepository, PersonRepository>();
            
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        }
    }
}
