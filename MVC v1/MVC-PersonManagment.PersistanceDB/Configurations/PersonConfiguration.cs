using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_PersonManagment.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_PersonManagment.PersistanceDB.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            
            builder.ToTable(nameof(Person));


            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).IsUnicode(false).IsRequired().HasMaxLength(50).IsFixedLength();
            builder.Property(x => x.LastName).IsUnicode(false).IsRequired().HasMaxLength(50).IsFixedLength();
            builder.Property(x => x.Age).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(50);
        }

        
    }
}
