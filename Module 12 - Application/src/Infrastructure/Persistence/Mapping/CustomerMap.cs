using App.Domain.CustomerAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Infrastructure.Persistence.Mapping
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                .Property(c => c.Id)
                .HasColumnType("nvarchar(50)")
                .HasConversion(
                    v => v.GetValue(),
                    v => new CustomerId(v)
                )
                .IsRequired();
            
            builder
                .Property(c => c.Email)
                .HasColumnType("nvarchar(50)")
                .HasConversion(
                    v => v.GetValue(),
                    v => new CustomerEmail(v)
                )
                .IsRequired();
            
            builder
                .Property(c => c.Password)
                .HasColumnType("nvarchar(50)")
                .HasConversion(
                    v => v.GetValue(),
                    v => new CustomerHashedPassword(v)
                )
                .IsRequired();

            builder
                .Property(c => c.FirstName)
                .HasColumnType("nvarchar(20)")
                .HasConversion(
                    v => v.GetValue(),
                    v => new CustomerFirstName(v)
                )
                .IsRequired();
                
            builder
                .Property(c => c.LastName)
                .HasColumnType("nvarchar(20)")
                .HasConversion(
                    v => v.GetValue(),
                    v => new CustomerLastName(v)
                )
                .IsRequired();

            builder
                .Property(c => c.Country)
                .HasColumnType("nvarchar(20)")
                .HasConversion(
                    v => v.GetValue(),
                    v => new CustomerCountry(v)
                )
                .IsRequired();

            builder
                .Property(c => c.Country)
                .HasColumnType("nvarchar(20)")
                .HasConversion(
                    v => v.GetValue(),
                    v => new CustomerCountry(v)
                )
                .IsRequired();

            builder.Property(c => c.CreatedAt)
                .HasColumnType("datetime2")
                .IsRequired();

            builder.Property(c => c.UpdatedAt)
                .HasColumnType("datetime2")
                .IsRequired();
        }
    }
}
