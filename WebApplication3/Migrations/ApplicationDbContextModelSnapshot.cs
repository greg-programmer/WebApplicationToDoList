﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication3.Data;

#nullable disable

namespace WebApplication3.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication3.Models.ToDoList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Finished")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ToDoLists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Balayer le sol",
                            Finished = false,
                            Title = "Salon"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Faire la vaisselle",
                            Finished = false,
                            Title = "Cuisine"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Balayer le sol",
                            Finished = false,
                            Title = "Chambre"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}