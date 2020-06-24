using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class SectionEnrollManageConfiguration : IEntityTypeConfiguration<SectionEnrollManage>
    {
        public void Configure(EntityTypeBuilder<SectionEnrollManage> builder)
        {
            builder.HasData
            (
                new SectionEnrollManage
                {
                    Id = new Guid("3F6E887A-40F1-4032-A347-5C526D7CA36D"),
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    //UserId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    //OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                },
                new SectionEnrollManage
                {
                    Id = new Guid("B880CF73-B029-4C6D-AE21-6EE0A7A8E243"),
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    //UserId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    //OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                },
                 new SectionEnrollManage
                 {
                     Id = new Guid("A6A002F5-7D7B-4A3C-977B-CD78F55252BF"),
                     StartDate= DateTime.Now,
                     EndDate = DateTime.Now,
                     CreatedDate = DateTime.Now,
                     UpdatedDate = DateTime.Now,
                     //UserId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                     //OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                 }
            );
        }
    }
}
