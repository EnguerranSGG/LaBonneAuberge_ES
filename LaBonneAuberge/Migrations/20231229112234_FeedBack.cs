using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaBonneAuberge.Migrations
{
    /// <inheritdoc />
    public partial class FeedBack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeedBacks",
                columns: table => new
                {
                    Id_FeedBack = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Pseudo_FeedBack = table.Column<string>(type: "TEXT", nullable: false),
                    Notation_FeedBack = table.Column<int>(type: "INTEGER", nullable: false),
                    Email_FeedBack = table.Column<string>(type: "TEXT", nullable: false),
                    Message_FeedBack = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBacks", x => x.Id_FeedBack);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeedBacks");
        }
    }
}
