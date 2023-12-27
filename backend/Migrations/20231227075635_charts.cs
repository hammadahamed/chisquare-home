using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL;

#nullable disable

namespace chi2.Migrations
{
    /// <inheritdoc />
    public partial class charts : Migration
    {
                protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Charts",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Type = table.Column<string>(nullable: true),
                DataType = table.Column<string>(nullable: true),
                Overall = table.Column<System.Text.Json.JsonDocument>(type: "jsonb", nullable: true), // Explicitly set data type to jsonb
                Monthly = table.Column<System.Text.Json.JsonDocument>(type: "jsonb", nullable: true), // Explicitly set data type to jsonb
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Charts", x => x.Id);
            });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Charts");
    }
        
    }
}
