using Microsoft.EntityFrameworkCore.Migrations;

namespace Covid19WebApp.Data.Migrations
{
    public partial class FirstSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Covid",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Oib = table.Column<int>(nullable: false),
                    ImePrezime = table.Column<string>(nullable: true),
                    rezultatiTesta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Covid", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Covid");
        }
    }
}
