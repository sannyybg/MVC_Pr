using MVC_PersonManagment.Data.Abstractions;
using MVC_PersonManagment.Data.EF.BaseRepository;
using MVC_PersonManagment.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVC_PersonManagment.Data.EF.Repositories
{
    class PersonRepository : IPersonRepository
    {

        readonly IBaseRepository<Person> _baseRepo;

        public PersonRepository(IBaseRepository<Person> repository)
        {
            _baseRepo = repository;
        }

        public async Task AddAsync(Person person)
        {
            await _baseRepo.AddAsync(person);
        }

        public async Task<List<Person>> GetAllAsync()
        {
            var xx = await _baseRepo.GetAllAsync();
            return xx;
        }

        public async Task<Person> GetAsync(int id)
        {
            var xx = await _baseRepo.GetAsync(id);
            return xx;
        }

        public async Task Delete(int id)
        {
            await _baseRepo.DeleteAsync(id);
        }

        public async Task UpdateAsync(Person person)
        {
            await _baseRepo.UpdateAsync(person);
        }
    }
}
