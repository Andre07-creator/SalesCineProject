using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesCineProject.Migrations
{
    public partial class UpdateEntites : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Client_ClientId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_SalesRecord_SalesRecordId",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "SalesRecord");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_ClientId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_SalesRecordId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Hour",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "SalesRecordId",
                table: "Ticket");

            migrationBuilder.RenameColumn(
                name: "NameMovie",
                table: "Ticket",
                newName: "Client");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Ticket",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Payment",
                table: "Ticket",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Ticket",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Hour = table.Column<DateTime>(nullable: false),
                    TicketId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movie_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Ticket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_TicketId",
                table: "Movie",
                column: "TicketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Payment",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Ticket");

            migrationBuilder.RenameColumn(
                name: "Client",
                table: "Ticket",
                newName: "NameMovie");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Ticket",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Hour",
                table: "Ticket",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalesRecordId",
                table: "Ticket",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Payment = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesRecord", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ClientId",
                table: "Ticket",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_SalesRecordId",
                table: "Ticket",
                column: "SalesRecordId");

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
    }
}
