﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PschoolBackend_DAL;

#nullable disable

namespace PschoolBackend_DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PschoolBackend_DAL.Entities.Parent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("parents");
                });

            modelBuilder.Entity("PschoolBackend_DAL.Entities.ParentCouple", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Parent1Id")
                        .HasColumnType("int");

                    b.Property<int?>("Parent2Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Parent1Id")
                        .IsUnique()
                        .HasFilter("[Parent1Id] IS NOT NULL");

                    b.HasIndex("Parent2Id")
                        .IsUnique()
                        .HasFilter("[Parent2Id] IS NOT NULL");

                    b.ToTable("parentCouples", t =>
                        {
                            t.HasCheckConstraint("CK_NotEqual_ParentIds", "[Parent1Id] <> [Parent2Id]");
                        });
                });

            modelBuilder.Entity("PschoolBackend_DAL.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentCoupleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentCoupleId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("PschoolBackend_DAL.Entities.ParentCouple", b =>
                {
                    b.HasOne("PschoolBackend_DAL.Entities.Parent", "Parent1")
                        .WithOne("ParentCoupleFromParent1")
                        .HasForeignKey("PschoolBackend_DAL.Entities.ParentCouple", "Parent1Id");

                    b.HasOne("PschoolBackend_DAL.Entities.Parent", "Parent2")
                        .WithOne("ParentCoupleFromParent2")
                        .HasForeignKey("PschoolBackend_DAL.Entities.ParentCouple", "Parent2Id");

                    b.Navigation("Parent1");

                    b.Navigation("Parent2");
                });

            modelBuilder.Entity("PschoolBackend_DAL.Entities.Student", b =>
                {
                    b.HasOne("PschoolBackend_DAL.Entities.ParentCouple", "ParentCouple")
                        .WithMany("Children")
                        .HasForeignKey("ParentCoupleId");

                    b.Navigation("ParentCouple");
                });

            modelBuilder.Entity("PschoolBackend_DAL.Entities.Parent", b =>
                {
                    b.Navigation("ParentCoupleFromParent1")
                        .IsRequired();

                    b.Navigation("ParentCoupleFromParent2")
                        .IsRequired();
                });

            modelBuilder.Entity("PschoolBackend_DAL.Entities.ParentCouple", b =>
                {
                    b.Navigation("Children");
                });
#pragma warning restore 612, 618
        }
    }
}
