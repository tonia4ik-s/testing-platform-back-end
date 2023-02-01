﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChosenOptionId = 3,
                            QuestionId = 1,
                            UserTestId = 3
                        },
                        new
                        {
                            Id = 2,
                            ChosenOptionId = 7,
                            QuestionId = 2,
                            UserTestId = 3
                        },
                        new
                        {
                            Id = 3,
                            ChosenOptionId = 9,
                            QuestionId = 3,
                            UserTestId = 3
                        },
                        new
                        {
                            Id = 4,
                            ChosenOptionId = 14,
                            QuestionId = 4,
                            UserTestId = 3
                        },
                        new
                        {
                            Id = 5,
                            ChosenOptionId = 18,
                            QuestionId = 5,
                            UserTestId = 3
                        });
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

                    b.Property<bool>("IsFinished")
                        .HasColumnType("bit");

                    b.Property<float>("Result")
                        .HasColumnType("real");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssignedToId");

                    b.HasIndex("TestId");

                    b.ToTable("UserTests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AssignedToId = "4eb7773d-1a2e-4396-8f58-3a8d9863680c",
                            IsFinished = false,
                            Result = 0f,
                            TestId = 1
                        },
                        new
                        {
                            Id = 2,
                            AssignedToId = "0c0f1b1b-71eb-4c29-96c0-95f505dcccae",
                            IsFinished = false,
                            Result = 0f,
                            TestId = 1
                        },
                        new
                        {
                            Id = 3,
                            AssignedToId = "3b4844c9-f3a9-46ae-b86e-cd155973a268",
                            IsFinished = true,
                            Result = 10f,
                            TestId = 1
                        });
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
                            Id = "3b4844c9-f3a9-46ae-b86e-cd155973a268",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5ffd1706-b79c-4da6-9f08-e6e0051540be",
                            Email = "antonina.loboda@oa.edu.ua",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ANTONINA.LOBODA@OA.EDU.UA",
                            NormalizedUserName = "TON4IK",
                            PasswordHash = "AQAAAAEAACcQAAAAEGE3eEVGae4v5jVReahq87u7v5zNKbPEP3xMpwPcApOuo0v9s4VrxbX6Jjhos75Lfg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2cc900fa-7ebf-4f20-90d0-0ec467f63d8e",
                            TwoFactorEnabled = false,
                            UserName = "ton4ik"
                        },
                        new
                        {
                            Id = "4eb7773d-1a2e-4396-8f58-3a8d9863680c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "60fafa9b-1a4e-4456-85c2-e03e2bac9670",
                            Email = "Lorena83@hotmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "LORENA83@HOTMAIL.COM",
                            NormalizedUserName = "LORENA.WEST10",
                            PasswordHash = "AQAAAAEAACcQAAAAEKyaq543ecMWvFZpMJx9gwk0xnHqYD8tere237jhZX/agi3Yk06b7jM7icDwc3Xwzw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e1b19fbd-68e1-4515-8339-3e8ab715cfd5",
                            TwoFactorEnabled = false,
                            UserName = "Lorena.West10"
                        },
                        new
                        {
                            Id = "0c0f1b1b-71eb-4c29-96c0-95f505dcccae",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a9e90f94-706e-4884-8de2-2880a8ab13c8",
                            Email = "Angelina.Little14@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ANGELINA.LITTLE14@GMAIL.COM",
                            NormalizedUserName = "ANGELINA.LITTLE30",
                            PasswordHash = "AQAAAAEAACcQAAAAENI57xQD5mh1eqp16SDikuPlaGIpEdrUpEnA5TMBVQ1ocrJzTxibGD/K/NoKrrG7QQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ad2ddd29-4a83-4758-97b1-afaa3a210a4d",
                            TwoFactorEnabled = false,
                            UserName = "Angelina.Little30"
                        },
                        new
                        {
                            Id = "5fd37a12-9c1a-49b9-bbd9-57e942ac60a3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3d4b108c-65b6-48b8-96d5-44f84d7aaf4c",
                            Email = "Elisa_Huels@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ELISA_HUELS@GMAIL.COM",
                            NormalizedUserName = "ELISA16",
                            PasswordHash = "AQAAAAEAACcQAAAAEM+IL5R4UjTEvUBqxOBZTC42c2GxiDCuuSKIH96ctHNU4vcaY1JcsDkkDgg0s/Pikw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a6c0dbff-33b6-4499-b1f2-645218a420ee",
                            TwoFactorEnabled = false,
                            UserName = "Elisa16"
                        },
                        new
                        {
                            Id = "1ece2684-279e-48aa-bcf8-1eaef268cfc8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c911dd62-4b14-4a04-9002-41bd0ed31a96",
                            Email = "Kate45@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "KATE45@GMAIL.COM",
                            NormalizedUserName = "KATE.PROSACCO15",
                            PasswordHash = "AQAAAAEAACcQAAAAEMjuJBYQgw+VsHBW8JGR+K84qbhL1+hqIyCMEQCYSopYoo4FL+cBIkg3aCkkNB7IWQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d7a6a45c-db27-46f8-a9eb-c6e07d7f0b5f",
                            TwoFactorEnabled = false,
                            UserName = "Kate.Prosacco15"
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

                    b.HasOne("Core.Entities.Test", "Test")
                        .WithMany("UserTests")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedTo");

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
