using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BooksManagement.Infra.Data.Migrations
{
    public partial class _20112021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "classification",
                table: "Book",
                type: "decimal(5,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "price_average",
                table: "Book",
                type: "decimal(5,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "publication_date",
                table: "Book",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "synopse",
                table: "Book",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "classification",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "price_average",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "publication_date",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "synopse",
                table: "Book");
        }
    }
}
