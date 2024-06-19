using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMC_baithi2324.Migrations
{
    /// <inheritdoc />
    public partial class create_table_Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Hovaten = table.Column<string>(type: "TEXT", nullable: false),
                    Masv = table.Column<string>(type: "TEXT", nullable: false),
                    Love = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Hovaten);
                    table.ForeignKey(
                        name: "FK_Employees_Persons_Hovaten",
                        column: x => x.Hovaten,
                        principalTable: "Persons",
                        principalColumn: "Hovaten",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
