﻿// <auto-generated />
using System;
using LandLord.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LandLord.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230330112358_AddedDatetimeInCommentEntity")]
    partial class AddedDatetimeInCommentEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LandLord.Models.Entities.ApartmentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<short>("ApartmentNumber")
                        .HasColumnType("smallint");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Entrance")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.Property<byte>("HouseNumber")
                        .HasColumnType("tinyint");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("char(6)");

                    b.HasKey("Id");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("LandLord.Models.Entities.CommentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderRowId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderRowId");

                    b.HasIndex("PersonId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("LandLord.Models.Entities.EmployeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("RoleId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("LandLord.Models.Entities.OrderEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeId")
                        .HasColumnType("int");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeId");

                    b.HasIndex("TenantId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("LandLord.Models.Entities.OrderRowEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("EmployeId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("OrdersIdId")
                        .HasColumnType("int");

                    b.Property<int>("StatusCodeId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeId");

                    b.HasIndex("OrdersIdId");

                    b.HasIndex("StatusCodeId");

                    b.ToTable("OrderRows");
                });

            modelBuilder.Entity("LandLord.Models.Entities.PersonEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(70)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("char(13)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("LandLord.Models.Entities.RoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("LandLord.Models.Entities.StatusCodeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("StatusCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("StatusCodes");
                });

            modelBuilder.Entity("LandLord.Models.Entities.TenantEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.HasIndex("PersonId");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("LandLord.Models.Entities.CommentEntity", b =>
                {
                    b.HasOne("LandLord.Models.Entities.OrderRowEntity", "OrderRow")
                        .WithMany()
                        .HasForeignKey("OrderRowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LandLord.Models.Entities.PersonEntity", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderRow");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("LandLord.Models.Entities.EmployeEntity", b =>
                {
                    b.HasOne("LandLord.Models.Entities.PersonEntity", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LandLord.Models.Entities.RoleEntity", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("LandLord.Models.Entities.OrderEntity", b =>
                {
                    b.HasOne("LandLord.Models.Entities.EmployeEntity", "Employe")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LandLord.Models.Entities.TenantEntity", "Tenant")
                        .WithMany("Order")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Employe");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("LandLord.Models.Entities.OrderRowEntity", b =>
                {
                    b.HasOne("LandLord.Models.Entities.EmployeEntity", "Employe")
                        .WithMany()
                        .HasForeignKey("EmployeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LandLord.Models.Entities.OrderEntity", "OrdersId")
                        .WithMany()
                        .HasForeignKey("OrdersIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LandLord.Models.Entities.StatusCodeEntity", "StatusCode")
                        .WithMany()
                        .HasForeignKey("StatusCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employe");

                    b.Navigation("OrdersId");

                    b.Navigation("StatusCode");
                });

            modelBuilder.Entity("LandLord.Models.Entities.TenantEntity", b =>
                {
                    b.HasOne("LandLord.Models.Entities.ApartmentEntity", "Apartment")
                        .WithMany()
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LandLord.Models.Entities.PersonEntity", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Apartment");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("LandLord.Models.Entities.EmployeEntity", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("LandLord.Models.Entities.TenantEntity", b =>
                {
                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
