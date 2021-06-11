using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberShop_Sukhmanbir.Data.Migrations
{
    public partial class Init11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Staffs_StaffID",
                table: "Bookings");

            migrationBuilder.AlterColumn<int>(
                name: "StaffID",
                table: "Bookings",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Staffs_StaffID",
                table: "Bookings",
                column: "StaffID",
                principalTable: "Staffs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Staffs_StaffID",
                table: "Bookings");

            migrationBuilder.AlterColumn<int>(
                name: "StaffID",
                table: "Bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Staffs_StaffID",
                table: "Bookings",
                column: "StaffID",
                principalTable: "Staffs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
