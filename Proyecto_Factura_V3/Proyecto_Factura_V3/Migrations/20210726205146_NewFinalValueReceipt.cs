using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Factura_V3.Migrations
{
    public partial class NewFinalValueReceipt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FinalValue",
                table: "ReceiptHeads",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalValue",
                table: "ReceiptHeads");
        }
    }
}
