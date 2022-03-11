﻿// <auto-generated />
using System;
using AspNetCoreWebApi.EmployeeData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspNetCoreWebApi.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20220310220302_InitalCriate")]
    partial class InitalCriate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AspNetCoreWebApi.Models.Employee", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("salary")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("MyEmployees");
                });
#pragma warning restore 612, 618
        }
    }
}
