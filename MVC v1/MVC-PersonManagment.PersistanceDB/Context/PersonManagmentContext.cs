using Microsoft.EntityFrameworkCore;
using MVC_PersonManagment.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_PersonManagment.PersistanceDB.Context
{
    public class PersonManagmentContext : DbContext
    {
        

        private readonly string _connectionString;
        public PersonManagmentContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public PersonManagmentContext(DbContextOptions<PersonManagmentContext> options) : base(options)
        {

        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PersonManagmentContext).Assembly);
        }

        

        

        public DbSet<Person> Person { get; set; }
       

        
    }
}
