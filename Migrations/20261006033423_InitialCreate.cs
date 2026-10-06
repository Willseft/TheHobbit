using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TheHobbit.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeLand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Age", "HomeLand", "Name", "Race" },
                values: new object[,]
                {
                    { 1, 50, "The Shire", "Bilbo Baggins", "Hobbit" },
                    { 2, 2000, "Valinor", "Gandalf", "Maia" },
                    { 3, 195, "Erebor", "Thorin Oakenshield", "Dwarf" },
                    { 4, 589, "The Misty Mountains", "Gollum", "Hobbit" },
                    { 5, 171, "Erebor", "Smaug", "Dragon" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
