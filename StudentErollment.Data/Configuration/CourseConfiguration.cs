using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentErollment.Data.Configuration
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(
           
               new Course()
               {
                   Id=1,
                   Title="Minimum Api development",
                   Credits=3,
               },new Course()
               {
                   Id=2,
                   Title="advance Api development",
                   Credits=2,
               }
           );
        }
    }
}
