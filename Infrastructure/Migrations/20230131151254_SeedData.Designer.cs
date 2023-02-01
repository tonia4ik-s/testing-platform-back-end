﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230131151254_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.Entities.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsRightAnswer")
                        .HasColumnType("bit");

                    b.Property<string>("OptionText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Options");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsRightAnswer = false,
                            OptionText = "Lviv",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 2,
                            IsRightAnswer = false,
                            OptionText = "Kharkiv",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 3,
                            IsRightAnswer = true,
                            OptionText = "Kyiv",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 4,
                            IsRightAnswer = false,
                            OptionText = "Chernigiv",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 5,
                            IsRightAnswer = false,
                            OptionText = "18",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 6,
                            IsRightAnswer = false,
                            OptionText = "9",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 7,
                            IsRightAnswer = true,
                            OptionText = "12",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 8,
                            IsRightAnswer = false,
                            OptionText = "27",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 9,
                            IsRightAnswer = true,
                            OptionText = "green",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 10,
                            IsRightAnswer = false,
                            OptionText = "blue",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 11,
                            IsRightAnswer = false,
                            OptionText = "pink",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 12,
                            IsRightAnswer = false,
                            OptionText = "purple",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 13,
                            IsRightAnswer = false,
                            OptionText = "true",
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 14,
                            IsRightAnswer = true,
                            OptionText = "false",
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 15,
                            IsRightAnswer = false,
                            OptionText = "uncertain",
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 16,
                            IsRightAnswer = false,
                            OptionText = "100",
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 17,
                            IsRightAnswer = false,
                            OptionText = "30",
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 18,
                            IsRightAnswer = true,
                            OptionText = "118",
                            QuestionId = 5
                        });
                });

            modelBuilder.Entity("Core.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("Mark")
                        .HasColumnType("real");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Mark = 2f,
                            QuestionText = "The capital of Ukraine is...",
                            TestId = 1
                        },
                        new
                        {
                            Id = 2,
                            Mark = 2f,
                            QuestionText = "3 + 3 * 3 = ...",
                            TestId = 1
                        },
                        new
                        {
                            Id = 3,
                            Mark = 2f,
                            QuestionText = "Which color will be, if mix blue and yellow?",
                            TestId = 1
                        },
                        new
                        {
                            Id = 4,
                            Mark = 2f,
                            QuestionText = "Tanya is older than Eric.\nCliff is older than Tanya.\nEric is older than Cliff.\nIf the first two statements are true, the third statement is",
                            TestId = 1
                        },
                        new
                        {
                            Id = 5,
                            Mark = 2f,
                            QuestionText = "How many elements are in the periodic table?",
                            TestId = 1
                        });
                });

            modelBuilder.Entity("Core.Entities.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("Core.Entities.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("MaxResult")
                        .HasColumnType("real");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Show your knowledge in different topics! Good luck!",
                            MaxResult = 10f,
                            Title = "Multi-quiz"
                        });
                });

            modelBuilder.Entity("Core.Entities.UserAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ChosenOptionId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("UserTestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChosenOptionId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("UserTestId");

                    b.ToTable("UserAnswers");
                });

            modelBuilder.Entity("Core.Entities.UserTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AssignedToId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("LastAnsweredQuestionId")
                        .HasColumnType("int");

                    b.Property<float>("Result")
                        .HasColumnType("real");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<bool>("WasFinished")
                        .HasColumnType("bit");

                    b.Property<bool>("WasStarted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AssignedToId");

                    b.HasIndex("LastAnsweredQuestionId");

                    b.HasIndex("TestId");

                    b.ToTable("UserTests");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Core.Entities.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.HasDiscriminator().HasValue("User");

                    b.HasData(
                        new
                        {
                            Id = "566dba7d-bfbe-4454-a569-12778caaa6f8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2adb6640-8893-4f41-88fe-17a1073e2d13",
                            Email = "antonina.loboda@oa.edu.ua",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ANTONINA.LOBODA@OA.EDU.UA",
                            NormalizedUserName = "TON4IK",
                            PasswordHash = "AQAAAAEAACcQAAAAED6Yd/GqAEHfltcygZj4XjTFooZExM+0NSpZkhNbUNeOEQ81mrRQB78cISWxxpFwWw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3f71a2ff-34e8-4356-a9eb-712b9e51806a",
                            TwoFactorEnabled = false,
                            UserName = "ton4ik"
                        },
                        new
                        {
                            Id = "26e38e0d-93e1-4a2d-909c-b66073e69f12",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4fa34865-673c-45d1-b5f1-20136a3fc088",
                            Email = "Michele.Dickens@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "MICHELE.DICKENS@GMAIL.COM",
                            NormalizedUserName = "MICHELE35",
                            PasswordHash = "AQAAAAEAACcQAAAAEFlMCqp8YckJPBIJ0k+lIuGnDeQkHsljbtunRC7LfzGTTUrntMvqRwwrCKDZsvnO2g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f470d9b5-fd09-46d9-a719-d992d106fa97",
                            TwoFactorEnabled = false,
                            UserName = "Michele35"
                        },
                        new
                        {
                            Id = "7149e65d-0a01-4380-b98c-5c05ae7fa166",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bc638c5e-9349-40f2-b5a3-b3bb02beba8d",
                            Email = "Misty83@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "MISTY83@GMAIL.COM",
                            NormalizedUserName = "MISTY.SCHULTZ",
                            PasswordHash = "AQAAAAEAACcQAAAAELeZcXU4yX2zzezRc9EJdUuGYlWPQxUukffrb0i0KSm40Ue85l1B2NJ3LbDJehBLmw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b4cc9beb-65f2-4038-bc23-9a76df9e5381",
                            TwoFactorEnabled = false,
                            UserName = "Misty.Schultz"
                        },
                        new
                        {
                            Id = "ac1aa4b0-4639-4c21-b0b7-722620aac6eb",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8fa5ace3-b767-4ae4-a0ff-7e72604d3b86",
                            Email = "Yolanda_Kertzmann46@yahoo.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "YOLANDA_KERTZMANN46@YAHOO.COM",
                            NormalizedUserName = "YOLANDA75",
                            PasswordHash = "AQAAAAEAACcQAAAAEMnArUYERGJg9cICLConGIAZYtXPyP1iRbP+1FfAaBqZqd8wXjmClIpu7Q+CNwa5vA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b9418320-b525-425c-b1b7-63fe16655a18",
                            TwoFactorEnabled = false,
                            UserName = "Yolanda75"
                        },
                        new
                        {
                            Id = "8fe3caa3-619e-4362-884b-ade16ff042c1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "58234134-22c5-48cc-8eda-a40fb36b64c5",
                            Email = "Kent_Feest@yahoo.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "KENT_FEEST@YAHOO.COM",
                            NormalizedUserName = "KENT81",
                            PasswordHash = "AQAAAAEAACcQAAAAEPh68JUxAdmtjzjNIsTzxOU2wCGGpWU2H6cc8ZGEjQDwCInx9zTxyd4/vytLRVIFng==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "64e6e13c-9d5e-4049-a8ae-47b4bcbebe91",
                            TwoFactorEnabled = false,
                            UserName = "Kent81"
                        });
                });

            modelBuilder.Entity("Core.Entities.Option", b =>
                {
                    b.HasOne("Core.Entities.Question", "Question")
                        .WithMany("Options")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Core.Entities.Question", b =>
                {
                    b.HasOne("Core.Entities.Test", "Test")
                        .WithMany("Questions")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Test");
                });

            modelBuilder.Entity("Core.Entities.RefreshToken", b =>
                {
                    b.HasOne("Core.Entities.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Entities.UserAnswer", b =>
                {
                    b.HasOne("Core.Entities.Option", "ChosenOption")
                        .WithMany("UserAnswers")
                        .HasForeignKey("ChosenOptionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Core.Entities.Question", "Question")
                        .WithMany("UserAnswers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Core.Entities.UserTest", "UserTest")
                        .WithMany("UserAnswers")
                        .HasForeignKey("UserTestId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ChosenOption");

                    b.Navigation("Question");

                    b.Navigation("UserTest");
                });

            modelBuilder.Entity("Core.Entities.UserTest", b =>
                {
                    b.HasOne("Core.Entities.User", "AssignedTo")
                        .WithMany("UserTests")
                        .HasForeignKey("AssignedToId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Question", "LastAnsweredQuestion")
                        .WithMany("UserTests")
                        .HasForeignKey("LastAnsweredQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Test", "Test")
                        .WithMany("UserTests")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedTo");

                    b.Navigation("LastAnsweredQuestion");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Entities.Option", b =>
                {
                    b.Navigation("UserAnswers");
                });

            modelBuilder.Entity("Core.Entities.Question", b =>
                {
                    b.Navigation("Options");

                    b.Navigation("UserAnswers");

                    b.Navigation("UserTests");
                });

            modelBuilder.Entity("Core.Entities.Test", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("UserTests");
                });

            modelBuilder.Entity("Core.Entities.UserTest", b =>
                {
                    b.Navigation("UserAnswers");
                });

            modelBuilder.Entity("Core.Entities.User", b =>
                {
                    b.Navigation("RefreshTokens");

                    b.Navigation("UserTests");
                });
#pragma warning restore 612, 618
        }
    }
}