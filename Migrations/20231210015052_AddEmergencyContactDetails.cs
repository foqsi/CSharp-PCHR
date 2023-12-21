using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Davis_FinalProject_Cs.Migrations
{
    /// <inheritdoc />
    public partial class AddEmergencyContactDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EMERGENCY_CONTACT_TBL",
                columns: table => new
                {
                    PATIENT_ID = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    FIRST_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LAST_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    RELATIONSHIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ADDRESS_STREET = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ADDRESS_SUBURB = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ADDRESS_CITY = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ADDRESS_ZIP = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    PHONE_HOME = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    PHONE_MOBILE = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    PHONE_WORK = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    FAX = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMERGENCY_CONTACT_TBL", x => x.PATIENT_ID);
            });

            migrationBuilder.AddColumn<string>(
                name: "FAX",
                table: "PATIENT_TBL",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EMERGENCY_CONTACT_TBL");

            migrationBuilder.DropColumn(
                name: "FAX",
                table: "PATIENT_TBL");
        }
    }
}
