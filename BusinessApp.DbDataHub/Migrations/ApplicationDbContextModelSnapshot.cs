﻿// <auto-generated />
using System;
using BusinessApp.DbDataHub.ApplicationDBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessApp.DbDataHub.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Business.Models.Models.BusinessUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("AddressProof")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("BusinessCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("BusinessRegistrationDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Contact")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PinCode")
                        .HasColumnType("bigint");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BusinessCategoryId");

                    b.ToTable("BusinessUser");
                });

            modelBuilder.Entity("Business.Models.Models.ImageHub", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BusinessdetailId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("BusinessdetailId");

                    b.ToTable("ImageHub");
                });

            modelBuilder.Entity("BusinessApp.DbDataHub.Models.BusinessCategory", b =>
                {
                    b.Property<int>("BusinessCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BusinessCategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BusinessCategoryId");

                    b.ToTable("BusinessCategory");
                });

            modelBuilder.Entity("BusinessApp.DbDataHub.Models.BusinessDetails", b =>
                {
                    b.Property<int>("BusinessDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BusinessDetailId"));

                    b.Property<int>("BusinessCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("BusinessId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<long>("ContactNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("BusinessDetailId");

                    b.HasIndex("BusinessCategoryId");

                    b.HasIndex("BusinessId");

                    b.ToTable("BusinessDetails");
                });

            modelBuilder.Entity("BusinessApp.DbDataHub.Models.Businesses", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BusinessId"));

                    b.Property<int>("BusinessCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("BusinessDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BusinessId");

                    b.HasIndex("BusinessCategoryId");

                    b.ToTable("Business");
                });

            modelBuilder.Entity("Business.Models.Models.BusinessUser", b =>
                {
                    b.HasOne("BusinessApp.DbDataHub.Models.BusinessCategory", "BusinessCategory")
                        .WithMany()
                        .HasForeignKey("BusinessCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusinessCategory");
                });

            modelBuilder.Entity("Business.Models.Models.ImageHub", b =>
                {
                    b.HasOne("BusinessApp.DbDataHub.Models.BusinessDetails", "BusinessDetails")
                        .WithMany()
                        .HasForeignKey("BusinessdetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusinessDetails");
                });

            modelBuilder.Entity("BusinessApp.DbDataHub.Models.BusinessDetails", b =>
                {
                    b.HasOne("BusinessApp.DbDataHub.Models.BusinessCategory", "BusinessCategory")
                        .WithMany()
                        .HasForeignKey("BusinessCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessApp.DbDataHub.Models.Businesses", "Business")
                        .WithMany()
                        .HasForeignKey("BusinessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Business");

                    b.Navigation("BusinessCategory");
                });

            modelBuilder.Entity("BusinessApp.DbDataHub.Models.Businesses", b =>
                {
                    b.HasOne("BusinessApp.DbDataHub.Models.BusinessCategory", "BusinessCategory")
                        .WithMany()
                        .HasForeignKey("BusinessCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusinessCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
