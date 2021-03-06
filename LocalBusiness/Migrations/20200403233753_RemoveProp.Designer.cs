﻿// <auto-generated />
using LocalBusiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalBusiness.Migrations
{
    [DbContext(typeof(LocalBusinessContext))]
    [Migration("20200403233753_RemoveProp")]
    partial class RemoveProp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LocalBusiness.Models.Business", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("ADA");

                    b.Property<int>("CertNumber");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<decimal>("Latitude");

                    b.Property<decimal>("Longitude");

                    b.Property<string>("Manager")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<int>("YearJoined");

                    b.HasKey("BusinessId");

                    b.ToTable("Businesses");

                    b.HasData(
                        new
                        {
                            BusinessId = 6,
                            ADA = true,
                            CertNumber = 1234,
                            Email = "sde@asdf.com",
                            Latitude = 123.123132m,
                            Longitude = 234.34556m,
                            Manager = "Tom",
                            Name = "Tiki",
                            Phone = "123-2345",
                            YearJoined = 2007
                        },
                        new
                        {
                            BusinessId = 7,
                            ADA = false,
                            CertNumber = 2345,
                            Email = "asd@asdf.com",
                            Latitude = 234.43589m,
                            Longitude = 123.123456m,
                            Manager = "Fred",
                            Name = "Rexie",
                            Phone = "123-1234",
                            YearJoined = 2010
                        },
                        new
                        {
                            BusinessId = 3,
                            ADA = true,
                            CertNumber = 3456,
                            Email = "arc@asdf.com",
                            Latitude = 123.456767m,
                            Longitude = 345.67878m,
                            Manager = "Steve",
                            Name = "Matilda",
                            Phone = "234-3456",
                            YearJoined = 2002
                        },
                        new
                        {
                            BusinessId = 4,
                            ADA = true,
                            CertNumber = 4567,
                            Email = "asd@asd.com",
                            Latitude = 123.123123m,
                            Longitude = 678.23456m,
                            Manager = "Becky",
                            Name = "Pip",
                            Phone = "123-345-3456",
                            YearJoined = 2004
                        },
                        new
                        {
                            BusinessId = 5,
                            ADA = false,
                            CertNumber = 5678,
                            Email = "ngr@asds.com",
                            Latitude = 123.123m,
                            Longitude = 456.23456m,
                            Manager = "Dinosaur",
                            Name = "Annie",
                            Phone = "234-2345",
                            YearJoined = 2022
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
