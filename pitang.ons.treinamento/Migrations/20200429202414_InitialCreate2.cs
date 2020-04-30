using Microsoft.EntityFrameworkCore.Migrations;

namespace pitang.ons.treinamento.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contact_user_UserId",
                table: "contact");

            migrationBuilder.DropIndex(
                name: "IX_contact_UserId",
                table: "contact");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "contact");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "contact",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_contact_UserId",
                table: "contact",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_contact_user_UserId",
                table: "contact",
                column: "UserId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
