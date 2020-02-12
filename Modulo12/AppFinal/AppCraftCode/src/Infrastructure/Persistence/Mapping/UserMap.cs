using AppCraftCode.src.Domain.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCraftCode.src.Infrastructure.Persistence.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .Property(c => c.Id)
                .HasColumnType("nvarchar(50)")
                .HasConversion(
                    v => v.GetValue(),
                    v => new UserId(v)
                )
                .IsRequired();

            builder
                .Property(c => c.Email)
                .HasColumnType("nvarchar(50)")
                .HasConversion(
                    v => v.GetValue(),
                    v => new UserEmail(v)
                )
                .IsRequired();

            builder
                .Property(c => c.Password)
                .HasColumnType("nvarchar(50)")
                .IsRequired();

            builder
                .Property(c => c.FirstName)
                .HasColumnType("nvarchar(20)")
                .IsRequired();

            builder
                .Property(c => c.LastName)
                .HasColumnType("nvarchar(20)")
                .IsRequired();

            builder
                .Property(c => c.Country)
                .HasColumnType("nvarchar(20)")
                .IsRequired();

            builder
                .Property(c => c.Country)
                .HasColumnType("nvarchar(20)")
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
