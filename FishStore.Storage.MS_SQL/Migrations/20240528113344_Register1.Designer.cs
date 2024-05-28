﻿// <auto-generated />
using System;
using FishStore.Storage.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FishStore.Storage.MS_SQL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240528113344_Register1")]
    partial class Register1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FishStore.Storage.Models.Center", b =>
                {
                    b.Property<Guid>("IsnNode")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("IsnNode");

                    b.HasIndex("Name");

                    b.ToTable("Centers");
                });

            modelBuilder.Entity("FishStore.Storage.Models.User", b =>
                {
                    b.Property<Guid>("IsnNode")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("IsnNode");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}