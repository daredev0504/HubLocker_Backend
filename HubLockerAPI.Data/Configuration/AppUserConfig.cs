using HubLockerAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HubLockerAPI.Data.Configuration
{
    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData(

                new AppUser
                {
                   FirstName = "Peter",
                   LastName = "Tosingh",
                   Country = "liberia"
                },
                new AppUser
                {
                    FirstName = "Beams",
                    LastName = "Bimbo",
                    Country = "spain"
                });
        }

        
    }
}
