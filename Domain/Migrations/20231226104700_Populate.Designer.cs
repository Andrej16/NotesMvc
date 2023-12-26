﻿// <auto-generated />
using System;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Domain.Migrations
{
    [DbContext(typeof(NotesContext))]
    [Migration("20231226104700_Populate")]
    partial class Populate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsImportant")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Notes", (string)null);

                    b.UseTptMappingStrategy();

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Content of the first note",
                            Created = new DateTime(2023, 12, 26, 12, 46, 59, 585, DateTimeKind.Local).AddTicks(10),
                            IsImportant = true,
                            Title = "First Note",
                            Updated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Content = "Content of the second note",
                            Created = new DateTime(2023, 12, 26, 12, 46, 59, 585, DateTimeKind.Local).AddTicks(56),
                            IsImportant = false,
                            Title = "Second Note",
                            Updated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Content = "Content of the third note",
                            Created = new DateTime(2023, 12, 26, 12, 46, 59, 585, DateTimeKind.Local).AddTicks(58),
                            IsImportant = true,
                            Title = "Third Note",
                            Updated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Content = "Content of the fourth note",
                            Created = new DateTime(2023, 12, 26, 12, 46, 59, 585, DateTimeKind.Local).AddTicks(61),
                            IsImportant = false,
                            Title = "Fourth Note",
                            Updated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Content = "Content of the fifth note",
                            Created = new DateTime(2023, 12, 26, 12, 46, 59, 585, DateTimeKind.Local).AddTicks(63),
                            IsImportant = true,
                            Title = "Fifth Note",
                            Updated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Content = "Content of the sixth note",
                            Created = new DateTime(2023, 12, 26, 12, 46, 59, 585, DateTimeKind.Local).AddTicks(65),
                            IsImportant = false,
                            Title = "Sixth Note",
                            Updated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Domain.WorkTask", b =>
                {
                    b.HasBaseType("Domain.Note");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.ToTable("WorkTasks", (string)null);
                });

            modelBuilder.Entity("Domain.WorkTask", b =>
                {
                    b.HasOne("Domain.Note", null)
                        .WithOne()
                        .HasForeignKey("Domain.WorkTask", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}