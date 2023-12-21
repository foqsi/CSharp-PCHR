using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Davis_FinalProject_Cs.Migrations
{
    /// <inheritdoc />
    public partial class AddNewPatientFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EMAIL",
                table: "PATIENT_TBL",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TITLE",
                table: "PATIENT_TBL",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "PATIENT_TBL",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GENDER",
                table: "PATIENT_TBL",
                type: "nchar(1)",
                fixedLength: true,
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EMAIL",
                table: "PRIMARY_CARE_TBL",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EMAIL",
                table: "PATIENT_TBL");

            migrationBuilder.DropColumn(
                name: "TITLE",
                table: "PATIENT_TBL");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "PATIENT_TBL");

            migrationBuilder.DropColumn(
                name: "GENDER",
                table: "PATIENT_TBL");

            migrationBuilder.DropColumn(
                name: "EMAIL",
                table: "PRIMARY_CARE_TBL");
        }
    }
}
