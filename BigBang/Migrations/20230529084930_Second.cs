using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BigBang.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDT",
                table: "Rooms",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "CreatedDT",
                table: "Hotels",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "CreatedDT",
                table: "Employees",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "CreatedDT",
                table: "Customers",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "CreatedDT",
                table: "Bookings",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "CheckOut",
                table: "Bookings",
                newName: "CheckOutDate");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomType",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RoomType",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Hotels");

            migrationBuilder.RenameColumn(
                name: "Key",
                table: "Rooms",
                newName: "CreatedDT");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Hotels",
                newName: "CreatedDT");

            migrationBuilder.RenameColumn(
                name: "Key",
                table: "Employees",
                newName: "CreatedDT");

            migrationBuilder.RenameColumn(
                name: "Key",
                table: "Customers",
                newName: "CreatedDT");

            migrationBuilder.RenameColumn(
                name: "Key",
                table: "Bookings",
                newName: "CreatedDT");

            migrationBuilder.RenameColumn(
                name: "CheckOutDate",
                table: "Bookings",
                newName: "CheckOut");
        }
    }
}
