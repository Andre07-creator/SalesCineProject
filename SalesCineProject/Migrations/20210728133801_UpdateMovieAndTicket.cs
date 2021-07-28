using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesCineProject.Migrations
{
    public partial class UpdateMovieAndTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Ticket_TicketId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_TicketId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Movie");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_MovieId",
                table: "Ticket",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Movie_MovieId",
                table: "Ticket",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Movie_MovieId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_MovieId",
                table: "Ticket");

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Movie",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_TicketId",
                table: "Movie",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Ticket_TicketId",
                table: "Movie",
                column: "TicketId",
                principalTable: "Ticket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
