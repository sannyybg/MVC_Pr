using MVC_PersonManagment.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVC_PersonManagment.Data.Abstractions
{
    public interface IPersonRepository
    {
        Task<List<Person>> GetAllAsync();
        Task<Person> GetAsync(int id);

        Task Delete(int id);

        Task AddAsync(Person person);

        Task UpdateAsync(Person person);
    }
}
