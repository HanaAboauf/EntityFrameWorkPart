using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_03.Migrations.TransportationDb
{
    /// <inheritdoc />
    public partial class TPT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CashPayment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CashPayment_Payments_Id",
                        column: x => x.Id,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreditCardPayment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCardPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreditCardPayment_Payments_Id",
                        column: x => x.Id,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CashPayment");

            migrationBuilder.DropTable(
                name: "CreditCardPayment");

            migrationBuilder.DropTable(
                name: "Payments");
        }
    }
}
