using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TomogotchiP1.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePetModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Pets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Cleanliness",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Happiness",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HealthStatus",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HungerLevel",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastCleaned",
                table: "Pets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastFed",
                table: "Pets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastPlayedWith",
                table: "Pets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LifeStage",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Pets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "Cleanliness",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "Happiness",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "HealthStatus",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "HungerLevel",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "LastCleaned",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "LastFed",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "LastPlayedWith",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "LifeStage",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Pets");
        }
    }
}
