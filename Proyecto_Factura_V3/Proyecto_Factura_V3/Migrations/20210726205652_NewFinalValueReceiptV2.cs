using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Factura_V3.Migrations
{
    public partial class NewFinalValueReceiptV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "FinalValue",
                table: "ReceiptHeads",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FinalValue",
                table: "ReceiptHeads",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
