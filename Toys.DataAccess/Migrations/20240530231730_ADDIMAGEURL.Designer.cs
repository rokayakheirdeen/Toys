﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Toys.DataAccess.Data;

#nullable disable

namespace Toys.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240530231730_ADDIMAGEURL")]
    partial class ADDIMAGEURL
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.1.23111.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Toys.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DisplayOrder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = "1",
                            Title = "Doll"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = "2",
                            Title = "Puzzle"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = "3",
                            Title = "Action"
                        });
                });

            modelBuilder.Entity("Toys.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Feedbacks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Great service!",
                            Rating = 5,
                            Timestamp = new DateTime(2024, 5, 31, 2, 17, 30, 503, DateTimeKind.Local).AddTicks(9505),
                            UserId = "user1"
                        },
                        new
                        {
                            Id = 2,
                            Comment = "Good experience.",
                            Rating = 4,
                            Timestamp = new DateTime(2024, 5, 31, 2, 17, 30, 503, DateTimeKind.Local).AddTicks(9508),
                            UserId = "user2"
                        });
                });

            modelBuilder.Entity("Toys.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 3,
                            Description = "A cool action figure hero that kids love to play with.",
                            ImageUrl = "https://www.understandingboys.com.au/wp-content/uploads/2016/05/boys_story/iStock_000055193358_Large.jpg",
                            ListPrice = 15.0,
                            Manufacturer = "Toy Corp",
                            Price = 13.0,
                            Price100 = 10.0,
                            Price50 = 12.0,
                            SKU = "TF123456",
                            Title = "Action Figure Hero"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "A set of colorful building blocks to spark creativity.",
                            ImageUrl = "https://www.momjunction.com/wp-content/uploads/2021/12/20-Best-Building-Block-Activities-For-Preschoolers.jpg",
                            ListPrice = 40.0,
                            Manufacturer = "Block Masters",
                            Price = 35.0,
                            Price100 = 25.0,
                            Price50 = 30.0,
                            SKU = "BB654321",
                            Title = "Building Blocks Set"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "A fast and fun remote control car for racing.",
                            ImageUrl = "https://www.momdot.com/wp-content/uploads/2020/08/rc-car.jpg",
                            ListPrice = 60.0,
                            Manufacturer = "Speed Toys",
                            Price = 55.0,
                            Price100 = 45.0,
                            Price50 = 50.0,
                            SKU = "RC987654",
                            Title = "Remote Control Car"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "A soft and cuddly teddy bear perfect for hugs.",
                            ImageUrl = "https://m.media-amazon.com/images/I/71rsKl1oUAL.jpg",
                            ListPrice = 25.0,
                            Manufacturer = "Soft Toys Co.",
                            Price = 22.0,
                            Price100 = 18.0,
                            Price50 = 20.0,
                            SKU = "TB112233",
                            Title = "Plush Teddy Bear"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "An educational puzzle that helps kids learn and have fun.",
                            ImageUrl = "https://i.etsystatic.com/20475480/r/il/3697d6/2931743629/il_1140xN.2931743629_e70o.jpg",
                            ListPrice = 20.0,
                            Manufacturer = "Brainy Kids",
                            Price = 18.0,
                            Price100 = 14.0,
                            Price50 = 16.0,
                            SKU = "PUZ334455",
                            Title = "Educational Puzzle"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "A beautiful dollhouse set with furniture and dolls.",
                            ImageUrl = "https://i.pinimg.com/originals/f6/5a/87/f65a8724264f38a23d4e78ee9152e58d.jpg",
                            ListPrice = 80.0,
                            Manufacturer = "Dreamland",
                            Price = 75.0,
                            Price100 = 65.0,
                            Price50 = 70.0,
                            SKU = "DH445566",
                            Title = "Dollhouse Set"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "An advanced set of building blocks to inspire creativity.",
                            ImageUrl = "https://www.momjunction.com/wp-content/uploads/2021/12/20-Best-Building-Block-Activities-For-Preschoolers.jpg",
                            ListPrice = 50.0,
                            Manufacturer = "Block Innovations",
                            Price = 45.0,
                            Price100 = 35.0,
                            Price50 = 40.0,
                            SKU = "BB789012",
                            Title = "Building Blocks Deluxe Set"
                        });
                });

            modelBuilder.Entity("Toys.Models.Product", b =>
                {
                    b.HasOne("Toys.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
