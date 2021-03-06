// <auto-generated />
using System;
using EtecTube.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EtecTube.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220311225744_criar-banco")]
    partial class criarbanco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("EtecTube.Models.Channel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ChannelPicture")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Channel");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2522fb4c-e86d-4e9e-9d8d-517b873955ea"),
                            ChannelPicture = "~/img/Channels/piologo.jpg",
                            Name = "Irmãos Piologo",
                            UserId = "867115ff-bb58-48d9-be34-8f49fb0a0bd9"
                        },
                        new
                        {
                            Id = new Guid("d3cf2935-e635-4e4c-aa87-85656cf70df5"),
                            ChannelPicture = "~/img/Channels/melodicka.jpg",
                            Name = "Melodicka Bros",
                            UserId = "867115ff-bb58-48d9-be34-8f49fb0a0bd9"
                        },
                        new
                        {
                            Id = new Guid("bca91396-c13f-4040-a373-fa667615c60a"),
                            ChannelPicture = "~/img/Channels/frogleapstudios.jpg",
                            Name = "Frog Leap Studios",
                            UserId = "867115ff-bb58-48d9-be34-8f49fb0a0bd9"
                        },
                        new
                        {
                            Id = new Guid("7607b21a-663b-40ad-8c3a-5beab7a58d5c"),
                            ChannelPicture = "~/img/Channels/99coders.jpg",
                            Name = "99 Coders",
                            UserId = "867115ff-bb58-48d9-be34-8f49fb0a0bd9"
                        },
                        new
                        {
                            Id = new Guid("550fd41d-a306-4a59-9b64-db31e9f27a9e"),
                            ChannelPicture = "~/img/Channels/balta.jpg",
                            Name = "Balta.IO",
                            UserId = "867115ff-bb58-48d9-be34-8f49fb0a0bd9"
                        });
                });

            modelBuilder.Entity("EtecTube.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FullName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nickname")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("longblob");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<int>("UserNameChangeLimit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = "867115ff-bb58-48d9-be34-8f49fb0a0bd9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0cdaae80-4e65-48f7-8db8-37772728178a",
                            Email = "admin@etectube.com.br",
                            EmailConfirmed = true,
                            FullName = "José Antonio Gallo Junior",
                            LockoutEnabled = false,
                            Nickname = "Gallo",
                            NormalizedEmail = "ADMIN@ETECTUBE.COM.BR",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEF1ZnOBtdoVUAXevziex2obikroWIonz6IMIku0wbAjEBqml2rHCC8Kv8tM3gpiq3w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "49282936",
                            TwoFactorEnabled = false,
                            UserName = "Admin",
                            UserNameChangeLimit = 10
                        });
                });

            modelBuilder.Entity("EtecTube.Models.Video", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ChannelId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasMaxLength(8000)
                        .HasColumnType("varchar(8000)");

                    b.Property<uint>("Dislikes")
                        .HasColumnType("int unsigned");

                    b.Property<uint>("Likes")
                        .HasColumnType("int unsigned");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Thumbnail")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<uint>("Visualizations")
                        .HasColumnType("int unsigned");

                    b.HasKey("Id");

                    b.HasIndex("ChannelId");

                    b.ToTable("Video");

                    b.HasData(
                        new
                        {
                            Id = new Guid("badf9f67-368d-46ba-915c-833a652e7b5e"),
                            ChannelId = new Guid("2522fb4c-e86d-4e9e-9d8d-517b873955ea"),
                            Description = "VALE A PENA VER DE NOVO! Com mais de 17 milhões de views desde sua criação em 2004, este clássico da internet brasileira aparece pela primeira vez em FULL HD. É bom relembrar esse clássico, pois nesse ano de comemoração de 10 anos, vai rolar também a esperada Avaiana de Pau 2!!! Fiquem ligados!",
                            Dislikes = 0u,
                            Likes = 79000u,
                            Name = "Avaiana de Pau Edição de 10 anos em FULL HD!",
                            PublishedDate = new DateTime(2014, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "~/img/Videos/avaiana_pau.png",
                            Visualizations = 2354441u
                        },
                        new
                        {
                            Id = new Guid("01ed57c3-a44a-4a4b-a673-50380be4bac3"),
                            ChannelId = new Guid("2522fb4c-e86d-4e9e-9d8d-517b873955ea"),
                            Description = "Chegou a novidade que as Menines esperavam, a Avaiane de Plume, porem será que ela é tão eficaz quanto a original de Pau?",
                            Dislikes = 0u,
                            Likes = 65000u,
                            Name = "Avaiane de Plume - A Avaiane dos Mimimi",
                            PublishedDate = new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "~/img/Videos/avaiana_plume.png",
                            Visualizations = 498251u
                        },
                        new
                        {
                            Id = new Guid("c723ea21-45c8-45f6-98b6-6de74e1a5692"),
                            ChannelId = new Guid("d3cf2935-e635-4e4c-aa87-85656cf70df5"),
                            Description = "Let's start the year with an acoustic cover of the new song Zombified by @Falling In Reverse.",
                            Dislikes = 0u,
                            Likes = 2300u,
                            Name = "Falling In Reverse - ZOMBIFIED (Acoustic Cover)",
                            PublishedDate = new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "~/img/Videos/falling_reverse.png",
                            Visualizations = 25759u
                        },
                        new
                        {
                            Id = new Guid("b514093d-4cbb-414a-a167-bb09175f40ae"),
                            ChannelId = new Guid("d3cf2935-e635-4e4c-aa87-85656cf70df5"),
                            Description = "What if John Denver came from a different universe to bring us some electro cyberpunk industrial synthwave sci-fi futuristic metal vibes?",
                            Dislikes = 0u,
                            Likes = 85000u,
                            Name = "Country Roads but it's CYBERPUNK/INDUSTRIAL/SCI-FI wtf",
                            PublishedDate = new DateTime(2019, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "~/img/Videos/country_roads.png",
                            Visualizations = 1284517u
                        },
                        new
                        {
                            Id = new Guid("3d782f58-95f2-46e8-a0fa-6aca689d24a6"),
                            ChannelId = new Guid("bca91396-c13f-4040-a373-fa667615c60a"),
                            Description = "Hi there, my name is Leo and run a studio on the westside of Norway where I do music and video stuff for youtube. I also have a band called Frog Leap, where we do my metal covers live. For my covers I play everything myself as well as record, mix, master, shoot and edit the music & videos.",
                            Dislikes = 0u,
                            Likes = 101000u,
                            Name = "What Is Love (metal cover by Leo Moracchioli feat. Priscila Serrano)",
                            PublishedDate = new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "~/img/Videos/what_is_love.png",
                            Visualizations = 2810254u
                        },
                        new
                        {
                            Id = new Guid("56aa6d87-51fd-4d9b-ad7f-bd3ccc1762ed"),
                            ChannelId = new Guid("bca91396-c13f-4040-a373-fa667615c60a"),
                            Description = "Hi there, my name is Leo and run a studio on the westside of Norway where I do music and video stuff for youtube. I also have a band called Frog Leap, where we do my metal covers live. For my covers I play everything myself as well as record, mix, master, shoot and edit the music & videos.",
                            Dislikes = 0u,
                            Likes = 102000u,
                            Name = "Carry On Wayward Son (metal cover by Leo Moracchioli feat. Truls Haugen)",
                            PublishedDate = new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "~/img/Videos/carry_on_wayward_son.png",
                            Visualizations = 4725330u
                        },
                        new
                        {
                            Id = new Guid("98bcff49-6b35-4bee-b942-79e522305038"),
                            ChannelId = new Guid("7607b21a-663b-40ad-8c3a-5beab7a58d5c"),
                            Description = "O que acha de criarmos uma aplicação completa juntos passo a passo? É um app para compras em supermercado. Acompanhe a série de vídeos.",
                            Dislikes = 0u,
                            Likes = 186u,
                            Name = "Criando um app para compras de supermercado #07 - Finalizando o layout do app",
                            PublishedDate = new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "~/img/Videos/app_delphi.png",
                            Visualizations = 1013u
                        },
                        new
                        {
                            Id = new Guid("304b4f5e-2015-429e-890a-8fc3dfed13a7"),
                            ChannelId = new Guid("550fd41d-a306-4a59-9b64-db31e9f27a9e"),
                            Description = "String, string ou StringBuilder? Para que servem e quando devemos utilizar cada um destes tipos no C#!",
                            Dislikes = 0u,
                            Likes = 257u,
                            Name = "var, string, System.String e StringBuilder no C# | por André Baltieri #balta",
                            PublishedDate = new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "~/img/Videos/balta_string.png",
                            Visualizations = 1726u
                        },
                        new
                        {
                            Id = new Guid("deb7aac9-cefb-4204-bc94-a4445f652753"),
                            ChannelId = new Guid("550fd41d-a306-4a59-9b64-db31e9f27a9e"),
                            Description = "Participe do balta.io Experience, um evento online, ao vivo e gratuito que vai reunir grandes nomes da internet em uma experiência única! https://balta.io/experience",
                            Dislikes = 0u,
                            Likes = 1000u,
                            Name = "C# 10 e .NET 6 - Novidades na manipulação de listas | por André Baltieri #balta",
                            PublishedDate = new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "~/img/Videos/balta_c10.png",
                            Visualizations = 8473u
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = "867115ff-bb58-48d9-be34-8f49fb0a0bd9",
                            ConcurrencyStamp = "fc3f17f8-5558-4a22-9c8d-07dd1e2cfbaf",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "fe38e0e5-9c67-4114-b966-fdc030bb260b",
                            ConcurrencyStamp = "295d0ae8-7711-4106-89bd-2a73a5f8c098",
                            Name = "Moderador",
                            NormalizedName = "MODERADOR"
                        },
                        new
                        {
                            Id = "41b31a10-6d7f-4da7-9e0f-80e2830a20a7",
                            ConcurrencyStamp = "3ba2d193-b6bf-4277-b7aa-e27fa3ee11b8",
                            Name = "Usuario",
                            NormalizedName = "USUARIO"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "867115ff-bb58-48d9-be34-8f49fb0a0bd9",
                            RoleId = "867115ff-bb58-48d9-be34-8f49fb0a0bd9"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("EtecTube.Models.Channel", b =>
                {
                    b.HasOne("EtecTube.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EtecTube.Models.Video", b =>
                {
                    b.HasOne("EtecTube.Models.Channel", "Channel")
                        .WithMany()
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Channel");
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
                    b.HasOne("EtecTube.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EtecTube.Models.User", null)
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

                    b.HasOne("EtecTube.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EtecTube.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
