using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryBlazorApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "068120C4-B482-4D33-B59B-F8912CF44246", "86729487-68B0-4A6A-9717-4828FB497621", "Admin", "ADMIN" },
                    { "31BEC81A-71F6-4799-90A6-3A82D9888E95", "6884FB5C-A3FD-4ACD-95F6-89247943436E", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "31BEC81A-71F6-4799-90A6-3A82D9888E95", "03e12965-b521-4052-894b-e5a7ef44b9d1" },
                    { "31BEC81A-71F6-4799-90A6-3A82D9888E95", "241b6d78-2354-46b3-8ab8-63c68bbdf631" },
                    { "31BEC81A-71F6-4799-90A6-3A82D9888E95", "39a1cce9-9123-4861-bf17-2909a7a1dff6" },
                    { "31BEC81A-71F6-4799-90A6-3A82D9888E95", "3a21d428-508c-4a7a-b686-2724879c764a" },
                    { "31BEC81A-71F6-4799-90A6-3A82D9888E95", "73af2f35-a9b2-40fa-9697-c1dee8166b26" },
                    { "31BEC81A-71F6-4799-90A6-3A82D9888E95", "b5d8b1df-a9cf-4b2a-82ed-2e8538e1bda7" },
                    { "31BEC81A-71F6-4799-90A6-3A82D9888E95", "be32eec5-8f03-4eaa-99d6-b2eebeebfce8" },
                    { "31BEC81A-71F6-4799-90A6-3A82D9888E95", "c1e499f0-e54f-4dad-a579-d865ed8075ef" },
                    { "068120C4-B482-4D33-B59B-F8912CF44246", "c7277975-d866-4d1c-84b0-8d9df1ac7058" },
                    { "31BEC81A-71F6-4799-90A6-3A82D9888E95", "ff49eb66-aefe-412d-8e5f-897f121f7f5d" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31BEC81A-71F6-4799-90A6-3A82D9888E95", "03e12965-b521-4052-894b-e5a7ef44b9d1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31BEC81A-71F6-4799-90A6-3A82D9888E95", "241b6d78-2354-46b3-8ab8-63c68bbdf631" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31BEC81A-71F6-4799-90A6-3A82D9888E95", "39a1cce9-9123-4861-bf17-2909a7a1dff6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31BEC81A-71F6-4799-90A6-3A82D9888E95", "3a21d428-508c-4a7a-b686-2724879c764a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31BEC81A-71F6-4799-90A6-3A82D9888E95", "73af2f35-a9b2-40fa-9697-c1dee8166b26" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31BEC81A-71F6-4799-90A6-3A82D9888E95", "b5d8b1df-a9cf-4b2a-82ed-2e8538e1bda7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31BEC81A-71F6-4799-90A6-3A82D9888E95", "be32eec5-8f03-4eaa-99d6-b2eebeebfce8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31BEC81A-71F6-4799-90A6-3A82D9888E95", "c1e499f0-e54f-4dad-a579-d865ed8075ef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "068120C4-B482-4D33-B59B-F8912CF44246", "c7277975-d866-4d1c-84b0-8d9df1ac7058" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31BEC81A-71F6-4799-90A6-3A82D9888E95", "ff49eb66-aefe-412d-8e5f-897f121f7f5d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "068120C4-B482-4D33-B59B-F8912CF44246");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31BEC81A-71F6-4799-90A6-3A82D9888E95");
        }
    }
}
