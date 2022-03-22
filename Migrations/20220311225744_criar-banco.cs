using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EtecTube.Migrations
{
    public partial class criarbanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FullName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nickname = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserNameChangeLimit = table.Column<int>(type: "int", nullable: false),
                    ProfilePicture = table.Column<byte[]>(type: "longblob", nullable: true),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Channel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ChannelPicture = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Channel_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ChannelId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(8000)", maxLength: 8000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PublishedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Thumbnail = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Likes = table.Column<uint>(type: "int unsigned", nullable: false),
                    Dislikes = table.Column<uint>(type: "int unsigned", nullable: false),
                    Visualizations = table.Column<uint>(type: "int unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Video_Channel_ChannelId",
                        column: x => x.ChannelId,
                        principalTable: "Channel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "867115ff-bb58-48d9-be34-8f49fb0a0bd9", "fc3f17f8-5558-4a22-9c8d-07dd1e2cfbaf", "Administrador", "ADMINISTRADOR" },
                    { "fe38e0e5-9c67-4114-b966-fdc030bb260b", "295d0ae8-7711-4106-89bd-2a73a5f8c098", "Moderador", "MODERADOR" },
                    { "41b31a10-6d7f-4da7-9e0f-80e2830a20a7", "3ba2d193-b6bf-4277-b7aa-e27fa3ee11b8", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "Nickname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserNameChangeLimit" },
                values: new object[] { "867115ff-bb58-48d9-be34-8f49fb0a0bd9", 0, "0cdaae80-4e65-48f7-8db8-37772728178a", "admin@etectube.com.br", true, "José Antonio Gallo Junior", false, null, "Gallo", "ADMIN@ETECTUBE.COM.BR", "ADMIN", "AQAAAAEAACcQAAAAEF1ZnOBtdoVUAXevziex2obikroWIonz6IMIku0wbAjEBqml2rHCC8Kv8tM3gpiq3w==", null, false, null, "49282936", false, "Admin", 10 });

            migrationBuilder.InsertData(
                table: "Channel",
                columns: new[] { "Id", "ChannelPicture", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("2522fb4c-e86d-4e9e-9d8d-517b873955ea"), "~/img/Channels/piologo.jpg", "Irmãos Piologo", "867115ff-bb58-48d9-be34-8f49fb0a0bd9" },
                    { new Guid("d3cf2935-e635-4e4c-aa87-85656cf70df5"), "~/img/Channels/melodicka.jpg", "Melodicka Bros", "867115ff-bb58-48d9-be34-8f49fb0a0bd9" },
                    { new Guid("bca91396-c13f-4040-a373-fa667615c60a"), "~/img/Channels/frogleapstudios.jpg", "Frog Leap Studios", "867115ff-bb58-48d9-be34-8f49fb0a0bd9" },
                    { new Guid("7607b21a-663b-40ad-8c3a-5beab7a58d5c"), "~/img/Channels/99coders.jpg", "99 Coders", "867115ff-bb58-48d9-be34-8f49fb0a0bd9" },
                    { new Guid("550fd41d-a306-4a59-9b64-db31e9f27a9e"), "~/img/Channels/balta.jpg", "Balta.IO", "867115ff-bb58-48d9-be34-8f49fb0a0bd9" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "867115ff-bb58-48d9-be34-8f49fb0a0bd9", "867115ff-bb58-48d9-be34-8f49fb0a0bd9" });

            migrationBuilder.InsertData(
                table: "Video",
                columns: new[] { "Id", "ChannelId", "Description", "Dislikes", "Likes", "Name", "PublishedDate", "Thumbnail", "Visualizations" },
                values: new object[,]
                {
                    { new Guid("badf9f67-368d-46ba-915c-833a652e7b5e"), new Guid("2522fb4c-e86d-4e9e-9d8d-517b873955ea"), "VALE A PENA VER DE NOVO! Com mais de 17 milhões de views desde sua criação em 2004, este clássico da internet brasileira aparece pela primeira vez em FULL HD. É bom relembrar esse clássico, pois nesse ano de comemoração de 10 anos, vai rolar também a esperada Avaiana de Pau 2!!! Fiquem ligados!", 0u, 79000u, "Avaiana de Pau Edição de 10 anos em FULL HD!", new DateTime(2014, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/img/Videos/avaiana_pau.png", 2354441u },
                    { new Guid("01ed57c3-a44a-4a4b-a673-50380be4bac3"), new Guid("2522fb4c-e86d-4e9e-9d8d-517b873955ea"), "Chegou a novidade que as Menines esperavam, a Avaiane de Plume, porem será que ela é tão eficaz quanto a original de Pau?", 0u, 65000u, "Avaiane de Plume - A Avaiane dos Mimimi", new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/img/Videos/avaiana_plume.png", 498251u },
                    { new Guid("c723ea21-45c8-45f6-98b6-6de74e1a5692"), new Guid("d3cf2935-e635-4e4c-aa87-85656cf70df5"), "Let's start the year with an acoustic cover of the new song Zombified by @Falling In Reverse.", 0u, 2300u, "Falling In Reverse - ZOMBIFIED (Acoustic Cover)", new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/img/Videos/falling_reverse.png", 25759u },
                    { new Guid("b514093d-4cbb-414a-a167-bb09175f40ae"), new Guid("d3cf2935-e635-4e4c-aa87-85656cf70df5"), "What if John Denver came from a different universe to bring us some electro cyberpunk industrial synthwave sci-fi futuristic metal vibes?", 0u, 85000u, "Country Roads but it's CYBERPUNK/INDUSTRIAL/SCI-FI wtf", new DateTime(2019, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/img/Videos/country_roads.png", 1284517u },
                    { new Guid("3d782f58-95f2-46e8-a0fa-6aca689d24a6"), new Guid("bca91396-c13f-4040-a373-fa667615c60a"), "Hi there, my name is Leo and run a studio on the westside of Norway where I do music and video stuff for youtube. I also have a band called Frog Leap, where we do my metal covers live. For my covers I play everything myself as well as record, mix, master, shoot and edit the music & videos.", 0u, 101000u, "What Is Love (metal cover by Leo Moracchioli feat. Priscila Serrano)", new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/img/Videos/what_is_love.png", 2810254u },
                    { new Guid("56aa6d87-51fd-4d9b-ad7f-bd3ccc1762ed"), new Guid("bca91396-c13f-4040-a373-fa667615c60a"), "Hi there, my name is Leo and run a studio on the westside of Norway where I do music and video stuff for youtube. I also have a band called Frog Leap, where we do my metal covers live. For my covers I play everything myself as well as record, mix, master, shoot and edit the music & videos.", 0u, 102000u, "Carry On Wayward Son (metal cover by Leo Moracchioli feat. Truls Haugen)", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/img/Videos/carry_on_wayward_son.png", 4725330u },
                    { new Guid("98bcff49-6b35-4bee-b942-79e522305038"), new Guid("7607b21a-663b-40ad-8c3a-5beab7a58d5c"), "O que acha de criarmos uma aplicação completa juntos passo a passo? É um app para compras em supermercado. Acompanhe a série de vídeos.", 0u, 186u, "Criando um app para compras de supermercado #07 - Finalizando o layout do app", new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/img/Videos/app_delphi.png", 1013u },
                    { new Guid("304b4f5e-2015-429e-890a-8fc3dfed13a7"), new Guid("550fd41d-a306-4a59-9b64-db31e9f27a9e"), "String, string ou StringBuilder? Para que servem e quando devemos utilizar cada um destes tipos no C#!", 0u, 257u, "var, string, System.String e StringBuilder no C# | por André Baltieri #balta", new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/img/Videos/balta_string.png", 1726u },
                    { new Guid("deb7aac9-cefb-4204-bc94-a4445f652753"), new Guid("550fd41d-a306-4a59-9b64-db31e9f27a9e"), "Participe do balta.io Experience, um evento online, ao vivo e gratuito que vai reunir grandes nomes da internet em uma experiência única! https://balta.io/experience", 0u, 1000u, "C# 10 e .NET 6 - Novidades na manipulação de listas | por André Baltieri #balta", new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/img/Videos/balta_c10.png", 8473u }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Channel_UserId",
                table: "Channel",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Role",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "User",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Video_ChannelId",
                table: "Video",
                column: "ChannelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Channel");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
