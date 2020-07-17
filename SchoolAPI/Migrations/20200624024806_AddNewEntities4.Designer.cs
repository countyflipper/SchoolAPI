﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SchoolAPI.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20200624024806_AddNewEntities4")]
    partial class AddNewEntities4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                            CreatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(1826),
                            EndDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(1436),
                            StartDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(1013),
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(2246)
                        },
                        new
                        {
                            Id = new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(2700),
                            EndDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(2693),
                            StartDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(2677),
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(2707)
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(2720),
                            EndDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(2718),
                            StartDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(2716),
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(2721)
                        });
                });

            modelBuilder.Entity("Entities.Models.Courses", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CourseID")
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

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                            CourseName = "Web Systems Development",
                            CreatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 149, DateTimeKind.Local).AddTicks(6298),
                            Description = "Learn version control and apply the concepts to building an API using Python, Docker, and Pycharm. ",
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 149, DateTimeKind.Local).AddTicks(6745)
                        },
                        new
                        {
                            Id = new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                            CourseName = "	Web Services and Middleware",
                            CreatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 149, DateTimeKind.Local).AddTicks(7170),
                            Description = "Learn how to build an ASP .NET Web using C# and github.",
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 149, DateTimeKind.Local).AddTicks(7190)
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            CourseName = "	Enterprise Database Management",
                            CreatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 149, DateTimeKind.Local).AddTicks(7199),
                            Description = "Students will obtain a conceptual foundation of database design and explore the implications for organizational database usage.",
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 149, DateTimeKind.Local).AddTicks(7201)
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

                    b.ToTable("SectionAssigns");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 151, DateTimeKind.Local).AddTicks(2712),
                            Score = 91,
                            SubmissionText = "Please see link to assignment.",
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 151, DateTimeKind.Local).AddTicks(3180)
                        },
                        new
                        {
                            Id = new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 151, DateTimeKind.Local).AddTicks(3959),
                            Score = 84,
                            SubmissionText = "Please see link to assignment.",
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 151, DateTimeKind.Local).AddTicks(3977)
                        },
                        new
                        {
                            Id = new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 151, DateTimeKind.Local).AddTicks(3990),
                            Score = 99,
                            SubmissionText = "Please see link to assignment.",
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 151, DateTimeKind.Local).AddTicks(3992)
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
                            CreatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(7260),
                            EndDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(6870),
                            StartDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(6442),
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(7634)
                        },
                        new
                        {
                            Id = new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(8061),
                            EndDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(8054),
                            StartDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(8036),
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(8068)
                        },
                        new
                        {
                            Id = new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                            CreatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(8079),
                            EndDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(8078),
                            StartDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(8076),
                            UpdatedDate = new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(8081)
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

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SectionAssignId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SectionEnrollManageId")
                        .HasColumnType("uniqueidentifier");

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
                            OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            UserName = "sderosa"
                        },
                        new
                        {
                            Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                            CourseID = new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                            OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            UserName = "zwaltz"
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            CourseID = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            UserName = "stussel"
                        });
                });

            modelBuilder.Entity("Entities.Models.CourseSection", b =>
                {
                    b.HasOne("Entities.Models.SectionAssign", null)
                        .WithMany("CourseSections")
                        .HasForeignKey("SectionAssignId");
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
