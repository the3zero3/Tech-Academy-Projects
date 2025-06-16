using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarInsurance.Migrations
{
    /// <inheritdoc />
    public partial class ChangedDateToInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CarYear",
                table: "Insurees",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "CarYear",
                table: "Insurees",
                type: "date",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
