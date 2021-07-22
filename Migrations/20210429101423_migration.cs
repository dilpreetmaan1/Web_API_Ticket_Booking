using Microsoft.EntityFrameworkCore.Migrations;

namespace Ticket_BookingAPI.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Booking",
                newName: "Booking_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Booking_ID",
                table: "Booking",
                newName: "Id");
        }
    }
}
