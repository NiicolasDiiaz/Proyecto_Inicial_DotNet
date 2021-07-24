using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Factura_V3.Migrations
{
    public partial class NewMigrationV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReceiptDetails_Receipts_ReceiptId",
                table: "ReceiptDetails");

            migrationBuilder.AlterColumn<int>(
                name: "ReceiptId",
                table: "ReceiptDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiptDetails_Receipts_ReceiptId",
                table: "ReceiptDetails",
                column: "ReceiptId",
                principalTable: "Receipts",
                principalColumn: "ReceiptId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReceiptDetails_Receipts_ReceiptId",
                table: "ReceiptDetails");

            migrationBuilder.AlterColumn<int>(
                name: "ReceiptId",
                table: "ReceiptDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiptDetails_Receipts_ReceiptId",
                table: "ReceiptDetails",
                column: "ReceiptId",
                principalTable: "Receipts",
                principalColumn: "ReceiptId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
