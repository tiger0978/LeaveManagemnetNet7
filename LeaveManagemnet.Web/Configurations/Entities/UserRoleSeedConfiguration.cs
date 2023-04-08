using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagemnet.Web.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId= "aa0208cd-e6f9-4400-8606-c8d6771bcb63",
                    UserId = "1a0208cd-e6f9-4400-8606-c8d6771bcb63"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "bb0208cd-e6f9-4400-8606-c8d6771bcb63",
                    UserId = "5dbb1d2e-acbd-4c9c-8d93-d020c48a8431"
                }
            );
        }
    }
}