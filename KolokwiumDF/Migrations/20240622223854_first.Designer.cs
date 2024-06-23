﻿// <auto-generated />
using System;
using KolokwiumDF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KolokwiumDF.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240622223854_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KolokwiumDF.Models.Client", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdClient"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdClient");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            IdClient = 1,
                            Email = "jan.Kowalski@gmail.com",
                            FirstName = "Jan",
                            LastName = "Kowalski",
                            Phone = "123456789"
                        });
                });

            modelBuilder.Entity("KolokwiumDF.Models.Discount", b =>
                {
                    b.Property<int>("IdDiscount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDiscount"));

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("IdDiscount");

                    b.HasIndex("IdClient");

                    b.ToTable("Discounts");

                    b.HasData(
                        new
                        {
                            IdDiscount = 1,
                            DateFrom = new DateTime(2024, 6, 23, 0, 38, 54, 101, DateTimeKind.Local).AddTicks(1000),
                            DateTo = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdClient = 1,
                            Value = 10
                        });
                });

            modelBuilder.Entity("KolokwiumDF.Models.Payment", b =>
                {
                    b.Property<int>("IdPayment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPayment"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int>("IdSubcription")
                        .HasColumnType("int");

                    b.HasKey("IdPayment");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            IdPayment = 1,
                            Date = new DateTime(2024, 6, 23, 0, 38, 54, 100, DateTimeKind.Local).AddTicks(9760),
                            IdClient = 1,
                            IdSubcription = 1
                        });
                });

            modelBuilder.Entity("KolokwiumDF.Models.Sale", b =>
                {
                    b.Property<int>("IdSale")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSale"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int>("IdSubscription")
                        .HasColumnType("int");

                    b.HasKey("IdSale");

                    b.HasIndex("IdClient");

                    b.HasIndex("IdSubscription");

                    b.ToTable("Sales");

                    b.HasData(
                        new
                        {
                            IdSale = 1,
                            CreatedAt = new DateTime(2024, 6, 23, 0, 38, 54, 100, DateTimeKind.Local).AddTicks(9310),
                            IdClient = 1,
                            IdSubscription = 1
                        });
                });

            modelBuilder.Entity("KolokwiumDF.Models.Subscription", b =>
                {
                    b.Property<int>("IdSubscription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSubscription"));

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("RenewalPeriod")
                        .HasColumnType("int");

                    b.HasKey("IdSubscription");

                    b.ToTable("Subscriptions");

                    b.HasData(
                        new
                        {
                            IdSubscription = 1,
                            EndTime = new DateTime(2024, 6, 23, 0, 38, 54, 100, DateTimeKind.Local).AddTicks(9580),
                            Name = "AAA",
                            Price = 300,
                            RenewalPeriod = 1
                        });
                });

            modelBuilder.Entity("KolokwiumDF.Models.Discount", b =>
                {
                    b.HasOne("KolokwiumDF.Models.Client", "Client")
                        .WithMany("Discounts")
                        .HasForeignKey("IdClient")
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("KolokwiumDF.Models.Sale", b =>
                {
                    b.HasOne("KolokwiumDF.Models.Client", "Client")
                        .WithMany("Sales")
                        .HasForeignKey("IdClient")
                        .IsRequired();

                    b.HasOne("KolokwiumDF.Models.Subscription", "Subscription")
                        .WithMany("Sales")
                        .HasForeignKey("IdSubscription")
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("KolokwiumDF.Models.Client", b =>
                {
                    b.Navigation("Discounts");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("KolokwiumDF.Models.Subscription", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
