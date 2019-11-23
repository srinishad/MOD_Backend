﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mod.TrainingService.Context;

namespace Mod.TrainingService.Migrations
{
    [DbContext(typeof(TrainingContext))]
    [Migration("20191114102826_TrainingMig1")]
    partial class TrainingMig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mod.TrainingService.Models.Training", b =>
                {
                    b.Property<int>("TrainingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MentorId")
                        .HasColumnType("int");

                    b.Property<string>("Progress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Timeslot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TrainingId");

                    b.ToTable("Training");
                });
#pragma warning restore 612, 618
        }
    }
}
