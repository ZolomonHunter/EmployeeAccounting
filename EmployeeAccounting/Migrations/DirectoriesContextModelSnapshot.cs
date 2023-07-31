﻿// <auto-generated />
using System;
using EmployeeAccounting.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EmployeeAccounting.Migrations
{
    [DbContext(typeof(DirectoriesContext))]
    partial class DirectoriesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EmployeeAccounting.Models.Division", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("HeadDivisionId")
                        .HasColumnType("integer");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("HeadDivisionId");

                    b.HasIndex("ManagerId");

                    b.ToTable("division");
                });

            modelBuilder.Entity("EmployeeAccounting.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DivisionId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("hire_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("PersonnelNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("personnel_number");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("position");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<DateTime?>("TerminationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("termination_date");

                    b.HasKey("Id");

                    b.HasIndex("DivisionId");

                    b.ToTable("employee");
                });

            modelBuilder.Entity("EmployeeAccounting.Models.Division", b =>
                {
                    b.HasOne("EmployeeAccounting.Models.Division", "HeadDivision")
                        .WithMany()
                        .HasForeignKey("HeadDivisionId");

                    b.HasOne("EmployeeAccounting.Models.Employee", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId");

                    b.Navigation("HeadDivision");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("EmployeeAccounting.Models.Employee", b =>
                {
                    b.HasOne("EmployeeAccounting.Models.Division", "Division")
                        .WithMany("Employees")
                        .HasForeignKey("DivisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Division");
                });

            modelBuilder.Entity("EmployeeAccounting.Models.Division", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
