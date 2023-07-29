﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SalesAd.Infra.Context;

#nullable disable

namespace SalesAd.Infra.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SalesAd.Domain.Entities.AnnouncementEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uuid");

                    b.Property<short?>("RoomsNumber")
                        .HasColumnType("smallint");

                    b.Property<int>("Size")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("Value")
                        .HasColumnType("DECIMAL(15,2)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("TB_ANNOUNCEMENT", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("eee36630-ea54-49b3-916e-71239a59688b"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(4825),
                            Description = "Ground test 1",
                            OwnerId = new Guid("59401ca7-bc66-40d3-ac70-a24409751d97"),
                            Size = 250,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(4826),
                            Value = 100000m
                        },
                        new
                        {
                            Id = new Guid("d6940989-0b2f-4f44-969b-6408defca4af"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5276),
                            Description = "Ground test 2 59401ca7",
                            OwnerId = new Guid("59401ca7-bc66-40d3-ac70-a24409751d97"),
                            Size = 350,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5277),
                            Value = 200000m
                        },
                        new
                        {
                            Id = new Guid("e3e651a6-2c3d-466f-b701-fa94bac8f44b"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5414),
                            Description = "Ground test 3 59401ca7",
                            OwnerId = new Guid("59401ca7-bc66-40d3-ac70-a24409751d97"),
                            Size = 450,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5415),
                            Value = 300000m
                        },
                        new
                        {
                            Id = new Guid("8f6f2986-c5aa-4f7d-97e0-4105e7948754"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5571),
                            Description = "Ground test 4 59401ca7",
                            OwnerId = new Guid("59401ca7-bc66-40d3-ac70-a24409751d97"),
                            Size = 550,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5571),
                            Value = 400000m
                        },
                        new
                        {
                            Id = new Guid("720676f8-c5e1-4e0e-88ba-de39602ba8f1"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5835),
                            Description = "Ground test 5 59401ca7",
                            OwnerId = new Guid("59401ca7-bc66-40d3-ac70-a24409751d97"),
                            Size = 650,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5835),
                            Value = 500000m
                        },
                        new
                        {
                            Id = new Guid("3f8d2b1d-eca9-4134-8fe4-d121179898ee"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5946),
                            Description = "Ground test 2 b692b631",
                            OwnerId = new Guid("b692b631-897c-4993-a957-e18a3a2dcdbf"),
                            Size = 351,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(5947),
                            Value = 210000m
                        },
                        new
                        {
                            Id = new Guid("f0123afa-c030-4b1e-9553-cf57d4d0769b"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6047),
                            Description = "Ground test 3 b692b631",
                            OwnerId = new Guid("b692b631-897c-4993-a957-e18a3a2dcdbf"),
                            Size = 451,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6047),
                            Value = 310000m
                        },
                        new
                        {
                            Id = new Guid("352d501d-8dc4-4e27-b115-0970da692159"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6165),
                            Description = "Ground test 4 b692b631",
                            OwnerId = new Guid("b692b631-897c-4993-a957-e18a3a2dcdbf"),
                            Size = 551,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6165),
                            Value = 410000m
                        },
                        new
                        {
                            Id = new Guid("62b4fbbc-8208-4fa3-95b2-36d1a0f598aa"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6370),
                            Description = "Ground test 5 b692b631",
                            OwnerId = new Guid("b692b631-897c-4993-a957-e18a3a2dcdbf"),
                            Size = 651,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6371),
                            Value = 510000m
                        },
                        new
                        {
                            Id = new Guid("4d690858-a5af-4015-8742-605cfeecf814"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6526),
                            Description = "Ground test 2 042ad764",
                            OwnerId = new Guid("042ad764-addc-43f9-92dd-d050a16e1801"),
                            Size = 352,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6527),
                            Value = 220000m
                        },
                        new
                        {
                            Id = new Guid("69d3b780-ce77-4371-ab2b-20649da8e09f"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6700),
                            Description = "Ground test 3 042ad764",
                            OwnerId = new Guid("042ad764-addc-43f9-92dd-d050a16e1801"),
                            Size = 452,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6701),
                            Value = 320000m
                        },
                        new
                        {
                            Id = new Guid("9791b2ff-53cf-41c9-a3d2-eb81fea8af12"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6795),
                            Description = "Ground test 4 042ad764",
                            OwnerId = new Guid("042ad764-addc-43f9-92dd-d050a16e1801"),
                            Size = 552,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6795),
                            Value = 420000m
                        },
                        new
                        {
                            Id = new Guid("7e97f86c-ada4-4b73-86a6-d02e67e69aa2"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6899),
                            Description = "Ground test 5 042ad764",
                            OwnerId = new Guid("042ad764-addc-43f9-92dd-d050a16e1801"),
                            Size = 652,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(6900),
                            Value = 520000m
                        },
                        new
                        {
                            Id = new Guid("baa1d23f-ebe5-49f1-9926-106ec760b737"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7047),
                            Description = "Ground test 2 e1298a81",
                            OwnerId = new Guid("e1298a81-785b-423a-9aaa-dbd5ad3f8df9"),
                            Size = 353,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7048),
                            Value = 230000m
                        },
                        new
                        {
                            Id = new Guid("1f5b4a80-a1c7-46a1-9c89-c78c531e01e3"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7160),
                            Description = "Ground test 3 e1298a81",
                            OwnerId = new Guid("e1298a81-785b-423a-9aaa-dbd5ad3f8df9"),
                            Size = 453,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7161),
                            Value = 330000m
                        },
                        new
                        {
                            Id = new Guid("cb5442e5-d8ca-4783-987f-9b10bf398e4b"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7417),
                            Description = "Ground test 4 e1298a81",
                            OwnerId = new Guid("e1298a81-785b-423a-9aaa-dbd5ad3f8df9"),
                            Size = 553,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7418),
                            Value = 430000m
                        },
                        new
                        {
                            Id = new Guid("45e13dca-8889-49ce-ad3c-29fd92a22e2b"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7511),
                            Description = "Ground test 5 e1298a81",
                            OwnerId = new Guid("e1298a81-785b-423a-9aaa-dbd5ad3f8df9"),
                            Size = 653,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7512),
                            Value = 530000m
                        },
                        new
                        {
                            Id = new Guid("a3961af0-a4e3-4388-9cd4-01ce1d0ee2fe"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7608),
                            Description = "Ground test 2 5db55f64",
                            OwnerId = new Guid("5db55f64-1c3d-4ddc-9859-d55060946588"),
                            Size = 353,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7609),
                            Value = 240000m
                        },
                        new
                        {
                            Id = new Guid("d7095d49-64f5-4385-aeeb-05b2b8926b4e"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7729),
                            Description = "Ground test 3 5db55f64",
                            OwnerId = new Guid("5db55f64-1c3d-4ddc-9859-d55060946588"),
                            Size = 453,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7730),
                            Value = 340000m
                        },
                        new
                        {
                            Id = new Guid("f91eae07-e620-4c26-9f54-21c5ae1abd02"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7819),
                            Description = "Ground test 4 5db55f64",
                            OwnerId = new Guid("5db55f64-1c3d-4ddc-9859-d55060946588"),
                            Size = 553,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(7820),
                            Value = 440000m
                        },
                        new
                        {
                            Id = new Guid("9e0ceef7-24d6-4ab8-b643-0a4f67722360"),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(8045),
                            Description = "Ground test 5 5db55f64",
                            OwnerId = new Guid("5db55f64-1c3d-4ddc-9859-d55060946588"),
                            Size = 653,
                            Type = 2,
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(8046),
                            Value = 540000m
                        });
                });

            modelBuilder.Entity("SalesAd.Domain.Entities.OwnerEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("TB_OWNER", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("59401ca7-bc66-40d3-ac70-a24409751d97"),
                            Active = true,
                            BirthDate = new DateTime(2000, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(2195),
                            Email = "marcossantos@email.com",
                            Name = "Marcos dos Santos",
                            Phone = "11912345678",
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(2196)
                        },
                        new
                        {
                            Id = new Guid("b692b631-897c-4993-a957-e18a3a2dcdbf"),
                            Active = true,
                            BirthDate = new DateTime(2005, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(3488),
                            Email = "anaferreira@email.com",
                            Name = "Ana Ferreira",
                            Phone = "11912345679",
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(3488)
                        },
                        new
                        {
                            Id = new Guid("042ad764-addc-43f9-92dd-d050a16e1801"),
                            Active = true,
                            BirthDate = new DateTime(2001, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(3695),
                            Email = "luizr@email.com",
                            Name = "Luiz Rodrigues",
                            Phone = "11912345658",
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(3696)
                        },
                        new
                        {
                            Id = new Guid("e1298a81-785b-423a-9aaa-dbd5ad3f8df9"),
                            Active = true,
                            BirthDate = new DateTime(1999, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(3904),
                            Email = "marionas@email.com",
                            Name = "Mario Nascimento",
                            Phone = "11912345620",
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(3905)
                        },
                        new
                        {
                            Id = new Guid("5db55f64-1c3d-4ddc-9859-d55060946588"),
                            Active = true,
                            BirthDate = new DateTime(1999, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(4142),
                            Email = "mariaalves@email.com",
                            Name = "Maria Alves",
                            Phone = "11912345620",
                            UpdatedAt = new DateTime(2023, 7, 27, 17, 4, 27, 574, DateTimeKind.Utc).AddTicks(4142)
                        });
                });

            modelBuilder.Entity("SalesAd.Domain.Entities.AnnouncementEntity", b =>
                {
                    b.HasOne("SalesAd.Domain.Entities.OwnerEntity", "Owner")
                        .WithMany("Announcements")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("SalesAd.Domain.VO.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uuid");

                            b1.Property<Guid>("AnnouncementId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("Neighborhood")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<int?>("Number")
                                .HasColumnType("integer");

                            b1.Property<string>("State")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("StreetName")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("Id");

                            b1.HasIndex("AnnouncementId")
                                .IsUnique();

                            b1.ToTable("TB_ANNOUNCEMENT_ADDRESS", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("AnnouncementId");

                            b1.HasData(
                                new
                                {
                                    Id = new Guid("d3b9afbd-ee69-4730-ae85-cdf84b1e0e80"),
                                    AnnouncementId = new Guid("eee36630-ea54-49b3-916e-71239a59688b"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("c003c7d2-fc8c-462f-aa54-5ae63fbbf61c"),
                                    AnnouncementId = new Guid("d6940989-0b2f-4f44-969b-6408defca4af"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("589f5d67-8027-4d1d-b542-6f16fc0d2f48"),
                                    AnnouncementId = new Guid("e3e651a6-2c3d-466f-b701-fa94bac8f44b"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("afdf8857-990e-4201-8027-b0342987b8ce"),
                                    AnnouncementId = new Guid("8f6f2986-c5aa-4f7d-97e0-4105e7948754"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("344a58c6-3e45-46a5-ad9d-61541a6c72b4"),
                                    AnnouncementId = new Guid("720676f8-c5e1-4e0e-88ba-de39602ba8f1"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("47f4bf2f-c0f7-4291-978e-d1ffe0b0a421"),
                                    AnnouncementId = new Guid("3f8d2b1d-eca9-4134-8fe4-d121179898ee"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("9913e01f-3f76-4f68-aa29-f0a0e6366430"),
                                    AnnouncementId = new Guid("f0123afa-c030-4b1e-9553-cf57d4d0769b"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("dba3543d-f088-4e84-bd60-5d219da88f65"),
                                    AnnouncementId = new Guid("352d501d-8dc4-4e27-b115-0970da692159"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("3edb6789-27b3-463f-ad68-2dd2659f0692"),
                                    AnnouncementId = new Guid("62b4fbbc-8208-4fa3-95b2-36d1a0f598aa"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("c4076ee7-16b1-41a9-8e6e-eae21551b6e9"),
                                    AnnouncementId = new Guid("4d690858-a5af-4015-8742-605cfeecf814"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("8fe96bd5-4e21-40a3-b54a-b772635d19bc"),
                                    AnnouncementId = new Guid("69d3b780-ce77-4371-ab2b-20649da8e09f"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("89ea1c81-10c3-448e-877d-0eb4dab35cef"),
                                    AnnouncementId = new Guid("9791b2ff-53cf-41c9-a3d2-eb81fea8af12"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("2ff5dd3c-e5e1-4579-b4b0-4b659a8d2c5e"),
                                    AnnouncementId = new Guid("7e97f86c-ada4-4b73-86a6-d02e67e69aa2"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("74ee1759-5dc6-4296-b140-c14c7a8aeac8"),
                                    AnnouncementId = new Guid("baa1d23f-ebe5-49f1-9926-106ec760b737"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("9e467400-bfef-4dba-8aad-be41d60013a8"),
                                    AnnouncementId = new Guid("1f5b4a80-a1c7-46a1-9c89-c78c531e01e3"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("c01cf521-e2f8-422f-91fa-3946139dc2c5"),
                                    AnnouncementId = new Guid("cb5442e5-d8ca-4783-987f-9b10bf398e4b"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("2cdf86ca-dd76-49e2-9f09-28af4a480f90"),
                                    AnnouncementId = new Guid("45e13dca-8889-49ce-ad3c-29fd92a22e2b"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("bb2ad1bc-e49b-4be8-b3c5-830d758ca69f"),
                                    AnnouncementId = new Guid("a3961af0-a4e3-4388-9cd4-01ce1d0ee2fe"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("f2c5d447-6e98-4371-8866-5535ba174d66"),
                                    AnnouncementId = new Guid("d7095d49-64f5-4385-aeeb-05b2b8926b4e"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("6e8762ff-4c31-4cf8-bacd-bb2aeee423fa"),
                                    AnnouncementId = new Guid("f91eae07-e620-4c26-9f54-21c5ae1abd02"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                },
                                new
                                {
                                    Id = new Guid("17c44cbe-9a76-4348-b7c1-b2821e68260c"),
                                    AnnouncementId = new Guid("9e0ceef7-24d6-4ab8-b643-0a4f67722360"),
                                    Country = "BR",
                                    Neighborhood = "Bairro 1",
                                    Number = 12,
                                    State = "MG",
                                    StreetName = "Street DOTNET 7",
                                    ZipCode = "14785000"
                                });
                        });

                    b.Navigation("Address");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("SalesAd.Domain.Entities.OwnerEntity", b =>
                {
                    b.Navigation("Announcements");
                });
#pragma warning restore 612, 618
        }
    }
}
