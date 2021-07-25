using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Factura_V3.Migrations
{
    public partial class NewOrderForReceipt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReceiptDetails_Receipts_ReceiptId",
                table: "ReceiptDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceiptHeads_Companies_CompanyId",
                table: "ReceiptHeads");

            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropIndex(
                name: "IX_ReceiptHeads_CompanyId",
                table: "ReceiptHeads");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "ReceiptHeads");

            migrationBuilder.RenameColumn(
                name: "ReceiptId",
                table: "ReceiptDetails",
                newName: "ReceiptHeadId");

            migrationBuilder.RenameIndex(
                name: "IX_ReceiptDetails_ReceiptId",
                table: "ReceiptDetails",
                newName: "IX_ReceiptDetails_ReceiptHeadId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "ReceiptHeads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiptDetails_ReceiptHeads_ReceiptHeadId",
                table: "ReceiptDetails",
                column: "ReceiptHeadId",
                principalTable: "ReceiptHeads",
                principalColumn: "ReceiptHeadId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReceiptDetails_ReceiptHeads_ReceiptHeadId",
                table: "ReceiptDetails");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "ReceiptHeads");

            migrationBuilder.RenameColumn(
                name: "ReceiptHeadId",
                table: "ReceiptDetails",
                newName: "ReceiptId");

            migrationBuilder.RenameIndex(
                name: "IX_ReceiptDetails_ReceiptHeadId",
                table: "ReceiptDetails",
                newName: "IX_ReceiptDetails_ReceiptId");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "ReceiptHeads",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    ReceiptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceiptHeadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.ReceiptId);
                    table.ForeignKey(
                        name: "FK_Receipts_ReceiptHeads_ReceiptHeadId",
                        column: x => x.ReceiptHeadId,
                        principalTable: "ReceiptHeads",
                        principalColumn: "ReceiptHeadId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptHeads_CompanyId",
                table: "ReceiptHeads",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_ReceiptHeadId",
                table: "Receipts",
                column: "ReceiptHeadId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiptDetails_Receipts_ReceiptId",
                table: "ReceiptDetails",
                column: "ReceiptId",
                principalTable: "Receipts",
                principalColumn: "ReceiptId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiptHeads_Companies_CompanyId",
                table: "ReceiptHeads",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
