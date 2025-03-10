﻿// <auto-generated />
using System;
using ChamCong2.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChamCong2.API.Migrations
{
    [DbContext(typeof(ChamCongDbContext))]
    [Migration("20220426070405_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ChamCong2.Data.Entities.im_Plan", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("CompletionPercentage")
                        .HasMaxLength(50)
                        .HasColumnType("real");

                    b.Property<bool>("IsLate")
                        .HasMaxLength(50)
                        .HasColumnType("bit");

                    b.Property<DateTime>("TimeCheckIn")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeCheckOut")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalTaskComplete")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("TotalTaskOutStandingCount")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("TotalTaskPlannedCount")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("TotalTimeWorkCount")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("PlanId");

                    b.HasIndex("UserId");

                    b.ToTable("im_Plan");
                });

            modelBuilder.Entity("ChamCong2.Data.Entities.im_Task", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsComplete")
                        .HasMaxLength(50)
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PlanId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TypeTask")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("TaskId");

                    b.HasIndex("PlanId");

                    b.ToTable("im_Task");
                });

            modelBuilder.Entity("ChamCong2.Data.Entities.im_User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("EmployId")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<DateTime>("LastLoginDate")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<string>("Passwword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Phonenumber")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserID");

                    b.ToTable("im_User");
                });

            modelBuilder.Entity("ChamCong2.Data.Entities.im_Plan", b =>
                {
                    b.HasOne("ChamCong2.Data.Entities.im_User", "user")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("ChamCong2.Data.Entities.im_Task", b =>
                {
                    b.HasOne("ChamCong2.Data.Entities.im_Plan", "Plan")
                        .WithMany("TaskListCode")
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plan");
                });

            modelBuilder.Entity("ChamCong2.Data.Entities.im_Plan", b =>
                {
                    b.Navigation("TaskListCode");
                });
#pragma warning restore 612, 618
        }
    }
}
