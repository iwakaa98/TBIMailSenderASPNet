﻿// <auto-generated />
using System;
using EmailManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmailManager.Data.Migrations
{
    [DbContext(typeof(EmailManagerDbContext))]
    partial class EmailManagerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("EncryptedEGN")
                        .IsRequired();

                    b.Property<string>("EncryptedEmail")
                        .IsRequired();

                    b.Property<string>("EncryptedPhone")
                        .IsRequired();

                    b.Property<string>("Names")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ClientDatas");
                });

            modelBuilder.Entity("EmailManager.Data.Entities.Email", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body")
                        .IsRequired();

                    b.Property<DateTime>("DateReceived");

                    b.Property<string>("Sender")
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

                    b.Property<string>("ClientDataId");

                    b.Property<string>("EmailId");

                    b.Property<string>("StatusApplicationId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ClientDataId");

                    b.HasIndex("EmailId")
                        .IsUnique()
                        .HasFilter("[EmailId] IS NOT NULL");

                    b.HasIndex("StatusApplicationId");

                    b.HasIndex("UserId");

                    b.ToTable("LoanApplications");
                });

            modelBuilder.Entity("EmailManager.Data.Entities.StatusApplication", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StatusType")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("StatusApplications");
                });

            modelBuilder.Entity("EmailManager.Data.Entities.StatusEmail", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StatusType")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("StatusEmails");
                });

            modelBuilder.Entity("EmailManager.Data.Entities.User", b =>
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

                    b.HasData(
                        new
                        {
                            Id = "fe86f129-41f3-4ab8-a61c-5f47239a1393",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "28cee90e-9b97-4360-b572-ab8827192a4e",
                            Email = "krisi@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "KRISI@GMAIL.COM",
                            NormalizedUserName = "KRISI",
                            PasswordHash = "AQAAAAEAACcQAAAAEBNHgO9c2xVa+5txp+6KI2kzNldtZBb3DZsbL3Nd9Um1EUQwGpM2WIO0d5AtRJ0Ebw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7I5VNHIJTSZNOT3KDWKNFUV5PVYBHGXN",
                            TwoFactorEnabled = false,
                            UserName = "krisi"
                        },
                        new
                        {
                            Id = "565dfbc0-2681-4f29-bc97-a619eacf339c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "09ea5ac3-72f8-4fba-8e8a-448f729b8f78",
                            Email = "madinftw@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "MADINFTW@GMAIL.COM",
                            NormalizedUserName = "MADINFTW",
                            PasswordHash = "AQAAAAEAACcQAAAAEP6m44O4UPI+Y5hCLgywR18PIlm0EYwEKfFaL/kx6DAGvRBvA4H0pw5CsAvs+jwCHg==",
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
                            ConcurrencyStamp = "50718c01-454f-4eab-8cf4-d0a810a2f9fb",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "93c66dd9-11c5-4836-b104-a9c333549530",
                            ConcurrencyStamp = "0d26d4be-7b9f-4ebd-b5d0-b39aca131df5",
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

            modelBuilder.Entity("EmailManager.Data.Entities.Email", b =>
                {
                    b.HasOne("EmailManager.Data.Entities.StatusEmail", "StatusEmail")
                        .WithMany("Emails")
                        .HasForeignKey("StatusEmailId");

                    b.HasOne("EmailManager.Data.Entities.User", "User")
                        .WithMany("Emails")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("EmailManager.Data.Entities.EmailAttachments", b =>
                {
                    b.HasOne("EmailManager.Data.Entities.Email", "Email")
                        .WithMany("EmailAttachments")
                        .HasForeignKey("EmailId");
                });

            modelBuilder.Entity("EmailManager.Data.Entities.LoanApplication", b =>
                {
                    b.HasOne("EmailManager.Data.Entities.ClientData", "ClientData")
                        .WithMany("LoanApplications")
                        .HasForeignKey("ClientDataId");

                    b.HasOne("EmailManager.Data.Entities.Email", "Email")
                        .WithOne("LoanApplication")
                        .HasForeignKey("EmailManager.Data.Entities.LoanApplication", "EmailId");

                    b.HasOne("EmailManager.Data.Entities.StatusApplication", "StatusApplication")
                        .WithMany("LoanApplications")
                        .HasForeignKey("StatusApplicationId");

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
