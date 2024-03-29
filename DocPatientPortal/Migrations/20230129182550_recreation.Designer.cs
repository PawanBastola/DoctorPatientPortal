﻿// <auto-generated />
using System;
using DocPatientPortal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DocPatientPortal.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230129182550_recreation")]
    partial class recreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DocPatientPortal.Models.Appointment", b =>
                {
                    b.Property<int>("aid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("adate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("doc_id")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("uid")
                        .HasColumnType("int");

                    b.HasKey("aid");

                    b.ToTable("appointment");
                });

            modelBuilder.Entity("DocPatientPortal.Models.Doctor_Details", b =>
                {
                    b.Property<int>("d_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("d_blood_group")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("d_certificate")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("d_city")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("d_contact")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("d_dob")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("d_email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("d_full_address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("d_full_name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("d_gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("d_speciality")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("d_state")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("d_username")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("d_id");

                    b.ToTable("doctor_details");
                });

            modelBuilder.Entity("DocPatientPortal.Models.Feedback", b =>
                {
                    b.Property<int>("fid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("fullname")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("message")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("role")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("fid");

                    b.ToTable("feedbacks");
                });

            modelBuilder.Entity("DocPatientPortal.Models.Organdetail", b =>
                {
                    b.Property<int>("org_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("bloodgroup")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("donername")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long>("mobilenumber")
                        .HasColumnType("bigint");

                    b.Property<string>("organ")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("status")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("org_id");

                    b.ToTable("organdetails");
                });

            modelBuilder.Entity("DocPatientPortal.Models.Patient_Details", b =>
                {
                    b.Property<int>("p_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("p_blood")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("p_city")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("p_contact")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("p_dob")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("p_email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("p_fulladdress")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("p_fullname")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("p_gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("p_photo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("p_state")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("p_username")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("p_id");

                    b.ToTable("patient_details");
                });

            modelBuilder.Entity("DocPatientPortal.Models.Prescription", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("information")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("medication")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("p_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("prescription");
                });

            modelBuilder.Entity("DocPatientPortal.Models.Speciality", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("spec")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id");

                    b.ToTable("speciality");
                });

            modelBuilder.Entity("DocPatientPortal.Models.Unavailability", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("absent_date")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("did")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("unavailability");
                });

            modelBuilder.Entity("DocPatientPortal.Models.User", b =>
                {
                    b.Property<int>("pid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("paddress")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("pblood")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("pname")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long>("pnumber")
                        .HasColumnType("bigint");

                    b.HasKey("pid");

                    b.ToTable("user");
                });

            modelBuilder.Entity("DocPatientPortal.Models.UserLogin", b =>
                {
                    b.Property<int>("uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("role")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("status")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("uid");

                    b.ToTable("userlogin");
                });
#pragma warning restore 612, 618
        }
    }
}
