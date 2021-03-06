﻿// <auto-generated />
using System;
using EmployeeLog.Data.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeLog.Data.Migrations
{
    [DbContext(typeof(EmployeeLogDataContext))]
    [Migration("20180922121159_EmployeeLog_0922")]
    partial class EmployeeLog_0922
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeLog.Data.Entities.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.HasKey("ClientID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("EmployeeLog.Data.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailID");

                    b.Property<string>("FirstName");

                    b.Property<string>("Image");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeLog.Data.Entities.EmployeeRole", b =>
                {
                    b.Property<int>("EmployeeID");

                    b.Property<int>("RoleID");

                    b.HasKey("EmployeeID", "RoleID");

                    b.HasIndex("EmployeeID")
                        .IsUnique();

                    b.HasIndex("RoleID");

                    b.ToTable("EmployeeRole");
                });

            modelBuilder.Entity("EmployeeLog.Data.Entities.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientID");

                    b.Property<DateTime>("ExpectedEndDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("TeamSize");

                    b.HasKey("ProjectID");

                    b.HasIndex("ClientID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("EmployeeLog.Data.Entities.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("RoleID");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("EmployeeLog.Data.Entities.WorkItem", b =>
                {
                    b.Property<int>("WorkItemID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<DateTime>("ExpectedEndDate");

                    b.Property<int>("ProjectID");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("TotalWorkHours");

                    b.Property<int>("WorkItemStatusID");

                    b.HasKey("WorkItemID");

                    b.HasIndex("ProjectID");

                    b.HasIndex("WorkItemStatusID");

                    b.ToTable("WorkItem");
                });

            modelBuilder.Entity("EmployeeLog.Data.Entities.WorkItemDetail", b =>
                {
                    b.Property<int>("WorkItemID");

                    b.Property<DateTime>("WorkDate");

                    b.Property<int>("WorkHours");

                    b.Property<string>("WorkLog");

                    b.HasKey("WorkItemID", "WorkDate");

                    b.ToTable("WorkItemDetails");
                });

            modelBuilder.Entity("EmployeeLog.Data.Entities.WorkItemStatus", b =>
                {
                    b.Property<int>("WorkItemStatusID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DisplayName");

                    b.Property<string>("Name");

                    b.HasKey("WorkItemStatusID");

                    b.ToTable("WorkItemStatus");
                });

            modelBuilder.Entity("EmployeeLog.Data.Entities.EmployeeRole", b =>
                {
                    b.HasOne("EmployeeLog.Data.Entities.Employee", "Employee")
                        .WithOne("EmployeeRole")
                        .HasForeignKey("EmployeeLog.Data.Entities.EmployeeRole", "EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EmployeeLog.Data.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EmployeeLog.Data.Entities.Project", b =>
                {
                    b.HasOne("EmployeeLog.Data.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EmployeeLog.Data.Entities.WorkItem", b =>
                {
                    b.HasOne("EmployeeLog.Data.Entities.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EmployeeLog.Data.Entities.WorkItemStatus", "WorkItemStatus")
                        .WithMany()
                        .HasForeignKey("WorkItemStatusID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EmployeeLog.Data.Entities.WorkItemDetail", b =>
                {
                    b.HasOne("EmployeeLog.Data.Entities.WorkItem", "WorkItem")
                        .WithMany()
                        .HasForeignKey("WorkItemID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
