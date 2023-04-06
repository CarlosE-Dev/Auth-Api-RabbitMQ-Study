using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Auth.Login.Infra.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AL_USERS",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AL_USERS", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AL_USERS",
                columns: new[] { "Id", "CreatedOn", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { "2d9bc878-4d56-4c75-bfae-f4e40a3e9f44", new DateTime(2023, 4, 6, 0, 44, 13, 311, DateTimeKind.Local).AddTicks(2538), "NDXUR@WSHKA.com", "BQVZS", "VZOGF", "OOZYMYXR" },
                    { "3dfb450b-c204-4e5c-abda-202cc3c3259a", new DateTime(2023, 4, 6, 0, 44, 13, 309, DateTimeKind.Local).AddTicks(6690), "PPRUU@AOWSW.com", "KBGQG", "SRCKD", "IMPEQWZS" },
                    { "6bb9ce2e-b0cb-46db-b05d-34dbb7a6de14", new DateTime(2023, 4, 6, 0, 44, 13, 311, DateTimeKind.Local).AddTicks(2559), "DAKUI@CDINQ.com", "GBOCD", "SANHA", "BDBJRVVU" },
                    { "80d7e67d-c585-45a6-b608-01e3e3d07ae2", new DateTime(2023, 4, 6, 0, 44, 13, 309, DateTimeKind.Local).AddTicks(6047), "test@test.com", "James", "Young", "test123" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AL_USERS");
        }
    }
}
