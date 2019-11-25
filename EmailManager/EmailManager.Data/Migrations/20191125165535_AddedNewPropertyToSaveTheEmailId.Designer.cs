﻿// <auto-generated />
using System;
using EmailManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmailManager.Data.Migrations
{
    [DbContext(typeof(EmailManagerDbContext))]
    [Migration("20191125165535_AddedNewPropertyToSaveTheEmailId")]
    partial class AddedNewPropertyToSaveTheEmailId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmailManager.Data.Entities.ClientData", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedByUserId");

                    b.Property<DateTime?>("CreatedOnDate");

                    b.Property<string>("DeletedByUserId");

                    b.Property<DateTime?>("DeletedOnDate");

                    b.Property<string>("EGN")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName");

                    b.Property<string>("ModifiedByUserId");

                    b.Property<DateTime?>("ModifiedOnDate");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ClientDatas");
                });

            modelBuilder.Entity("EmailManager.Data.Entities.ClientEmail", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<DateTime>("DateReceived");

                    b.Property<string>("ModifiedByUserId");

                    b.Property<DateTime?>("ModifiedOnDate");

                    b.Property<string>("OriginalMailId")
                        .IsRequired();

                    b.Property<string>("SenderEmail")
                        .IsRequired();

                    b.Property<string>("SenderName")
                        .IsRequired();

                    b.Property<string>("StatusEmailId");

                    b.Property<string>("Subject")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("StatusEmailId");

                    b.HasIndex("UserId");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("EmailManager.Data.Entities.EmailAttachments", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DeletedByUserId");

                    b.Property<DateTime?>("DeletedOnDate");

                    b.Property<string>("EmailId");

                    b.Property<string>("FileName")
                        .IsRequired();

                    b.Property<double>("FileSize");

                    b.HasKey("Id");

                    b.HasIndex("EmailId");

                    b.ToTable("EmailAttachments");
                });

            modelBuilder.Entity("EmailManager.Data.Entities.LoanApplication", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric(15,2)");

                    b.Property<string>("ApplicationStatus")
                        .IsRequired();

                    b.Property<string>("ChangedCloseToNewStatusForEmailId");

                    b.Property<string>("ClientDataId");

                    b.Property<string>("CreatedByUserId");

                    b.Property<DateTime?>("CreatedOnDate");

                    b.Property<string>("DeletedByUserId");

                    b.Property<DateTime?>("DeletedOnDate");

                    b.Property<string>("EmailId");

                    b.Property<string>("ModifiedByUserId");

                    b.Property<DateTime?>("ModifiedOnDate");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ClientDataId");

                    b.HasIndex("EmailId")
                        .IsUnique()
                        .HasFilter("[EmailId] IS NOT NULL");

                    b.HasIndex("UserId");

                    b.ToTable("LoanApplications");
                });

            modelBuilder.Entity("EmailManager.Data.Entities.StatusEmail", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StatusType")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("StatusEmails");

                    b.HasData(
                        new
                        {
                            Id = "a0e53404-d40e-4a1e-8fe5-9a5fc0139ed9",
                            StatusType = "Not Reviewed"
                        },
                        new
                        {
                            Id = "165e4e23-7fed-4bd6-a859-530026625ffc",
                            StatusType = "Invalid Application"
                        },
                        new
                        {
                            Id = "45d30b68-d0c1-499b-9ed0-c7385d4119b8",
                            StatusType = "New Application"
                        },
                        new
                        {
                            Id = "645ad030-3b7f-47fb-93e1-1c9315b34673",
                            StatusType = "Open Application"
                        },
                        new
                        {
                            Id = "6c60cb0a-5395-49b1-abfd-40a4db7a355a",
                            StatusType = "Closed Application"
                        });
                });

            modelBuilder.Entity("EmailManager.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<bool>("ChangedPassword");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("DeletedByUserId");

                    b.Property<DateTime?>("DeletedOnDate");

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

                    b.HasData(
                        new
                        {
                            Id = "fe86f129-41f3-4ab8-a61c-5f47239a1393",
                            AccessFailedCount = 0,
                            ChangedPassword = true,
                            ConcurrencyStamp = "e7133e5b-df25-4e41-b71c-1f4dc258bc88",
                            Email = "krisi@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "KRISI@GMAIL.COM",
                            NormalizedUserName = "KRISI",
                            PasswordHash = "AQAAAAEAACcQAAAAEMzyrSqwNNQpzENjeQppJe8xADgje0msImG1jKCJdfAIfRcNZ7N2mvR5rJQtBsNc7w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7I5VNHIJTSZNOT3KDWKNFUV5PVYBHGXN",
                            TwoFactorEnabled = false,
                            UserName = "krisi"
                        },
                        new
                        {
                            Id = "565dfbc0-2681-4f29-bc97-a619eacf339c",
                            AccessFailedCount = 0,
                            ChangedPassword = true,
                            ConcurrencyStamp = "3435e608-00f6-4940-8ee3-6108da462228",
                            Email = "madinftw@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "MADINFTW@GMAIL.COM",
                            NormalizedUserName = "MADINFTW",
                            PasswordHash = "AQAAAAEAACcQAAAAEJ4vQc4uYZxWu8sHL/wFYENTOzu9xlmPHB7Hk2ofqVh7VTAoVHM6VDG7JflK18wpmw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "15CLJEKQCTLPRXMVXXNSWXZH6R6KJRRU",
                            TwoFactorEnabled = false,
                            UserName = "madinftw"
                        });
                });

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

                    b.HasData(
                        new
                        {
                            Id = "771f568e-a7d5-496b-90c4-72ff997368e6",
                            ConcurrencyStamp = "cfa5727d-a365-455a-b486-cd50e5b32a5f",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "93c66dd9-11c5-4836-b104-a9c333549530",
                            ConcurrencyStamp = "df0a6900-7a7c-4eaf-8d9e-6e8207810937",
                            Name = "Operator",
                            NormalizedName = "OPERATOR"
                        });
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

                    b.HasData(
                        new
                        {
                            UserId = "fe86f129-41f3-4ab8-a61c-5f47239a1393",
                            RoleId = "771f568e-a7d5-496b-90c4-72ff997368e6"
                        },
                        new
                        {
                            UserId = "565dfbc0-2681-4f29-bc97-a619eacf339c",
                            RoleId = "771f568e-a7d5-496b-90c4-72ff997368e6"
                        });
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

            modelBuilder.Entity("EmailManager.Data.Entities.ClientEmail", b =>
                {
                    b.HasOne("EmailManager.Data.Entities.StatusEmail", "Status")
                        .WithMany("Emails")
                        .HasForeignKey("StatusEmailId");

                    b.HasOne("EmailManager.Data.Entities.User", "User")
                        .WithMany("Emails")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("EmailManager.Data.Entities.EmailAttachments", b =>
                {
                    b.HasOne("EmailManager.Data.Entities.ClientEmail", "Email")
                        .WithMany("EmailAttachments")
                        .HasForeignKey("EmailId");
                });

            modelBuilder.Entity("EmailManager.Data.Entities.LoanApplication", b =>
                {
                    b.HasOne("EmailManager.Data.Entities.ClientData", "ClientData")
                        .WithMany("LoanApplications")
                        .HasForeignKey("ClientDataId");

                    b.HasOne("EmailManager.Data.Entities.ClientEmail", "Email")
                        .WithOne("LoanApplication")
                        .HasForeignKey("EmailManager.Data.Entities.LoanApplication", "EmailId");

                    b.HasOne("EmailManager.Data.Entities.User", "User")
                        .WithMany("LoanApplications")
                        .HasForeignKey("UserId");
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
                    b.HasOne("EmailManager.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EmailManager.Data.Entities.User")
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

                    b.HasOne("EmailManager.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EmailManager.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
