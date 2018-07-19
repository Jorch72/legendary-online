using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LegendaryOnline.Data.Migrations.Hero
{
    public partial class CreateHeroes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "hero");

            migrationBuilder.CreateTable(
                name: "Hero",
                schema: "hero",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hero", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HeroCard",
                schema: "hero",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: false),
                    BaseRecruit = table.Column<int>(nullable: false),
                    BaseAttack = table.Column<int>(nullable: false),
                    Class = table.Column<int>(nullable: false),
                    Team = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    HeroID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroCard", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HeroCard_Hero_HeroID",
                        column: x => x.HeroID,
                        principalSchema: "hero",
                        principalTable: "Hero",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "hero",
                table: "Hero",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Captain Ameria" });

            migrationBuilder.CreateIndex(
                name: "IX_HeroCard_HeroID",
                schema: "hero",
                table: "HeroCard",
                column: "HeroID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroCard",
                schema: "hero");

            migrationBuilder.DropTable(
                name: "Hero",
                schema: "hero");
        }
    }
}
