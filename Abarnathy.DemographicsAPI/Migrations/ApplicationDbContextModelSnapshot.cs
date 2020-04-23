﻿// <auto-generated />
using Abarnathy.DemographicsAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Abarnathy.DemographicsAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Abarnathy.DemographicsAPI.Models.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HouseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZIPCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Abarnathy.DemographicsAPI.Models.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FamilyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GivenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SexId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SexId");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("Abarnathy.DemographicsAPI.Models.Entities.PatientAddress", b =>
                {
                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.HasKey("PatientId", "AddressId");

                    b.HasIndex("AddressId");

                    b.ToTable("PatientAddress");
                });

            modelBuilder.Entity("Abarnathy.DemographicsAPI.Models.Entities.PatientTelephoneNumber", b =>
                {
                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("TelephoneNumberId")
                        .HasColumnType("int");

                    b.HasKey("PatientId", "TelephoneNumberId");

                    b.HasIndex("TelephoneNumberId");

                    b.ToTable("PatientTelephoneNumber");
                });

            modelBuilder.Entity("Abarnathy.DemographicsAPI.Models.Entities.TelephoneNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TelephoneNumber");
                });

            modelBuilder.Entity("Abarnathy.DemographicsAPI.Models.Sex", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sex");
                });

            modelBuilder.Entity("Abarnathy.DemographicsAPI.Models.Entities.Patient", b =>
                {
                    b.HasOne("Abarnathy.DemographicsAPI.Models.Sex", "Sex")
                        .WithMany()
                        .HasForeignKey("SexId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Abarnathy.DemographicsAPI.Models.Entities.PatientAddress", b =>
                {
                    b.HasOne("Abarnathy.DemographicsAPI.Models.Entities.Address", "Address")
                        .WithMany("PatientAddress")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Abarnathy.DemographicsAPI.Models.Entities.Patient", "Patient")
                        .WithMany("PatientAddresses")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Abarnathy.DemographicsAPI.Models.Entities.PatientTelephoneNumber", b =>
                {
                    b.HasOne("Abarnathy.DemographicsAPI.Models.Entities.Patient", "Patient")
                        .WithMany("PatientTelephoneNumbers")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Abarnathy.DemographicsAPI.Models.Entities.TelephoneNumber", "TelephoneNumber")
                        .WithMany("PatientTelephoneNumbers")
                        .HasForeignKey("TelephoneNumberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
