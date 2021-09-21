using Microsoft.Extensions.DependencyInjection;
using MVC_PersonManagment.Data.EF.Extensions;
using MVC_PersonManagment.Service.Abstractions;
using MVC_PersonManagment.Service.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_PersonManagment.Service.ServiceExtensions
{
    public static class ServiceExtension
    {
        public static void AddServiceRepos(this IServiceCollection services)
        {
            services.AddTransient<IPersonService, PersonService>();

            services.AddRepositories();

           
        }
    }
}
