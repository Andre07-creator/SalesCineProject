using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesCineProject.Migrations
{
    public partial class ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Client_ClientId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_SalesRecord_SalesRecordId",
                table: "Ticket");

            migrationBuilder.RenameColumn(
                name: "hour",
                table: "Ticket",
                newName: "Hour");

            migrationBuilder.AlterColumn<int>(
                name: "SalesRecordId",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Client_ClientId",
                table: "Ticket",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_SalesRecord_SalesRecordId",
                table: "Ticket",
                column: "SalesRecordId",
                principalTable: "SalesRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Client_ClientId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_SalesRecord_SalesRecordId",
                table: "Ticket");

            migrationBuilder.RenameColumn(
                name: "Hour",
                table: "Ticket",
                newName: "hour");

            migrationBuilder.AlterColumn<int>(
                name: "SalesRecordId",
                table: "Ticket",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Ticket",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Client_ClientId",
                table: "Ticket",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_SalesRecord_SalesRecordId",
                table: "Ticket",
                column: "SalesRecordId",
                principalTable: "SalesRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
