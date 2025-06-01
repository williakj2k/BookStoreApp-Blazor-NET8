using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultUserandRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "797b5927-e377-4449-af28-4ce6e8f62ff5", null, "Administrator", "ADMINISTRATOR" },
                    { "f02cf5f7-7309-409e-a96d-55e19d81be9c", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "334e575a-2158-49b3-86a9-372881ba4fec", 0, "288f2901-0dd7-4319-b36a-de8560ffa10a", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAIAAYagAAAAECFPPSLGKKb9hsjHECxcv6YNSBdF9mwOw0q1m0Zso4xzoobuYHRezIXtgpxgvNaNkQ==", null, false, "37b3eaa5-fefb-44ce-89ec-0fa1d9d9424e", false, "admin@bookstore.com" },
                    { "5497aeee-0301-417d-8619-7ae92593615e", 0, "1af9d927-c05e-490f-aa3c-7c6e5f8f0ae7", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEPlHI71Biuku+0mU+OUgyvJb0Na1U3N4LzJMwUaIWSl2OGhJ9WgnWQQLVzbzkWwWzg==", null, false, "e87e73a6-d138-42aa-b6ed-55f3598c8902", false, "user@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "797b5927-e377-4449-af28-4ce6e8f62ff5", "334e575a-2158-49b3-86a9-372881ba4fec" },
                    { "f02cf5f7-7309-409e-a96d-55e19d81be9c", "5497aeee-0301-417d-8619-7ae92593615e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "797b5927-e377-4449-af28-4ce6e8f62ff5", "334e575a-2158-49b3-86a9-372881ba4fec" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f02cf5f7-7309-409e-a96d-55e19d81be9c", "5497aeee-0301-417d-8619-7ae92593615e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "797b5927-e377-4449-af28-4ce6e8f62ff5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f02cf5f7-7309-409e-a96d-55e19d81be9c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "334e575a-2158-49b3-86a9-372881ba4fec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5497aeee-0301-417d-8619-7ae92593615e");
        }
    }
}
