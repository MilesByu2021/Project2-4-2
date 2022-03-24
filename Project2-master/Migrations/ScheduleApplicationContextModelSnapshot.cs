﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project2.Models;

namespace Project2.Migrations
{
    [DbContext(typeof(ScheduleApplicationContext))]
    partial class ScheduleApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Project2.Models.Schedules", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("GroupEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupPhone")
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("StartTime")
                        .HasColumnType("TEXT");

                    b.HasKey("ScheduleId");

                    b.ToTable("Schedule");
                });
#pragma warning restore 612, 618
        }
    }
}
