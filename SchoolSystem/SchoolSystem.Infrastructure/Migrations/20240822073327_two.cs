using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class two : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassRoomId",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Salary",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_ClassRoomId",
                table: "Teachers",
                column: "ClassRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Classes_ClassRoomId",
                table: "Teachers",
                column: "ClassRoomId",
                principalTable: "Classes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Classes_ClassRoomId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_ClassRoomId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ClassRoomId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Teachers");
        }
    }
}
