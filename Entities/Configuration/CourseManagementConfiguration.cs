using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class CourseManagementConfiguration : IEntityTypeConfiguration<CourseManagement>
    {
        public void Configure(EntityTypeBuilder<CourseManagement> builder)
        {
            builder.HasData
            (
                new CourseManagement
                {
                    Id = new Guid("C769E19D-C895-4AD0-97DC-9B497BFF0D3E"),
                    Description = "Learn the basic of GitHub.",
                    AssignmentTitle = "GitHub Tutorial.",
                    //UserId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    //OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                },
                new CourseManagement
                {
                    Id = new Guid("C47748FB-1FA7-4745-A863-78FA91633C93"),
                    Description = "Build a calculator using the basic math.",
                    AssignmentTitle = "Calculator",
                    //UserId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    //OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                },
                 new CourseManagement
                 {
                     Id = new Guid("A12001AC-75CD-43AD-916F-79E1A8CD40F1"),
                     Description = "Build an app that includes basic math and statistics.",
                     AssignmentTitle = "Statistic Application",
                     //UserId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                     //OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                 }
            );
        }
    }
}
