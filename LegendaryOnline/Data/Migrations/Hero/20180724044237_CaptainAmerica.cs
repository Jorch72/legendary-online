using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LegendaryOnline.Data.Migrations.Hero
{
    public partial class CaptainAmerica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeroCard_Hero_HeroID",
                schema: "hero",
                table: "HeroCard");

            migrationBuilder.AlterColumn<int>(
                name: "HeroID",
                schema: "hero",
                table: "HeroCard",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "HeroClass",
                schema: "hero",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Class = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeroTeam",
                schema: "hero",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Team = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroTeam", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "hero",
                table: "Hero",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Captain America");

            migrationBuilder.InsertData(
                schema: "hero",
                table: "HeroCard",
                columns: new[] { "ID", "BaseAttack", "BaseRecruit", "Class", "Cost", "HeroID", "ImagePath", "Name", "Team" },
                values: new object[,]
                {
                    { 1, 0, 0, 4, 3, 1, "core/captain/aa.jpg", "Avengers Assemble!", 2 },
                    { 2, 0, 0, 2, 4, 1, "core/captain/pt.jpg", "Perfect Teamwork", 2 },
                    { 3, 4, 0, 16, 6, 1, "core/captain/db.jpg", "Diving Block", 2 },
                    { 4, 3, 0, 8, 7, 1, "core/captain/aduao.jpg", "A Day Unlike Any Other", 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_HeroCard_Hero_HeroID",
                schema: "hero",
                table: "HeroCard",
                column: "HeroID",
                principalSchema: "hero",
                principalTable: "Hero",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeroCard_Hero_HeroID",
                schema: "hero",
                table: "HeroCard");

            migrationBuilder.DropTable(
                name: "HeroClass",
                schema: "hero");

            migrationBuilder.DropTable(
                name: "HeroTeam",
                schema: "hero");

            migrationBuilder.DeleteData(
                schema: "hero",
                table: "HeroCard",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "hero",
                table: "HeroCard",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "hero",
                table: "HeroCard",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "hero",
                table: "HeroCard",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.AlterColumn<int>(
                name: "HeroID",
                schema: "hero",
                table: "HeroCard",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                schema: "hero",
                table: "Hero",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Captain Ameria");

            migrationBuilder.AddForeignKey(
                name: "FK_HeroCard_Hero_HeroID",
                schema: "hero",
                table: "HeroCard",
                column: "HeroID",
                principalSchema: "hero",
                principalTable: "Hero",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
