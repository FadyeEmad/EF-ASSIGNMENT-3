﻿// <auto-generated />
using EF_SESSION_1_ASSIGNMENT.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_SESSION_1_ASSIGNMENT.Migrations
{
    [DbContext(typeof(ITI2Dbcontext))]
    [Migration("20240910160743_create 2")]
    partial class create2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EF_SESSION_1_ASSIGNMENT.entites.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("string");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("string");

                    b.Property<int>("Top_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("EF_SESSION_1_ASSIGNMENT.entites.Course_inst", b =>
                {
                    b.Property<int>("inst_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("inst_id"), 1L, 1);

                    b.Property<int>("Coure_id")
                        .HasColumnType("integer");

                    b.Property<string>("evaluate")
                        .IsRequired()
                        .HasColumnType("string");

                    b.HasKey("inst_id");

                    b.ToTable("Course_inst");
                });

            modelBuilder.Entity("EF_SESSION_1_ASSIGNMENT.entites.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<int>("hiringdate")
                        .HasColumnType("integer");

                    b.Property<int>("ins_id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EF_SESSION_1_ASSIGNMENT.entites.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Dept_id")
                        .HasColumnType("int");

                    b.Property<int>("HourRate")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("string");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("string");

                    b.Property<int>("bouns")
                        .HasColumnType("int");

                    b.Property<double>("salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("EF_SESSION_1_ASSIGNMENT.entites.Stud_course", b =>
                {
                    b.Property<int>("Course_id")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("stud_id")
                        .HasColumnType("int");

                    b.ToTable("stud_Courses");
                });

            modelBuilder.Entity("EF_SESSION_1_ASSIGNMENT.entites.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<int>("Dep_id")
                        .HasColumnType("integer");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EF_SESSION_1_ASSIGNMENT.entites.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("string");

                    b.HasKey("Id");

                    b.ToTable("topic");
                });
#pragma warning restore 612, 618
        }
    }
}
