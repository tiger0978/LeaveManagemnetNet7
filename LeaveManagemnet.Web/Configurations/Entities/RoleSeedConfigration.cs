using LeaveManagemnet.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagemnet.Web.Configurations.Entities
{
    internal class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "aa0208cd-e6f9-4400-8606-c8d6771bcb63",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "bb0208cd-e6f9-4400-8606-c8d6771bcb63",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
            ) ; ;
        }
    }
}