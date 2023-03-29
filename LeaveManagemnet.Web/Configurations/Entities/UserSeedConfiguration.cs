using LeaveManagemnet.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagemnet.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
               new Employee
               {
                   Id = "1a0208cd-e6f9-4400-8606-c8d6771bcb63",
                   Email = "admin@localhost.com",
                   NormalizedEmail = "ADMIN@LOCALHOST.COM",
                   NormalizedUserName = "ADMIN@LOCALHOST.COM",
                   UserName = "admin@localhost.com",
                   FirstName = "Systen",
                   LastName = "Admin",
                   PasswordHash = hasher.HashPassword(null, "P@assword1"),
                   EmailConfirmed = true
               },

               new Employee
               {
                   Id = "5dbb1d2e-acbd-4c9c-8d93-d020c48a8431",
                   Email = "user@localhost.com",
                   NormalizedEmail = "USER@LOCALHOST.COM",
                   NormalizedUserName = "USER@LOCALHOST.COM",
                   UserName = "user@localhost.com",
                   FirstName = "Systen",
                   LastName = "User",
                   PasswordHash = hasher.HashPassword(null, "P@assword1"),
                   EmailConfirmed = true
               },
               new Employee
               {
                   Id = "6cdbb1d2e-acbd-4c9c-8d93-d020c48a8431",
                   Email = "administractor@localhost.com",
                   NormalizedEmail = "ADMINISTRACTOR@LOCALHOST.COM",
                   NormalizedUserName = "ADMINISTRACTOR@LOCALHOST.COM",
                   UserName = "administractor@localhost.com",
                   FirstName = "Wang",
                   LastName = "Ming",
                   PasswordHash = hasher.HashPassword(null, "P@assword1"),
                   EmailConfirmed = true
               }
           ) ;
        }
    }
}