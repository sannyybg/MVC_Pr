using MVC_PersonManagment.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVC_PersonManagment.Service.Abstractions
{
    public interface IPersonService
    {

        Task<List<PersonServiceModel>> GetAllAsync();

        Task AddAsync(PersonServiceModel pers);

        Task<PersonServiceModel> GetAsync(int id);

        Task Delete(int id);

        Task UpdateAsync(PersonServiceModel pers);

    }
}
