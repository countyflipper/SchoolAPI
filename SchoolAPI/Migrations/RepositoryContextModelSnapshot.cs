﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SchoolAPI.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.CourseManagement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CourseManagementID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AssignmentTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CourseManagements");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c769e19d-c895-4ad0-97dc-9b497bff0d3e"),
                            AssignmentTitle = "GitHub Tutorial.",
                            Description = "Learn the basic of GitHub."
                        },
                        new
                        {
                            Id = new Guid("c47748fb-1fa7-4745-a863-78fa91633c93"),
                            AssignmentTitle = "Calculator",
                            Description = "Build a calculator using the basic math."
                        },
                        new
                        {
                            Id = new Guid("a12001ac-75cd-43ad-916f-79e1a8cd40f1"),
                            AssignmentTitle = "Statistic Application",
                            Description = "Build an app that includes basic math and statistics."
                        });
                });

            modelBuilder.Entity("Entities.Models.CourseSection", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CourseSectionID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("SectionAssignId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasMaxLength(60);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SectionAssignId");

                    b.ToTable("CourseSection");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 633, DateTimeKind.Local).AddTicks(9875),
                            EndDate = new DateTime(2020, 6, 23, 22, 56, 44, 633, DateTimeKind.Local).AddTicks(9478),
                            StartDate = new DateTime(2020, 6, 23, 22, 56, 44, 633, DateTimeKind.Local).AddTicks(9045),
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(308)
                        },
                        new
                        {
                            Id = new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(752),
                            EndDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(745),
                            StartDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(730),
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(759)
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(773),
                            EndDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(771),
                            StartDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(769),
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(775)
                        });
                });

            modelBuilder.Entity("Entities.Models.Courses", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CourseID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CourseManagementId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CourseManagementId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                            CourseName = "Web Systems Development",
                            CreatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 633, DateTimeKind.Local).AddTicks(4378),
                            Description = "Learn version control and apply the concepts to building an API using Python, Docker, and Pycharm. ",
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 633, DateTimeKind.Local).AddTicks(4794)
                        },
                        new
                        {
                            Id = new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                            CourseName = "	Web Services and Middleware",
                            CreatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 633, DateTimeKind.Local).AddTicks(5220),
                            Description = "Learn how to build an ASP .NET Web using C# and github.",
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 633, DateTimeKind.Local).AddTicks(5243)
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            CourseName = "	Enterprise Database Management",
                            CreatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 633, DateTimeKind.Local).AddTicks(5253),
                            Description = "Students will obtain a conceptual foundation of database design and explore the implications for organizational database usage.",
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 633, DateTimeKind.Local).AddTicks(5255)
                        });
                });

            modelBuilder.Entity("Entities.Models.Organization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OrgName")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            OrgName = "xyz org"
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            OrgName = "lmnop org"
                        });
                });

            modelBuilder.Entity("Entities.Models.SectionAssign", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SectionAssignID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CourseManagementId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("SubmissionText")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CourseManagementId");

                    b.ToTable("SectionAssigns");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 635, DateTimeKind.Local).AddTicks(1119),
                            Score = 91,
                            SubmissionText = "Please see link to assignment.",
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 635, DateTimeKind.Local).AddTicks(1532)
                        },
                        new
                        {
                            Id = new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 635, DateTimeKind.Local).AddTicks(1964),
                            Score = 84,
                            SubmissionText = "Please see link to assignment.",
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 635, DateTimeKind.Local).AddTicks(1981)
                        },
                        new
                        {
                            Id = new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 635, DateTimeKind.Local).AddTicks(1990),
                            Score = 99,
                            SubmissionText = "Please see link to assignment.",
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 635, DateTimeKind.Local).AddTicks(1991)
                        });
                });

            modelBuilder.Entity("Entities.Models.SectionEnrollManage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SectionEnrollID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasMaxLength(60);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SectionEnrollManages");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(5669),
                            EndDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(5269),
                            StartDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(4833),
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(6052)
                        },
                        new
                        {
                            Id = new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(6481),
                            EndDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(6474),
                            StartDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(6459),
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(6488)
                        },
                        new
                        {
                            Id = new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(6500),
                            EndDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(6498),
                            StartDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(6496),
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(6502)
                        });
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CourseSectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SectionAssignId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SectionEnrollManageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SystemRoleID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("CourseID");

                    b.HasIndex("CourseSectionId");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("SectionAssignId");

                    b.HasIndex("SectionEnrollManageId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                            CourseID = new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 632, DateTimeKind.Local).AddTicks(8034),
                            Email = "sderosa@njit.edu",
                            OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Password = "pass123",
                            Status = "Active",
                            SystemRoleID = 2000001,
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 632, DateTimeKind.Local).AddTicks(8487),
                            UserName = "sderosa"
                        },
                        new
                        {
                            Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                            CourseID = new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 632, DateTimeKind.Local).AddTicks(9741),
                            Email = "zwaltz@njit.edu",
                            OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Password = "hippo87",
                            Status = "Active",
                            SystemRoleID = 3000008,
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 632, DateTimeKind.Local).AddTicks(9759),
                            UserName = "zwaltz"
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            CourseID = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 632, DateTimeKind.Local).AddTicks(9786),
                            Email = "stussel@njit.edu",
                            OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Password = "newyork1",
                            Status = "Active",
                            SystemRoleID = 8000007,
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 56, 44, 632, DateTimeKind.Local).AddTicks(9789),
                            UserName = "stussel"
                        });
                });

            modelBuilder.Entity("Entities.Models.CourseSection", b =>
                {
                    b.HasOne("Entities.Models.SectionAssign", null)
                        .WithMany("CourseSections")
                        .HasForeignKey("SectionAssignId");
                });

            modelBuilder.Entity("Entities.Models.Courses", b =>
                {
                    b.HasOne("Entities.Models.CourseManagement", null)
                        .WithMany("Courses")
                        .HasForeignKey("CourseManagementId");
                });

            modelBuilder.Entity("Entities.Models.SectionAssign", b =>
                {
                    b.HasOne("Entities.Models.CourseManagement", null)
                        .WithMany("sectionAssigns")
                        .HasForeignKey("CourseManagementId");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.HasOne("Entities.Models.Courses", "Courses")
                        .WithMany("Users")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.CourseSection", null)
                        .WithMany("Users")
                        .HasForeignKey("CourseSectionId");

                    b.HasOne("Entities.Models.Organization", "Organization")
                        .WithMany("Users")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.SectionAssign", null)
                        .WithMany("Users")
                        .HasForeignKey("SectionAssignId");

                    b.HasOne("Entities.Models.SectionEnrollManage", null)
                        .WithMany("Users")
                        .HasForeignKey("SectionEnrollManageId");
                });
#pragma warning restore 612, 618
        }
    }
}
