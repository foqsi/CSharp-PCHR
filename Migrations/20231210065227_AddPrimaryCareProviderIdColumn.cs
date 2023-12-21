using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Davis_FinalProject_Cs.Migrations
{
    /// <inheritdoc />
    public partial class AddPrimaryCareProviderIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PRIMARY_CARE_PROVIDER_ID",
                table: "PRIMARY_CARE_TBL",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PRIMARY_CARE_PROVIDER_ID",
                table: "PATIENT_TBL",
                type: "nchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PATIENT_TBL_PRIMARY_CARE_PROVIDER_ID",
                table: "PATIENT_TBL",
                column: "PRIMARY_CARE_PROVIDER_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PATIENT_TBL_PRIMARY_CARE_TBL",
                table: "PATIENT_TBL",
                column: "PRIMARY_CARE_PROVIDER_ID",
                principalTable: "PRIMARY_CARE_TBL",
                principalColumn: "PRIMARY_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PATIENT_TBL_PRIMARY_CARE_TBL",
                table: "PATIENT_TBL");

            migrationBuilder.DropTable(
                name: "EMERGENCY_CONTACT_TBL");

            migrationBuilder.DropIndex(
                name: "IX_PATIENT_TBL_PRIMARY_CARE_PROVIDER_ID",
                table: "PATIENT_TBL");

            migrationBuilder.DropColumn(
                name: "PRIMARY_CARE_PROVIDER_ID",
                table: "PRIMARY_CARE_TBL");

            migrationBuilder.DropColumn(
                name: "PRIMARY_CARE_PROVIDER_ID",
                table: "PATIENT_TBL");
        }
    }
}
