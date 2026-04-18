using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryBlazorApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Clients");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Clients",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "03e12965-b521-4052-894b-e5a7ef44b9d1", 0, "STATIC-CONCURRENCY-10", "client10@library.com", true, false, null, "CLIENT10@LIBRARY.COM", "CLIENT10@LIBRARY.COM", "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==", null, false, "STATIC-STAMP-10", false, "client10@library.com" },
                    { "241b6d78-2354-46b3-8ab8-63c68bbdf631", 0, "STATIC-CONCURRENCY-6", "client6@library.com", true, false, null, "CLIENT6@LIBRARY.COM", "CLIENT6@LIBRARY.COM", "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==", null, false, "STATIC-STAMP-6", false, "client6@library.com" },
                    { "39a1cce9-9123-4861-bf17-2909a7a1dff6", 0, "STATIC-CONCURRENCY-8", "client8@library.com", true, false, null, "CLIENT8@LIBRARY.COM", "CLIENT8@LIBRARY.COM", "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==", null, false, "STATIC-STAMP-8", false, "client8@library.com" },
                    { "3a21d428-508c-4a7a-b686-2724879c764a", 0, "STATIC-CONCURRENCY-7", "client7@library.com", true, false, null, "CLIENT7@LIBRARY.COM", "CLIENT7@LIBRARY.COM", "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==", null, false, "STATIC-STAMP-7", false, "client7@library.com" },
                    { "73af2f35-a9b2-40fa-9697-c1dee8166b26", 0, "STATIC-CONCURRENCY-3", "client3@library.com", true, false, null, "CLIENT3@LIBRARY.COM", "CLIENT3@LIBRARY.COM", "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==", null, false, "STATIC-STAMP-3", false, "client3@library.com" },
                    { "b5d8b1df-a9cf-4b2a-82ed-2e8538e1bda7", 0, "STATIC-CONCURRENCY-2", "client2@library.com", true, false, null, "CLIENT2@LIBRARY.COM", "CLIENT2@LIBRARY.COM", "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==", null, false, "STATIC-STAMP-2", false, "client2@library.com" },
                    { "be32eec5-8f03-4eaa-99d6-b2eebeebfce8", 0, "STATIC-CONCURRENCY-9", "client9@library.com", true, false, null, "CLIENT9@LIBRARY.COM", "CLIENT9@LIBRARY.COM", "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==", null, false, "STATIC-STAMP-9", false, "client9@library.com" },
                    { "c1e499f0-e54f-4dad-a579-d865ed8075ef", 0, "STATIC-CONCURRENCY-5", "client5@library.com", true, false, null, "CLIENT5@LIBRARY.COM", "CLIENT5@LIBRARY.COM", "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==", null, false, "STATIC-STAMP-5", false, "client5@library.com" },
                    { "c7277975-d866-4d1c-84b0-8d9df1ac7058", 0, "STATIC-CONCURRENCY-1", "client1@library.com", true, false, null, "CLIENT1@LIBRARY.COM", "CLIENT1@LIBRARY.COM", "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==", null, false, "STATIC-STAMP-1", false, "client1@library.com" },
                    { "ff49eb66-aefe-412d-8e5f-897f121f7f5d", 0, "STATIC-CONCURRENCY-4", "client4@library.com", true, false, null, "CLIENT4@LIBRARY.COM", "CLIENT4@LIBRARY.COM", "AQAAAAIAAYagAAAAEKD/HLWMXPpfstJQVV72WSuN0Y4ep3TYG/qS9EGGtqM6ldvU7oe3wbMVx9gkwuzOrA==", null, false, "STATIC-STAMP-4", false, "client4@library.com" }
                });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "IdentityUserId",
                value: "c7277975-d866-4d1c-84b0-8d9df1ac7058");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "IdentityUserId",
                value: "b5d8b1df-a9cf-4b2a-82ed-2e8538e1bda7");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "IdentityUserId",
                value: "73af2f35-a9b2-40fa-9697-c1dee8166b26");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "IdentityUserId",
                value: "ff49eb66-aefe-412d-8e5f-897f121f7f5d");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "IdentityUserId",
                value: "c1e499f0-e54f-4dad-a579-d865ed8075ef");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                column: "IdentityUserId",
                value: "241b6d78-2354-46b3-8ab8-63c68bbdf631");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                column: "IdentityUserId",
                value: "3a21d428-508c-4a7a-b686-2724879c764a");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                column: "IdentityUserId",
                value: "39a1cce9-9123-4861-bf17-2909a7a1dff6");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                column: "IdentityUserId",
                value: "be32eec5-8f03-4eaa-99d6-b2eebeebfce8");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                column: "IdentityUserId",
                value: "03e12965-b521-4052-894b-e5a7ef44b9d1");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_IdentityUserId",
                table: "Clients",
                column: "IdentityUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_AspNetUsers_IdentityUserId",
                table: "Clients",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_AspNetUsers_IdentityUserId",
                table: "Clients");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_Clients_IdentityUserId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Clients");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Clients",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Clients",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "PhoneNumber" },
                values: new object[] { "adam.nowicki@example.com", "500100200" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "PhoneNumber" },
                values: new object[] { "ewa.kaczmarek@example.com", "501200300" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "PhoneNumber" },
                values: new object[] { "piotr.mazur@example.com", "502300400" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "PhoneNumber" },
                values: new object[] { "karolina.dabrowska@example.com", "503400500" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "PhoneNumber" },
                values: new object[] { "michal.piotrowski@example.com", "504500600" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "PhoneNumber" },
                values: new object[] { "natalia.grabowska@example.com", "505600700" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "PhoneNumber" },
                values: new object[] { "krzysztof.pawlak@example.com", "506700800" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Email", "PhoneNumber" },
                values: new object[] { "magdalena.michalska@example.com", "507800900" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Email", "PhoneNumber" },
                values: new object[] { "pawel.krol@example.com", "508900100" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Email", "PhoneNumber" },
                values: new object[] { "agnieszka.wieczorek@example.com", "509100200" });
        }
    }
}
