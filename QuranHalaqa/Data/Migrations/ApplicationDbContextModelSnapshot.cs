﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuranHalaqa.Data;

namespace QuranHalaqa.Data.Migrations
{
    [DbContext(typeof(HalaqaDB))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("QuranHalaqa.Models.Contacts", b =>
                {
                    b.Property<int>("ContactsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactAddress");

                    b.Property<string>("ContactEmail");

                    b.Property<string>("ContactFirstName");

                    b.Property<string>("ContactLastName");

                    b.Property<string>("ContactPhone");

                    b.Property<string>("RelationshipToStudents");

                    b.Property<int>("StudentId");

                    b.HasKey("ContactsId");

                    b.HasIndex("StudentId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("QuranHalaqa.Models.Exam", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ExamLimitMistakes");

                    b.Property<string>("ExamLimitSelfies");

                    b.Property<string>("ExamOverAllComments");

                    b.Property<string>("OverAllMistakes");

                    b.Property<string>("OverAllResult");

                    b.Property<string>("OverAllSelfies");

                    b.Property<int>("QuranJuzId");

                    b.Property<int>("StudentId");

                    b.HasKey("ExamId");

                    b.HasIndex("QuranJuzId");

                    b.HasIndex("StudentId");

                    b.ToTable("Exam");
                });

            modelBuilder.Entity("QuranHalaqa.Models.ExamEntry", b =>
                {
                    b.Property<int>("ExamEntryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExamId");

                    b.Property<string>("SuraComment");

                    b.Property<string>("SuraMistakes");

                    b.Property<string>("SuraResult");

                    b.Property<string>("SuraSelfies");

                    b.HasKey("ExamEntryId");

                    b.HasIndex("ExamId");

                    b.ToTable("ExamEntry");
                });

            modelBuilder.Entity("QuranHalaqa.Models.Halaqa", b =>
                {
                    b.Property<int>("HalaqaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate");

                    b.Property<bool>("DayFriday");

                    b.Property<bool>("DayMonday");

                    b.Property<bool>("DaySaturday");

                    b.Property<bool>("DaySunday");

                    b.Property<bool>("DayThursday");

                    b.Property<bool>("DayTuesday");

                    b.Property<bool>("DayWednesday");

                    b.Property<DateTime?>("HalaqaEndDate");

                    b.Property<string>("HalaqaEndTime");

                    b.Property<string>("HalaqaName");

                    b.Property<DateTime>("HalaqaStartDate");

                    b.Property<string>("HalaqaStartTime");

                    b.Property<int>("SheikhId");

                    b.HasKey("HalaqaId");

                    b.HasIndex("SheikhId");

                    b.ToTable("Halaqa");
                });

            modelBuilder.Entity("QuranHalaqa.Models.HalaqaSession", b =>
                {
                    b.Property<int>("HalaqaSessionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HalaqaId");

                    b.Property<DateTime>("HalaqaSessionDate");

                    b.Property<bool>("IsCanceled");

                    b.Property<string>("ReasonCanceled");

                    b.HasKey("HalaqaSessionId");

                    b.HasIndex("HalaqaId");

                    b.ToTable("HalaqaSession");
                });

            modelBuilder.Entity("QuranHalaqa.Models.QuranJuz", b =>
                {
                    b.Property<int>("QuranJuzId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("JuzName");

                    b.Property<string>("JuzNumber");

                    b.HasKey("QuranJuzId");

                    b.ToTable("Quranjuz");
                });

            modelBuilder.Entity("QuranHalaqa.Models.QuranSura", b =>
                {
                    b.Property<int>("QuranSuraId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumberOfAyas");

                    b.Property<int>("QuranJuzId");

                    b.Property<string>("SuraName");

                    b.Property<string>("SuraNumber");

                    b.HasKey("QuranSuraId");

                    b.HasIndex("QuranJuzId");

                    b.ToTable("QuranSura");
                });

            modelBuilder.Entity("QuranHalaqa.Models.Sheikh", b =>
                {
                    b.Property<int>("SheikhId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SheikhCellNumber");

                    b.Property<string>("SheikhEmail");

                    b.Property<string>("SheikhFirstName");

                    b.Property<string>("SheikhHomeAddress");

                    b.Property<string>("SheikhLastName");

                    b.HasKey("SheikhId");

                    b.ToTable("Sheikh");
                });

            modelBuilder.Entity("QuranHalaqa.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("ContactNumber");

                    b.Property<string>("Email");

                    b.Property<int?>("HalaqaId");

                    b.Property<string>("ParentName");

                    b.Property<string>("Reason");

                    b.Property<string>("StudentFirstName");

                    b.Property<string>("StudentLastName");

                    b.Property<string>("StudentNumber");

                    b.Property<string>("StudentStatus");

                    b.HasKey("StudentId");

                    b.HasIndex("HalaqaId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("QuranHalaqa.Models.StudentWork", b =>
                {
                    b.Property<int>("StudentWorkId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssignedWork");

                    b.Property<int>("AssignedWorkMistakes");

                    b.Property<int>("AssignedWorkSelfies");

                    b.Property<string>("AssignedWorkStatus");

                    b.Property<string>("Comment");

                    b.Property<int>("HalaqaSessionId");

                    b.Property<bool>("IsPresent");

                    b.Property<string>("NewRevision");

                    b.Property<string>("NewWork");

                    b.Property<string>("Revision");

                    b.Property<int>("RevisionMistakes");

                    b.Property<int>("RevisionSelfies");

                    b.Property<string>("RevisionStatus");

                    b.Property<int>("StudentId");

                    b.Property<string>("WorkDueDate");

                    b.HasKey("StudentWorkId");

                    b.HasIndex("HalaqaSessionId");

                    b.HasIndex("StudentId", "HalaqaSessionId")
                        .IsUnique();

                    b.ToTable("StudentWork");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuranHalaqa.Models.Contacts", b =>
                {
                    b.HasOne("QuranHalaqa.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuranHalaqa.Models.Exam", b =>
                {
                    b.HasOne("QuranHalaqa.Models.QuranJuz", "QuranJuz")
                        .WithMany()
                        .HasForeignKey("QuranJuzId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QuranHalaqa.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuranHalaqa.Models.ExamEntry", b =>
                {
                    b.HasOne("QuranHalaqa.Models.Exam", "Exam")
                        .WithMany()
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuranHalaqa.Models.Halaqa", b =>
                {
                    b.HasOne("QuranHalaqa.Models.Sheikh", "Sheikh")
                        .WithMany()
                        .HasForeignKey("SheikhId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuranHalaqa.Models.HalaqaSession", b =>
                {
                    b.HasOne("QuranHalaqa.Models.Halaqa", "Halaqa")
                        .WithMany()
                        .HasForeignKey("HalaqaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuranHalaqa.Models.QuranSura", b =>
                {
                    b.HasOne("QuranHalaqa.Models.QuranJuz", "QuranJuz")
                        .WithMany()
                        .HasForeignKey("QuranJuzId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuranHalaqa.Models.Student", b =>
                {
                    b.HasOne("QuranHalaqa.Models.Halaqa", "Halaqa")
                        .WithMany("Student")
                        .HasForeignKey("HalaqaId");
                });

            modelBuilder.Entity("QuranHalaqa.Models.StudentWork", b =>
                {
                    b.HasOne("QuranHalaqa.Models.HalaqaSession", "HalaqaSession")
                        .WithMany("StudentWork")
                        .HasForeignKey("HalaqaSessionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QuranHalaqa.Models.Student", "Student")
                        .WithMany("StudentWork")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
