﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Perscription.Models;

#nullable disable

namespace Perscription.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230523214700_AppUser")]
    partial class AppUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Perscription.Models.AppUser", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"));

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdUser");

                    b.ToTable("AppUser");

                    b.HasData(
                        new
                        {
                            IdUser = 1,
                            Login = "Adam",
                            Password = "123123123"
                        },
                        new
                        {
                            IdUser = 2,
                            Login = "Kasia",
                            Password = "Password"
                        });
                });

            modelBuilder.Entity("Perscription.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDoctor"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdDoctor");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "d.bab@gmail.com",
                            FirstName = "Dominik",
                            LastName = "Babacki"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "e.jan@gmail.com",
                            FirstName = "Emil",
                            LastName = "Janacki"
                        });
                });

            modelBuilder.Entity("Perscription.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMedicament"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdMedicament");

                    b.ToTable("Medicaments");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            Description = "Lek przeciwbólowy",
                            Name = "Aspiryna",
                            Type = "Przeciwbólowy"
                        },
                        new
                        {
                            IdMedicament = 2,
                            Description = "Używać zgodnie z zaleceniami lekarza",
                            Name = "Zyrtec",
                            Type = "Przeciwalergiczny"
                        });
                });

            modelBuilder.Entity("Perscription.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPatient"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdPatient");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            IdPatient = 1,
                            BirthDate = new DateTime(2023, 5, 23, 23, 47, 0, 249, DateTimeKind.Local).AddTicks(3702),
                            FirstName = "Adam",
                            LastName = "Kowalski"
                        },
                        new
                        {
                            IdPatient = 2,
                            BirthDate = new DateTime(2023, 5, 23, 23, 47, 0, 249, DateTimeKind.Local).AddTicks(3751),
                            FirstName = "Jan",
                            LastName = "Kabacki"
                        });
                });

            modelBuilder.Entity("Perscription.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPrescription"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.ToTable("Perscriptions");

                    b.HasData(
                        new
                        {
                            IdPrescription = 1,
                            Date = new DateTime(2023, 5, 23, 23, 47, 0, 249, DateTimeKind.Local).AddTicks(3879),
                            DueDate = new DateTime(2023, 5, 23, 23, 47, 0, 249, DateTimeKind.Local).AddTicks(3881),
                            IdDoctor = 2,
                            IdPatient = 1
                        },
                        new
                        {
                            IdPrescription = 2,
                            Date = new DateTime(2023, 5, 23, 23, 47, 0, 249, DateTimeKind.Local).AddTicks(3886),
                            DueDate = new DateTime(2023, 5, 23, 23, 47, 0, 249, DateTimeKind.Local).AddTicks(3887),
                            IdDoctor = 2,
                            IdPatient = 2
                        });
                });

            modelBuilder.Entity("Perscription.Models.PrescriptionMedicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdMedicament", "IdPrescription");

                    b.HasIndex("IdPrescription");

                    b.ToTable("Perscription_Medicament", (string)null);

                    b.HasData(
                        new
                        {
                            IdMedicament = 2,
                            IdPrescription = 1,
                            Details = "Dwa razy dziennie, jedna tabletka",
                            Dose = 3
                        },
                        new
                        {
                            IdMedicament = 1,
                            IdPrescription = 2,
                            Details = "Stosować przez 2 tygodnie"
                        });
                });

            modelBuilder.Entity("Perscription.Models.Prescription", b =>
                {
                    b.HasOne("Perscription.Models.Doctor", "Doctor")
                        .WithMany("DoctorsPrescription")
                        .HasForeignKey("IdDoctor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Perscription.Models.Patient", "Patient")
                        .WithMany("PatientsPresciption")
                        .HasForeignKey("IdPatient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Perscription.Models.PrescriptionMedicament", b =>
                {
                    b.HasOne("Perscription.Models.Medicament", "Medicament")
                        .WithMany("MedicamentsPrescription")
                        .HasForeignKey("IdMedicament")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Perscription.Models.Prescription", "Prescription")
                        .WithMany("PrescriptionsMedicament")
                        .HasForeignKey("IdPrescription")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicament");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("Perscription.Models.Doctor", b =>
                {
                    b.Navigation("DoctorsPrescription");
                });

            modelBuilder.Entity("Perscription.Models.Medicament", b =>
                {
                    b.Navigation("MedicamentsPrescription");
                });

            modelBuilder.Entity("Perscription.Models.Patient", b =>
                {
                    b.Navigation("PatientsPresciption");
                });

            modelBuilder.Entity("Perscription.Models.Prescription", b =>
                {
                    b.Navigation("PrescriptionsMedicament");
                });
#pragma warning restore 612, 618
        }
    }
}
