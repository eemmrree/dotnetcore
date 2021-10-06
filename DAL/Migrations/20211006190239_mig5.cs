using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactDate",
                table: "Contacts",
                newName: "ContactDate2");

            migrationBuilder.AddColumn<bool>(
                name: "ContactStatus2",
                table: "Contacts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactStatus2",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "ContactDate2",
                table: "Contacts",
                newName: "ContactDate");
        }
    }
}
