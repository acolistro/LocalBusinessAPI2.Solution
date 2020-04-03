﻿// <auto-generated />
using LocalBusiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalBusiness.Migrations
{
    [DbContext(typeof(LocalBusinessContext))]
    [Migration("20200403204342_JWT")]
    partial class JWT
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

                    b.Property<int>("CertNumber");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<decimal>("Location");

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
                            CertNumber = 1234,
                            Email = "sde@asdf.com",
                            Location = 123.123132m,
                            Manager = "Tom",
                            Name = "Tiki",
                            Phone = "123-2345",
                            YearJoined = 2007
                        },
                        new
                        {
                            BusinessId = 7,
                            CertNumber = 2345,
                            Email = "asd@asdf.com",
                            Location = 123.123456m,
                            Manager = "Fred",
                            Name = "Rexie",
                            Phone = "123-1234",
                            YearJoined = 2010
                        },
                        new
                        {
                            BusinessId = 3,
                            CertNumber = 3456,
                            Email = "arc@asdf.com",
                            Location = 123.456767m,
                            Manager = "Steve",
                            Name = "Matilda",
                            Phone = "234-3456",
                            YearJoined = 2002
                        },
                        new
                        {
                            BusinessId = 4,
                            CertNumber = 4567,
                            Email = "asd@asd.com",
                            Location = 123.123123m,
                            Manager = "Becky",
                            Name = "Pip",
                            Phone = "123-345-3456",
                            YearJoined = 2004
                        },
                        new
                        {
                            BusinessId = 5,
                            CertNumber = 5678,
                            Email = "ngr@asds.com",
                            Location = 123.123m,
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
