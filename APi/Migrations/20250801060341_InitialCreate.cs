using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationEntity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinancialYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficeInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfficeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumbers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertifiedAccountants = table.Column<int>(type: "int", nullable: false),
                    Employees = table.Column<int>(type: "int", nullable: false),
                    LicensedAccountants = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenseNumbers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedBudgets = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OfficeInfos");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
