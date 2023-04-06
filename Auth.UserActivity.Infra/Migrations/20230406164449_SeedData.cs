using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Auth.UserActivity.Infra.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AUA_USER_ACTIVITIES",
                columns: new[] { "UserId", "LastAccess", "LastClientIP", "RegisteredOn", "SessionExpire", "UserCompleteName", "UserEmail" },
                values: new object[,]
                {
                    { "55882d84-8e41-4ef6-9436-cc08cf6f4757", new DateTime(2023, 4, 5, 13, 44, 49, 540, DateTimeKind.Local).AddTicks(7273), "181.11.1.1", new DateTime(2023, 4, 5, 13, 44, 49, 540, DateTimeKind.Local).AddTicks(7968), new DateTime(2023, 4, 5, 14, 44, 49, 540, DateTimeKind.Local).AddTicks(8164), "Maicon Andrews", "maicon.andrew@mail.com" },
                    { "70c98565-b456-4e4b-97d8-7733c503a640", new DateTime(2023, 4, 5, 13, 44, 49, 540, DateTimeKind.Local).AddTicks(9592), "181.11.1.1", new DateTime(2023, 4, 5, 13, 44, 49, 540, DateTimeKind.Local).AddTicks(9598), new DateTime(2023, 4, 5, 14, 44, 49, 540, DateTimeKind.Local).AddTicks(9598), "Matthew Anderson", "matt.anderson@mail.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AUA_USER_ACTIVITIES",
                keyColumn: "UserId",
                keyValue: "55882d84-8e41-4ef6-9436-cc08cf6f4757");

            migrationBuilder.DeleteData(
                table: "AUA_USER_ACTIVITIES",
                keyColumn: "UserId",
                keyValue: "70c98565-b456-4e4b-97d8-7733c503a640");
        }
    }
}
