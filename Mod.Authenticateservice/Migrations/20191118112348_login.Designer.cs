﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mod.Authenticateservice.Context;

namespace Mod.Authenticateservice.Migrations
{
    [DbContext(typeof(LoginContext))]
    [Migration("20191118112348_login")]
    partial class login
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mod.Authenticateservice.Models.Mentor", b =>
                {
                    b.Property<int>("MentorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("MentorActive")
                        .HasColumnType("bit");

                    b.Property<bool>("MentorAvailability")
                        .HasColumnType("bit");

                    b.Property<string>("MentorEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MentorExperience")
                        .HasColumnType("int");

                    b.Property<string>("MentorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("MentorNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("MentorPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MentorSkills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MentorTimeslot")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MentorId");

                    b.ToTable("Mentor");
                });

            modelBuilder.Entity("Mod.Authenticateservice.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("UserActive")
                        .HasColumnType("bit");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}