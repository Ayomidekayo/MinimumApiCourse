﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StudentErollment.Data.Configuration
{
    internal class UserRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
          
               new IdentityRole()
               {
                  Name="Administrator",
                  NormalizedName="ADMINISTRATOR",
               },new IdentityRole()
               {
                   Name = "User",
                   NormalizedName = "USER",
               }
           );
        }
    }
}
