using Mapster;
using Microsoft.Extensions.DependencyInjection;
using MVC_PersonManagmeng.ViewModels;
using MVC_PersonManagment.Domain.POCO;
using MVC_PersonManagment.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_PersonManagmeng.Mappings
{
    public static class MapsterConfiguration
    {
        public static void AddMappings(this IServiceCollection services)
        {
            TypeAdapterConfig<PersonServiceModel, Person>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<PersonServiceModel, PersonViewModel>
            .NewConfig()
            .TwoWays();
        }
    }
}
