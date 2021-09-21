using Mapster;
using MVC_PersonManagment.Data.Abstractions;
using MVC_PersonManagment.Domain.POCO;
using MVC_PersonManagment.Service.Abstractions;
using MVC_PersonManagment.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVC_PersonManagment.Service.Implementations
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _repo;
        public PersonService(IPersonRepository repo)
        {
            _repo = repo;
        }
        public async Task<List<PersonServiceModel>> GetAllAsync()
        {

            var result = await _repo.GetAllAsync();
            var personservicemodels = result.Adapt<List<PersonServiceModel>>();
            return personservicemodels;
        }

        public async Task AddAsync(PersonServiceModel prs)
        {
            var person = prs.Adapt<Person>();
            await _repo.AddAsync(person);
        }

        public async Task<PersonServiceModel> GetAsync(int id)
        {
            var result = await _repo.GetAsync(id);
            return result.Adapt<PersonServiceModel>();
            
        }

        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }

        public async Task UpdateAsync(PersonServiceModel prs)
        {
            var person = prs.Adapt<Person>();
            await _repo.UpdateAsync(person);
        }
    }
}
