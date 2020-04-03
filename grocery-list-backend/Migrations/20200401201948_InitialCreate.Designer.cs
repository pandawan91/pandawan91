﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using grocery_list_backend.DataAccess;

namespace grocery_list_backend.Migrations
{
    [DbContext(typeof(MysqlDbContext))]
    [Migration("20200401201948_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("grocery_list_backend.Models.GroceryListItemModel", b =>
                {
                    b.Property<int>("GroceryListItemModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("GroceryListItemModelId");

                    b.ToTable("GroceryListItems");
                });
#pragma warning restore 612, 618
        }
    }
}